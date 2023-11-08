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
        /// Render fragment for the dialog header.
        /// </summary>
        [Parameter] public RenderFragment Header { get; set; }



        private TaskCompletionSource<string> CloseReasonTaskCompletionSource { get; set; }
        private TaskCompletionSource OpenedTaskCompletionSource { get; set; } = new();
        internal Task Opened => OpenedTaskCompletionSource.Task;
        private bool AfterDialogInitialization { get; set; } = false;
        private bool IsOpen { get; set; }

        #endregion

        #region BuildRenderTree

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            var attributesToSplat = AttributesToSplat().ToArray();

            var rendSeq = 0;

            builder.OpenElement(rendSeq++, "md-dialog");
            {
                builder.AddAttribute(rendSeq++, "class", @ActiveConditionalClasses + @class);
                builder.AddAttribute(rendSeq++, "style", @style + " position: relative; ");
                builder.AddAttribute(rendSeq++, "id", id);
                if (attributesToSplat.Any())
                {
                    builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
                }

                //builder.OpenComponent(rendSeq++, typeof(MBButton));
                //{
                //    builder.AddComponentParameter(rendSeq++, "Label", ButtonLabel);
                //    builder.AddComponentParameter(rendSeq++, "ButtonStyle", ButtonStyle);
                //    builder.AddComponentParameter(rendSeq++, "IconDescriptor", ButtonIconDescriptor);
                //    builder.AddComponentParameter(rendSeq++, "IconIsTrailing", ButtonIconIsTrailing);
                //    builder.AddAttribute(rendSeq++, "id", MenuButtonId);
                //    builder.AddAttribute(rendSeq++, "style", "color: " + ButtonLabelColor + ";");
                //}
                //builder.CloseComponent();

                //builder.OpenElement(rendSeq++, "md-menu");
                //{
                //    builder.AddAttribute(rendSeq++, "anchor", MenuButtonId);
                //    builder.AddAttribute(rendSeq++, "id", MenuId);

                //    if (MenuItems is not null)
                //    {
                //        foreach (var menuItem in MenuItems)
                //        {
                //            switch (menuItem.MenuItemType)
                //            {
                //                case MBMenuItemType.BeginSubMenu:
                //                    break;

                //                case MBMenuItemType.Divider:
                //                    builder.OpenElement(rendSeq++, "md-divider");
                //                    builder.CloseElement();
                //                    break;

                //                case MBMenuItemType.EndSubMenu:
                //                    break;

                //                case MBMenuItemType.Regular:
                //                default:
                //                    builder.OpenElement(rendSeq++, "md-menu-item");
                //                    {
                //                        if (menuItem.IsDisabled)
                //                        {
                //                            builder.AddAttribute(rendSeq++, "disabled");
                //                        }

                //                        if (menuItem.Headline.Length > 0)
                //                        {
                //                            builder.OpenElement(rendSeq++, "div");
                //                            {
                //                                if (menuItem.HeadlineColor.Length > 0) 
                //                                {
                //                                    builder.AddAttribute(rendSeq++, "style", "color: " + menuItem.HeadlineColor + "; ");
                //                                }
                //                                builder.AddAttribute(rendSeq++, "slot", "headline");
                //                                builder.AddContent(rendSeq++, menuItem.Headline);
                //                            }
                //                            builder.CloseElement();

                //                            if (menuItem.LeadingIcon is not null && !menuItem.SuppressLeadingIcon)
                //                            {
                //                                MBIcon.BuildRenderTreeWorker(
                //                                    builder,
                //                                    ref rendSeq,
                //                                    CascadingDefaults,
                //                                    null,
                //                                    null,
                //                                    null,
                //                                    null,
                //                                    menuItem.LeadingIcon,
                //                                    "start");
                //                            }

                //                            if (menuItem.TrailingIcon is not null)
                //                            {
                //                                MBIcon.BuildRenderTreeWorker(
                //                                    builder,
                //                                    ref rendSeq,
                //                                    CascadingDefaults,
                //                                    null,
                //                                    null,
                //                                    null,
                //                                    null,
                //                                    menuItem.TrailingIcon,
                //                                    "end");
                //                            }
                //                        }
                //                    }
                //                    builder.CloseComponent();
                //                    break;
                //            }
                //        }
                //    }
                //}
                //builder.CloseElement();
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
                await InvokeJsVoidAsync("MaterialBlazor.MBDialog.toggleDialogOpen", DialogId);
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
                await InvokeJsVoidAsync("MaterialBlazor.MBDialog.toggleDialogOpen", DialogId).ConfigureAwait(false);
                CloseReasonTaskCompletionSource = new();
                OpenedTaskCompletionSource = new();
                IsOpen = true;
                return await CloseReasonTaskCompletionSource.Task;
            }
        }

        #endregion

    }
}
