using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.JSInterop;

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
        /// The action returned by the dialog when the escape key is pressed. Defaults to "close". Setting
        /// this to "" will disable the escape key action.
        /// </summary>
        [Parameter] public string EscapeKeyAction { get; set; } = "close";

        /// <summary>
        /// The dialog title.
        /// </summary>
        [Parameter] public string Headline { get; set; }

        /// <summary>
        /// The icon attributes.
        /// </summary>
        [Parameter] public MBIconDescriptor IconDescriptor { get; set; }

        /// <summary>
        /// The action returned by the dialog when the scrim is clicked. Defaults to "close". Setting
        /// this to "" will disable scrim click action.
        /// </summary>
        [Parameter] public string ScrimClickAction { get; set; } = "close";



        private TaskCompletionSource<string> CloseReasonTaskCompletionSource { get; set; }
        private string DialogId { get; set; } = "dialog-id-" + Guid.NewGuid().ToString().ToLower();
        private string FormId { get; set; } = "form-id-" + Guid.NewGuid().ToString().ToLower();
        private bool IsOpen { get; set; }
        private DotNetObjectReference<MBDialog> ObjectReference { get; set; }

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

                if (IconDescriptor is not null)
                {
                    MBIcon.BuildRenderTreeWorker(
                        builder,
                        ref rendSeq,
                        CascadingDefaults,
                        attributesToSplat,
                        "",
                        "",
                        "",
                        IconDescriptor,
                        "icon");
                }

                if (!string.IsNullOrWhiteSpace(Headline))
                {
                    builder.OpenElement(rendSeq++, "div");
                    {
                        builder.AddAttribute(rendSeq++, "slot", "headline");
                        builder.AddContent(rendSeq++, Headline);
                    }
                    builder.CloseElement();
                }

                if (Body is not null)
                {
                    builder.OpenElement(rendSeq++, "form");
                    {
                        builder.AddAttribute(rendSeq++, "id", FormId);
                        builder.AddAttribute(rendSeq++, "slot", "content");
                        builder.AddAttribute(rendSeq++, "method", "dialog");

                        builder.AddContent(rendSeq++, Body);
                    }
                    builder.CloseElement();
                }

                if (ButtonItems is not null)
                {
                    builder.OpenElement(rendSeq++, "div");
                    {
                        builder.AddAttribute(rendSeq++, "slot", "actions");

                        foreach (var button in ButtonItems)
                        {
                            MBButton.BuildRenderTreeWorker(
                                builder,
                                ref rendSeq,
                                CascadingDefaults,
                                attributesToSplat,
                                "",
                                "",
                                "",
                                AppliedDisabled,
                                button.ButtonStyle,
                                null,
                                false,
                                button.ButtonLabel,
                                FormId,
                                button.ButtonValue);

                        }
                    }
                    builder.CloseElement();
                }
            }
            builder.CloseElement();
        }

        #endregion

        #region Dispose

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

        #endregion

        #region NotifyClosed

        /// <summary>
        /// Do not use. This method is used internally for receiving the "dialog closed" event from javascript.
        /// </summary>
        [JSInvokable]
        public async Task NotifyClosed(string reason)
        {
            _ = (CloseReasonTaskCompletionSource?.TrySetResult(reason));
            // Allow enough time for the dialog closing animation before re-rendering
            //await Task.Delay(150);
            IsOpen = false;
            await InvokeAsync(StateHasChanged);
        }

        #endregion

        #region OnInitializedAsync

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            ObjectReference = DotNetObjectReference.Create(this);
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
                CloseReasonTaskCompletionSource = new();

                try
                {
                    await InvokeJsVoidAsync(
                        "MaterialBlazor.MBDialog.dialogShow",
                        DialogId,
                        ObjectReference,
                        EscapeKeyAction,
                        ScrimClickAction).ConfigureAwait(false);
                    IsOpen = true;
                }
                catch
                {
                    _ = CloseReasonTaskCompletionSource?.TrySetCanceled();

                }
                return await CloseReasonTaskCompletionSource.Task;
            }
        }

        #endregion

    }
}
