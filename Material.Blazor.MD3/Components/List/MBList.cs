using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor
{
    public class MBList : ComponentFoundation
    {
        #region members

        /// <summary>
        /// The array of list items.
        /// </summary>
        [Parameter] public MBListItem[] ListItems { get; set; }

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

                rendSeq = 100;

                if (ListItems is not null)
                {
                    foreach (var listItem in ListItems)
                    {
                        rendSeq += 100;
                        switch (listItem.ListItemType)
                        {
                            case MBListItemType.Divider:
                                builder.OpenElement(rendSeq++, "md-divider");
                                builder.CloseElement();
                                break;

                            case MBListItemType.Regular:
                            default:
                                builder.OpenElement(rendSeq + 1, "md-list-item");
                                {
                                    if (listItem.IsDisabled)
                                    {
                                        builder.AddAttribute(rendSeq + 2, "disabled");
                                    }

                                    if (!string.IsNullOrWhiteSpace(listItem.Link))
                                    {
                                        builder.AddAttribute(rendSeq + 3, "interactive");

                                        builder.AddAttribute(rendSeq + 4, "href", listItem.Link);

                                        if (!string.IsNullOrWhiteSpace(listItem.LinkTarget))
                                        {
                                            builder.AddAttribute(rendSeq + 5, "target", listItem.LinkTarget);
                                        }
                                    }

                                    if (!string.IsNullOrWhiteSpace(listItem.Headline))
                                    {
                                        builder.OpenElement(rendSeq + 6, "div");
                                        {
                                            if (!string.IsNullOrWhiteSpace(listItem.HeadlineColor))
                                            {
                                                builder.AddAttribute(rendSeq + 7, "style", "color: " + listItem.HeadlineColor + "; ");
                                            }
                                            builder.AddAttribute(rendSeq + 8, "slot", "headline");
                                            builder.AddContent(rendSeq + 9, listItem.Headline);
                                        }
                                        builder.CloseElement();
                                    }

                                    if (!string.IsNullOrWhiteSpace(listItem.HeadlineSupport))
                                    {
                                        builder.OpenElement(rendSeq + 10, "div");
                                        {
                                            if (!string.IsNullOrWhiteSpace(listItem.HeadlineSupportColor))
                                            {
                                                builder.AddAttribute(rendSeq + 11, "style", "color: " + listItem.HeadlineSupportColor + "; ");
                                            }
                                            builder.AddAttribute(rendSeq + 12, "slot", "supporting-text");
                                            builder.AddContent(rendSeq + 13, listItem.HeadlineSupport);
                                        }
                                        builder.CloseElement();
                                    }

                                    // Two users of the "start" slot; image wins
                                    if (!string.IsNullOrWhiteSpace(listItem.ImageSource))
                                    {
                                        builder.OpenElement(rendSeq + 14, "img");
                                        {
                                            builder.AddAttribute(rendSeq + 15, "slot", "start");
                                            builder.AddAttribute(rendSeq + 16, "src", listItem.ImageSource);
                                            if (!string.IsNullOrWhiteSpace(listItem.ImageStyle))
                                            {
                                                builder.AddAttribute(rendSeq + 17, "style", listItem.ImageStyle);
                                            }

                                        }
                                        builder.CloseElement();
                                    }
                                    else
                                    {
                                        if (listItem.LeadingIcon is not null)
                                        {
                                            rendSeq += 20;
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

                                    rendSeq += 20;
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
            }
            builder.CloseElement();
        }

        #endregion

    }
}
