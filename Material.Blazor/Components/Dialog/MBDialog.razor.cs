using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor
{
    /// <summary>
    /// This is a general purpose Material Theme dialog. The Material.Blazor dialog implementation does not render a dialog at all until
    /// it is shown by the consumer. At this stage it is rendered and Material Theme is permitted to control it's opening and to 
    /// intiate it and its embedded components. Likewise when the dialog is closed, Material Theme is permitted to close the dialog
    /// gracefully before Material.Blazor removes the markup.
    /// </summary>
    public partial class MBDialog : ComponentFoundation, IMBDialog
    {
        /// <summary>
        /// The dialog title.
        /// </summary>
        [Parameter] public string Title { get; set; }


        /// <summary>
        /// Render fragment for the dialog header.
        /// </summary>
        [Parameter] public RenderFragment Header { get; set; }


        /// <summary>
        /// Render fragment for the dialog body.
        /// </summary>
        [Parameter] public RenderFragment Body { get; set; }


        /// <summary>
        /// Render fragment for the dialog buttons. Note that the dialog will 
        /// return actions to the consumer when the <c>data-mdc-dialog-action</c> attribute
        /// is set for a button: <see cref="MBButton"/> does this via its <see cref="MBButton.DialogAction"/>
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
        bool IMBDialog.DialogHasInstantiated => dialogHasInstantiated;


        private ElementReference DialogElem { get; set; }
        private bool HasBody => Body != null;
        private bool HasButtons => Buttons != null;
        private bool HasHeader => Header != null;
        private bool HasTitle => !string.IsNullOrWhiteSpace(Title);
        private List<DialogChildComponent> LayoutChildren { get; set; } = new List<DialogChildComponent>();
        private DotNetObjectReference<MBDialog> ObjectReference { get; set; }
        private string OverflowClass => OverflowVisible ? "mb-dialog-overflow-visible" : "";


        private readonly string bodyId = Utilities.GenerateUniqueElementName();
        private readonly string headerId = Utilities.GenerateUniqueElementName();
        private readonly string titleId = Utilities.GenerateUniqueElementName();

        private bool dialogHasInstantiated = false;

        private bool AfterDialogInitialization { get; set; } = false;
        private bool AfterRenderShowAction { get; set; } = false;
        private bool IsOpen { get; set; } = false;
        private string Key { get; set; } = "";
        private Dictionary<string, object> MyAttributes { get; set; }
        private TaskCompletionSource<string> Tcs { get; set; }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapperInstance
                .Add("mdc-dialog");

            ObjectReference = DotNetObjectReference.Create(this);

            BuildMyAttributes();
        }


        private void BuildMyAttributes()
        {
            MyAttributes = (from a in AttributesToSplat()
                            select new KeyValuePair<string, object>(a.Key, a.Value))
                            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            if (HasTitle)
            {
                MyAttributes.Add("aria-labelledby", titleId);
            }

            if (HasBody)
            {
                MyAttributes.Add("aria-describedby", bodyId);
            }
        }


        private bool _disposed = false;
        protected override void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                ObjectReference?.Dispose();
            }

            _disposed = true;

            base.Dispose(disposing);
        }


        /// <inheritdoc/>
        void IMBDialog.RegisterLayoutAction(DialogChildComponent child)
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
            if (IsOpen)
            {
                throw new InvalidOperationException("Cannot show MBDialog that is already open");
            }
            else
            {
                LayoutChildren.Clear();
                Key = Utilities.GenerateUniqueElementName();
                IsOpen = true;
                AfterRenderShowAction = true;
                StateHasChanged();
                Tcs = new TaskCompletionSource<string>();
                var ret = await Tcs.Task;
                dialogHasInstantiated = false;
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
            if (IsOpen)
            {
                await JsRuntime.InvokeAsync<string>("MaterialBlazor.MBDialog.hide", DialogElem);
                IsOpen = false;
                dialogHasInstantiated = false;
                StateHasChanged();
            }
            else
            {
                throw new InvalidOperationException("Cannot hide MBDialog that is not already open");
            }
        }


        [JSInvokable("NotifyOpenedAsync")]
        public async Task NotifyOpenedAsync()
        {
            AfterDialogInitialization = true;
            StateHasChanged();
            await Task.CompletedTask;
        }


        /// <summary>
        /// Shows the dialog on the next render after a show action. Also on the next render after the dialog is initiated each
        /// embedded Material.Blazor component is initiated here.
        /// </summary>
        /// <param name="firstRender"></param>
        /// <returns></returns>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);

            if (AfterRenderShowAction)
            {
                try
                {
                    AfterRenderShowAction = false;
                    Tcs.SetResult(await JsRuntime.InvokeAsync<string>("MaterialBlazor.MBDialog.show", DialogElem, ObjectReference, EscapeKeyAction, ScrimClickAction));
                    IsOpen = false;
                    StateHasChanged();
                }
                catch
                {
                    Tcs?.SetCanceled();
                }
            }
            else if (AfterDialogInitialization)
            {
                AfterDialogInitialization = false;

                foreach (var child in LayoutChildren)
                {
                    child.RequestInstantiation();
                }

                LayoutChildren.Clear();

                dialogHasInstantiated = true;
            }
        }
    }
}
