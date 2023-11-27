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

            builder.OpenElement(rendSeq++, "md-list");
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
                    builder.OpenElement(rendSeq++, "md-list-item");
                    {
                        foreach (var listItem in TabItems)
                        {
                            switch (listItem.ListItemType)
                            {
                                case MBListItemType.Divider:
                                    builder.OpenElement(rendSeq++, "md-divider");
                                    builder.CloseElement();
                                    break;

                                case MBListItemType.Regular:
                                default:
                                    builder.OpenElement(rendSeq++, "md-list-item");
                                    {
                                        if (listItem.IsDisabled)
                                        {
                                            builder.AddAttribute(rendSeq++, "disabled");
                                        }

                                        if (!string.IsNullOrWhiteSpace(listItem.Link))
                                        {
                                            builder.AddAttribute(rendSeq++, "interactive");

                                            builder.AddAttribute(rendSeq++, "href", listItem.Link);

                                            if (!string.IsNullOrWhiteSpace(listItem.LinkTarget))
                                            {
                                                builder.AddAttribute(rendSeq++, "target", listItem.LinkTarget);
                                            }
                                        }

                                        if (!string.IsNullOrWhiteSpace(listItem.Headline))
                                        {
                                            builder.OpenElement(rendSeq++, "div");
                                            {
                                                if (!string.IsNullOrWhiteSpace(listItem.HeadlineColor))
                                                {
                                                    builder.AddAttribute(rendSeq++, "style", "color: " + listItem.HeadlineColor + "; ");
                                                }
                                                builder.AddAttribute(rendSeq++, "slot", "headline");
                                                builder.AddContent(rendSeq++, listItem.Headline);
                                            }
                                            builder.CloseElement();
                                        }

                                        if (!string.IsNullOrWhiteSpace(listItem.HeadlineSupport))
                                        {
                                            builder.OpenElement(rendSeq++, "div");
                                            {
                                                if (!string.IsNullOrWhiteSpace(listItem.HeadlineSupportColor))
                                                {
                                                    builder.AddAttribute(rendSeq++, "style", "color: " + listItem.HeadlineSupportColor + "; ");
                                                }
                                                builder.AddAttribute(rendSeq++, "slot", "supporting-text");
                                                builder.AddContent(rendSeq++, listItem.HeadlineSupport);
                                            }
                                            builder.CloseElement();
                                        }

                                        // Two users of the "start" slot; image wins
                                        if (!string.IsNullOrWhiteSpace(listItem.ImageSource))
                                        {
                                            builder.OpenElement(rendSeq++, "img");
                                            {
                                                builder.AddAttribute(rendSeq++, "slot", "start");
                                                builder.AddAttribute(rendSeq++, "src", listItem.ImageSource);
                                                if (!string.IsNullOrWhiteSpace(listItem.ImageStyle))
                                                {
                                                    builder.AddAttribute(rendSeq++, "style", listItem.ImageStyle);
                                                }

                                            }
                                            builder.CloseElement();
                                        }
                                        else
                                        {
                                            if (listItem.LeadingIcon is not null)
                                            {
                                                MBIcon.BuildRenderTreeWorker(
                                                    builder,
                                                    ref rendSeq,
                                                    CascadingDefaults,
                                                    null,
                                                    null,
                                                    null,
                                                    null,
                                                    listItem.LeadingIcon,
                                                    "start");
                                            }
                                        }

                                        if (listItem.TrailingIcon is not null)
                                        {
                                            MBIcon.BuildRenderTreeWorker(
                                                builder,
                                                ref rendSeq,
                                                CascadingDefaults,
                                                null,
                                                null,
                                                null,
                                                null,
                                                listItem.TrailingIcon,
                                                "end");
                                        }

                                    }
                                    builder.CloseElement();
                                    break;
                            }
                        }
                    }
                    builder.CloseElement();
                }
            }
            builder.CloseElement();
        }

        #endregion

    }
}
