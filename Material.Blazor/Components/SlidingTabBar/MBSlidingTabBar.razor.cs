using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace Material.Blazor
{
    /// <summary>
    /// An <see cref="MBTabBar{TItem}"/> with a <see cref="MBSlidingContent{TItem}"/> immediately
    /// beneath showing tabbed content.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    public partial class MBSlidingTabBar<TItem> : InputComponent<int>
    {
        /// <summary>
        /// Stack icons vertically if True, otherwise icons are leading.
        /// </summary>
        [Parameter] public bool StackIcons { get; set; }


        /// <summary>
        /// A function delegate to return the parameters for <c>@key</c> attributes. If unused
        /// "fake" keys set to GUIDs will be used.
        /// </summary>
        [Parameter] public Func<TItem, object> GetKeysFunc { get; set; }


        /// <summary>
        /// The tab details plus items to be displayed under the tab bar depending upon tab index.
        /// </summary>
        [Parameter] public IEnumerable<TItem> Items { get; set; }


        /// <summary>
        /// Label render fragments.
        /// </summary>
        [Parameter] public RenderFragment<TItem> Label { get; set; }


        /// <summary>
        /// Icon render fragments.
        /// </summary>
        [Parameter] public RenderFragment<TItem> Icon { get; set; }


        /// <summary>
        /// Content render fragments under the tab bar.
        /// </summary>
        [Parameter] public RenderFragment<TItem> Content { get; set; }


        /// <summary>
        /// The tab bar's density.
        /// </summary>
        [Parameter] public MBDensity? Density { get; set; }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ForceShouldRenderToTrue = true;
        }
    }
}
