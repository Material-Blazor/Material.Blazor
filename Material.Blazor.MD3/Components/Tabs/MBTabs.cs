using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor
{
    public class MBTabs : ComponentFoundation
    {
        #region members

        /// <summary>
        /// The array of list items.
        /// </summary>
        [Parameter] public MBTabItem[] TabItems { get; set; }

        #endregion

        #region BuildRenderTree

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            var attributesToSplat = AttributesToSplat().ToArray();

            var rendSeq = 0;

            builder.OpenElement(rendSeq++, "md-tabs");
            {
                builder.AddAttribute(rendSeq++, "class", @ActiveConditionalClasses + @class);
                builder.AddAttribute(rendSeq++, "style", @style + " position: relative; ");
                builder.AddAttribute(rendSeq++, "id", id);
                if (attributesToSplat.Any())
                {
                    builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
                }

                if (TabItems is not null)
                {
                    foreach (var tabItem in TabItems)
                    {
                        var componentName = tabItem.IsPrimary switch
                        {
                            true => "md-primary-tab",
                            _ => "md-secondary-tab"
                        };

                        builder.OpenElement(rendSeq++, componentName);
                        {
                            if (tabItem.IsActive) 
                            {
                                builder.AddAttribute(rendSeq++, "active");
                            }

                            if (tabItem.IconIsInline)
                            {
                                builder.AddAttribute(rendSeq++, "inline-icon");
                            }

                            if (!string.IsNullOrEmpty(tabItem.TabAriaControls))
                            {
                                builder.AddAttribute(rendSeq++, "aria-controls", tabItem.TabAriaControls);
                            }

                            if (!string.IsNullOrEmpty(tabItem.TabId))
                            {
                                builder.AddAttribute(rendSeq++, "id", tabItem.TabId);
                            }

                            if (tabItem.Headline.Length > 0)
                            {
                                builder.AddContent(rendSeq++, tabItem.Headline);
                            }

                            if (tabItem.Icon is not null)
                            {
                                MBIcon.BuildRenderTreeWorker(
                                    builder,
                                    ref rendSeq,
                                    CascadingDefaults,
                                    null,
                                    null,
                                    null,
                                    null,
                                    tabItem.Icon,
                                    "icon");
                            }
                        }
                        builder.CloseElement();
                        //switch (tabItem.ListItemType)
                        //{
                        //    case MBListItemType.Divider:
                        //        builder.OpenElement(rendSeq++, "md-divider");
                        //        builder.CloseElement();
                        //        break;

                        //    case MBListItemType.Regular:
                        //    default:
                        //        builder.OpenElement(rendSeq++, "md-list-item");
                        //        {
                        //            if (tabItem.IsDisabled)
                        //            {
                        //                builder.AddAttribute(rendSeq++, "disabled");
                        //            }

                        //            if (!string.IsNullOrWhiteSpace(tabItem.Link))
                        //            {
                        //                builder.AddAttribute(rendSeq++, "interactive");

                        //                builder.AddAttribute(rendSeq++, "href", tabItem.Link);

                        //                if (!string.IsNullOrWhiteSpace(tabItem.LinkTarget))
                        //                {
                        //                    builder.AddAttribute(rendSeq++, "target", tabItem.LinkTarget);
                        //                }
                        //            }

                        //            if (!string.IsNullOrWhiteSpace(tabItem.Headline))
                        //            {
                        //                builder.OpenElement(rendSeq++, "div");
                        //                {
                        //                    if (!string.IsNullOrWhiteSpace(tabItem.HeadlineColor))
                        //                    {
                        //                        builder.AddAttribute(rendSeq++, "style", "color: " + tabItem.HeadlineColor + "; ");
                        //                    }
                        //                    builder.AddAttribute(rendSeq++, "slot", "headline");
                        //                    builder.AddContent(rendSeq++, tabItem.Headline);
                        //                }
                        //                builder.CloseElement();
                        //            }

                        //            if (!string.IsNullOrWhiteSpace(tabItem.HeadlineSupport))
                        //            {
                        //                builder.OpenElement(rendSeq++, "div");
                        //                {
                        //                    if (!string.IsNullOrWhiteSpace(tabItem.HeadlineSupportColor))
                        //                    {
                        //                        builder.AddAttribute(rendSeq++, "style", "color: " + tabItem.HeadlineSupportColor + "; ");
                        //                    }
                        //                    builder.AddAttribute(rendSeq++, "slot", "supporting-text");
                        //                    builder.AddContent(rendSeq++, tabItem.HeadlineSupport);
                        //                }
                        //                builder.CloseElement();
                        //            }

                        //            // Two users of the "start" slot; image wins
                        //            if (!string.IsNullOrWhiteSpace(tabItem.ImageSource))
                        //            {
                        //                builder.OpenElement(rendSeq++, "img");
                        //                {
                        //                    builder.AddAttribute(rendSeq++, "slot", "start");
                        //                    builder.AddAttribute(rendSeq++, "src", tabItem.ImageSource);
                        //                    if (!string.IsNullOrWhiteSpace(tabItem.ImageStyle))
                        //                    {
                        //                        builder.AddAttribute(rendSeq++, "style", tabItem.ImageStyle);
                        //                    }

                        //                }
                        //                builder.CloseElement();
                        //            }
                        //            else
                        //            {
                        //                if (tabItem.LeadingIcon is not null)
                        //                {
                        //                    MBIcon.BuildRenderTreeWorker(
                        //                        builder,
                        //                        ref rendSeq,
                        //                        CascadingDefaults,
                        //                        null,
                        //                        null,
                        //                        null,
                        //                        null,
                        //                        tabItem.LeadingIcon,
                        //                        "start");
                        //                }
                        //            }

                        //        }
                        //        builder.CloseElement();
                        //        break;
                        //}
                    }
                }
            }
            builder.CloseElement();
        }

        #endregion

    }
}
