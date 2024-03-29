﻿using Material.Blazor.Internal;

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
        /// Render fragment for the dialog custom header.
        /// </summary>
        [Parameter] public RenderFragment CustomHeader { get; set; }

        /// <summary>
        /// The action performed by the dialog when the escape key is pressed or a click occurs in the
        /// scrim. Defaults to "close('cancel')". Setting this to false will disable the gesture 
        /// cancellation action.
        /// </summary>
        [Parameter] public bool GestureCancellation { get; set; } = true;

        /// <summary>
        /// The dialog title.
        /// </summary>
        [Parameter] public string Headline { get; set; }

        /// <summary>
        /// The icon attributes.
        /// </summary>
        [Parameter] public MBIconDescriptor IconDescriptor { get; set; }



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

            builder.OpenElement(0, "md-dialog");
            {
                builder.AddAttribute(1, "class", @class);
                builder.AddAttribute(2, "style", style);
                builder.AddAttribute(3, "id", DialogId);
                if (attributesToSplat.Any())
                {
                    builder.AddMultipleAttributes(4, attributesToSplat);
                }

                if (IconDescriptor is not null)
                {
                    var rendSeq = 10;
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

                if (!string.IsNullOrWhiteSpace(Headline) || CustomHeader is not null)
                {
                    builder.OpenElement(200, "div");
                    {
                        builder.AddAttribute(201, "slot", "headline");
                        if (CustomHeader is not null)
                        {
                            builder.AddContent(202, CustomHeader);

                            if (!string.IsNullOrWhiteSpace(Headline))
                            {
                                throw new Exception("Can not specify both a headline and a custom header");
                            }
                        }
                        else
                        {
                            builder.AddContent(203, Headline);
                        }
                    }
                    builder.CloseElement();
                }

                if (Body is not null)
                {
                    builder.OpenElement(300, "form");
                    {
                        builder.AddAttribute(301, "id", FormId);
                        builder.AddAttribute(302, "slot", "content");
                        builder.AddAttribute(303, "method", "dialog");

                        builder.AddContent(304, Body);
                    }
                    builder.CloseElement();
                }

                if (ButtonItems is not null)
                {
                    builder.OpenElement(305, "div");
                    {
                        builder.AddAttribute(306, "slot", "actions");

                        foreach (var button in ButtonItems)
                        {
                            var rendSeq = 400;
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

        #region HideAsync

        /// <summary>
        /// Hides the dialog by having Material Web close the dialog.
        /// </summary>
        public async Task HideAsync(string dialogValue)
        {
            if (!IsOpen)
            {
                throw new InvalidOperationException("Cannot hide MBDialog that is not open");
            }
            else
            {
                await InvokeJsVoidAsync(
                    "MaterialBlazor.MBDialog.dialogClose",
                    DialogId,
                    dialogValue).ConfigureAwait(false);
            }
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
                        GestureCancellation).ConfigureAwait(false);
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
