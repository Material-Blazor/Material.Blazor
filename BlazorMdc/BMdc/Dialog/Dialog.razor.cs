using BBase;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BMdc
{
    /// <summary>
    /// This is a general purpose Material Theme dialog. The BlazorMdc dialog implementation does not render a dialog at all until
    /// it is shown by the consumer. At this stage it is rendered and Material Theme is permitted to control it's opening and to 
    /// intiate it and its embedded components. Likewise when the dialog is closed, Material Theme is permitted to close the dialog
    /// gracefully before BlazorMdc removes the markup.
    /// </summary>
    public partial class Dialog : BBase.ComponentBase, IDisposable, BModel.IDialog
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
        /// is set for a button: <see cref="MdcButton"/> does this via its <see cref="MdcButton.DialogAction"/>
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


        private ElementReference DialogElem { get; set; }
        private System.Collections.Generic.List<BModel.IDialogChild> LayoutChildren { get; set; } = new System.Collections.Generic.List<BModel.IDialogChild>();
        private DotNetObjectReference<Dialog> ObjectReference { get; set; }
        private string OverflowClass => OverflowVisible ? "bmdc-dialog-overflow-visible" : "";


        private readonly string titleId = BBase.Utilities.GenerateUniqueElementName();
        private readonly string descId = BBase.Utilities.GenerateUniqueElementName();
        private bool isOpen = false;
        private bool afterRenderShowAction = false;
        private bool afterDialogInitialization = false;
        private string key = "";
        TaskCompletionSource<string> tcs;


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
        void BModel.IDialog.RegisterLayoutAction(BModel.IDialogChild child)
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
                throw new InvalidOperationException("Cannot show MdcDialog that is already open");
            }
            else
            {
                LayoutChildren.Clear();
                key = BBase.Utilities.GenerateUniqueElementName();
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
                StateHasChanged();
            }
            else
            {
                throw new InvalidOperationException("Cannot hide MdcDialog that is not already open");
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

                StateHasChanged();
            }
        }
    }
}
