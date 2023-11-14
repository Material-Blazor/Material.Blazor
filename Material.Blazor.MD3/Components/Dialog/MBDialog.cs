using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor
{
    public class MBDialog : ComponentFoundation
    {
        #region members

        /// <summary>
        /// Render fragment for the dialog body.
        /// </summary>
        [Parameter] public RenderFragment Body { get; set; }

        /// <summary>
        /// The list of button items.
        /// </summary>
        [Parameter] public MBDialogButton[] ButtonItems { get; set; }

        /// <summary>
        /// A unique ID for the dialog
        /// Can be accomplished with careful naming or something like 
        ///     "dialog-id-" + Guid.NewGuid().ToString().ToLower();
        /// </summary>
        [Parameter, EditorRequired] public string DialogId { get; set; }

        /// <summary>
        /// The action returned by the dialog when the escape key is pressed. Defaults to "close". Setting
        /// this to "" will disable the escape key action.
        /// </summary>
        [Parameter] public string EscapeKeyAction { get; set; } = "close";

        /// <summary>
        /// Render fragment for the dialog header.
        /// </summary>
        [Parameter] public RenderFragment Header { get; set; }

        /// <summary>
        /// The action returned by the dialog when the scrim is clicked. Defaults to "close". Setting
        /// this to "" will disable scrim click action.
        /// </summary>
        [Parameter] public string ScrimClickAction { get; set; } = "close";

        /// <summary>
        /// The dialog title.
        /// </summary>
        [Parameter] public string Title { get; set; }



        private TaskCompletionSource<string> CloseReasonTaskCompletionSource { get; set; }
        private bool HasBody => Body != null || false;
        private bool HasButtons => ButtonItems != null || false;
        private bool HasHeader => Header != null;
        private bool HasTitle => !string.IsNullOrWhiteSpace(Title);
        private string IdBody { get; } = Utilities.GenerateUniqueElementName();
        private string IdHeader { get; } = Utilities.GenerateUniqueElementName();
        private string IdTitle { get; } = Utilities.GenerateUniqueElementName();
        private bool IsOpen { get; set; }
        private TaskCompletionSource OpenedTaskCompletionSource { get; set; } = new();
        internal Task Opened => OpenedTaskCompletionSource.Task;

        #endregion

        #region BuildRenderTree
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            var attributesToSplat = AttributesToSplat().ToArray();
            var rendSeq = 0;

            builder.OpenElement(rendSeq++, "md-dialog");
            {
                builder.AddAttribute(rendSeq++, "class", @class);
                builder.AddAttribute(rendSeq++, "style", style);
                builder.AddAttribute(rendSeq++, "id", DialogId);
                if (attributesToSplat.Any())
                {
                    builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
                }

                if (HasHeader || HasTitle)
                {
                    builder.OpenElement(rendSeq++, "div");
                    {
                        builder.AddAttribute(rendSeq++, "slot", "header");

                        if (HasHeader)
                        {
                            builder.OpenElement(rendSeq++, "div");
                            {
                                builder.AddContent(rendSeq++, Header);
                            }
                            builder.CloseElement();
                        }
                        else
                        {
                            builder.OpenElement(rendSeq++, "div");
                            {
                                builder.AddContent(rendSeq++, Title);
                            }
                            builder.CloseElement();
                        }
                    }
                    builder.CloseElement();
                }
            }
            builder.CloseElement();
        }

        #endregion

        #region HideAsync

        /// <summary>
        /// Hides the dialog by allowing Material Theme to close it gracefully.
        /// </summary>
        public async Task HideAsync()
        {
            if (IsOpen)
            {
                await InvokeJsVoidAsync("MaterialBlazor.MBDialog.dialogHide", DialogId);
            }
            else
            {
                throw new InvalidOperationException("Cannot hide MBDialog that is not already open");
            }
        }

        #endregion

        #region ShowAsync

        /// <summary>
        /// Shows the dialog by having Material Web open the dialog.
        /// </summary>
        /// <returns>The action string resulting from dialog closure</returns>
        public async Task<string> ShowAsync()
        {
            if (IsOpen)
            {
                throw new InvalidOperationException("Cannot show MBDialog that is already open");
            }
            else
            {
                await InvokeJsVoidAsync("MaterialBlazor.MBDialog.dialogShow", DialogId).ConfigureAwait(false);
                CloseReasonTaskCompletionSource = new();
                OpenedTaskCompletionSource = new();
                IsOpen = true;
                return await CloseReasonTaskCompletionSource.Task;
            }
        }

        #endregion

    }
}
