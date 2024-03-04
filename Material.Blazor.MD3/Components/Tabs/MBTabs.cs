﻿using Material.Blazor.Internal;

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

            var rendSeq = 0;

            builder.OpenElement(rendSeq++, "md-tabs");
            {
                builder.AddAttribute(rendSeq++, "class", @ActiveConditionalClasses + @class);
                builder.AddAttribute(rendSeq++, "style", @style + " position: relative; ");
                builder.AddAttribute(rendSeq++, "id", TabsId);
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
                            if (!string.IsNullOrEmpty(tabItem.TabId))
                            {
                                builder.AddAttribute(rendSeq++, "id", tabItem.TabId);
                            }

                            if (!string.IsNullOrEmpty(tabItem.TabAriaControls))
                            {
                                builder.AddAttribute(rendSeq++, "aria-controls", tabItem.TabAriaControls);
                            }

                            if (tabItem.IsActive)
                            {
                                builder.AddAttribute(rendSeq++, "active");
                            }

                            if (tabItem.IconIsInline)
                            {
                                builder.AddAttribute(rendSeq++, "inline-icon");
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
                    }
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