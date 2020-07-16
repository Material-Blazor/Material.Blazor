using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// This is a general purpose Material Theme dialog. The BlazorMdc dialog implementation does not render a dialog at all until
    /// it is shown by the consumer. At this stage it is rendered and Material Theme is permitted to control it's opening and to 
    /// intiate it and its embedded components. Likewise when the dialog is closed, Material Theme is permitted to close the dialog
    /// gracefully before BlazorMdc removes the markup.
    /// </summary>
    public partial class MTDialog : ComponentFoundation, IDisposable, IMTDialog
    {
        /// <summary>
        /// The dialog title.
        /// </summary>
        [Parameter] public string Title { get; set; }


        /// <summary>
        /// Render fragment for the dialog body.
        /// </summary>
        [Parameter] public RenderFragment Body { get; set; }


        /// <summary>
        /// Render fragment for the dialog buttons. Note that the dialog will 
        /// return actions to the consumer when the <c>data-mdc-dialog-action</c> attribute
        /// is set for a button: <see cref="MTButton"/> does this via its <see cref="MTButton.DialogAction"/>
        /// parameter.
        /// </summary>
        [Parameter] public RenderFragment Buttons { get; set; }


        /// <summary>
        /// The action returned by the dialog when the scrim is clicked. Defaults to "close". Setting
        /// this to "" will disable scrim click action.
        /// </summary>
        [Parameter] public string ScrimClickAction { get; set; } = "close";


        /// <summary>
        /// The action returned by the dialog when the escape key is pressed. Defaults to "close". Setting
        /// this to "" will disable the escape key action.
        /// </summary>
        [Parameter] public string EscapeKeyAction { get; set; } = "close";


        /// <summary>
        /// Dialogs by default apply <c>overflow: hidden;</c>. This means that selects or datepickers are often
        /// cropped. Set this parameter to true to make the dialog apply <c>overflow: visible;</c> to rectify this.
        /// Defaults to false.
        /// </summary>
        [Parameter] public bool OverflowVisible { get; set; } = false;


        /// <summary>
        /// True once the dialog has instantiated components for the first time.
        /// </summary>
        bool IMTDialog.HasInstantiated => _hasInstantiated;


        private ElementReference DialogElem { get; set; }
        private List<IMTDialogChild> LayoutChildren { get; set; } = new List<IMTDialogChild>();
        private DotNetObjectReference<MTDialog> ObjectReference { get; set; }
        private string OverflowClass => OverflowVisible ? "bmdc-dialog-overflow-visible" : "";


        private readonly string titleId = Utilities.GenerateUniqueElementName();
        private readonly string descId = Utilities.GenerateUniqueElementName();
        private bool isOpen = false;
        private bool afterRenderShowAction = false;
        private bool afterDialogInitialization = false;
        private string key = "";
        private TaskCompletionSource<string> tcs;
        private bool _hasInstantiated = false;


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-dialog");

            ObjectReference = DotNetObjectReference.Create(this);
        }


        /// <inheritdoc/>
        public void Dispose()
        {
            ObjectReference?.Dispose();
        }


        /// <inheritdoc/>
        void IMTDialog.RegisterLayoutAction(IMTDialogChild child)
        {
            LayoutChildren.Add(child);
        }


        /// <summary>
        /// Shows the dialog. This first renders the Blazor markup and then allows
        /// Material Theme to open the dialog, subsequently intiating all embedded Blazor components.
        /// </summary>
        /// <returns>The action string resulting form dialog closure</returns>
        public async Task<string> ShowAsync()
        {
            if (isOpen)
            {
                throw new InvalidOperationException("Cannot show MTDialog that is already open");
            }
            else
            {
                LayoutChildren.Clear();
                key = Utilities.GenerateUniqueElementName();
                isOpen = true;
                afterRenderShowAction = true;
                StateHasChanged();
                tcs = new TaskCompletionSource<string>();
                var ret = await tcs.Task;
                return ret;
            }
        }



        /// <summary>
        /// Hides the dialog first by allowing Material Theme to close it gracefully, then
        /// removing the Blazor markup.
        /// </summary>
        /// <returns></returns>
        public async Task HideAsync()
        {
            if (isOpen)
            {
                await JsRuntime.InvokeAsync<string>("BlazorMdc.dialog.hide", DialogElem);
                isOpen = false;
                _hasInstantiated = false;
                StateHasChanged();
            }
            else
            {
                throw new InvalidOperationException("Cannot hide MTDialog that is not already open");
            }
        }


        [JSInvokable("NotifyOpenedAsync")]
        public async Task NotifyOpenedAsync()
        {
            afterDialogInitialization = true;
            StateHasChanged();
            await Task.CompletedTask;
        }


        /// <summary>
        /// Shows the dialog on the next render after a show action. Also on the next render after the dialog is initiated each
        /// embedded BlazorMdc component is initiated here.
        /// </summary>
        /// <param name="firstRender"></param>
        /// <returns></returns>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            base.OnAfterRender(firstRender);

            if (afterRenderShowAction)
            {
                try
                {
                    afterRenderShowAction = false;
                    tcs.SetResult(await JsRuntime.InvokeAsync<string>("BlazorMdc.dialog.show", DialogElem, ObjectReference, EscapeKeyAction, ScrimClickAction));
                    isOpen = false;
                    StateHasChanged();
                }
                catch
                {
                    tcs?.SetCanceled();
                }
            }
            else if (afterDialogInitialization)
            {
                afterDialogInitialization = false;

                foreach (var child in LayoutChildren)
                {
                    child.RequestInstantiation();
                }

                LayoutChildren.Clear();

                _hasInstantiated = true;

                StateHasChanged();
            }
        }
    }
}
