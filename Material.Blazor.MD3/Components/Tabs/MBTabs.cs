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
        /// Use JS method to control associated tab panels
        /// </summary>
        [Parameter] public bool IsControllingPanels { get; set; } = false;

        /// <summary>
        /// The array of tab items.
        /// </summary>
        [Parameter] public MBTabItem[] TabItems { get; set; }



        private string TabsId { get; set; }
        #endregion

        #region BuildRenderTree

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            TabsId = "tabs-id-" + Guid.NewGuid().ToString().ToLower();

            var attributesToSplat = AttributesToSplat().ToArray();

            builder.OpenElement(0, "md-tabs");
            {
                builder.AddAttribute(1, "class", @ActiveConditionalClasses + @class);
                builder.AddAttribute(2, "style", @style + " position: relative; ");
                builder.AddAttribute(3, "id", TabsId);
                if (attributesToSplat.Any())
                {
                    builder.AddMultipleAttributes(4, attributesToSplat);
                }

                var baseRendSeq = 10;
                if (TabItems is not null)
                {
                    foreach (var tabItem in TabItems)
                    {
                        var componentName = tabItem.IsPrimary switch
                        {
                            true => "md-primary-tab",
                            _ => "md-secondary-tab"
                        };

                        builder.OpenElement(baseRendSeq, componentName);
                        {
                            if (!string.IsNullOrEmpty(tabItem.TabId))
                            {
                                builder.AddAttribute(baseRendSeq + 1, "id", tabItem.TabId);
                            }

                            if (!string.IsNullOrEmpty(tabItem.TabAriaControls))
                            {
                                builder.AddAttribute(baseRendSeq + 2, "aria-controls", tabItem.TabAriaControls);
                            }

                            if (tabItem.IsActive)
                            {
                                builder.AddAttribute(baseRendSeq + 3, "active");
                            }

                            if (tabItem.IconIsInline)
                            {
                                builder.AddAttribute(baseRendSeq + 4, "inline-icon");
                            }

                            if (tabItem.Headline.Length > 0)
                            {
                                builder.AddContent(baseRendSeq + 5, tabItem.Headline);
                            }

                            baseRendSeq += 6;
                            if (tabItem.Icon is not null)
                            {
                                MBIcon.BuildRenderTreeWorker(
                                    builder,
                                    ref baseRendSeq,
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
                    }

                    baseRendSeq += 100;
                }
            }
            builder.CloseElement();
        }

        #endregion

        #region OnAfterRenderAsync

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
            if (firstRender && IsControllingPanels)
            {
                await InvokeJsVoidAsync("MaterialBlazor.MBTabs.setTabsChangeEvent", TabsId, TabItems[0].TabAriaControls).ConfigureAwait(false);
            }
        }

        #endregion

    }
}
