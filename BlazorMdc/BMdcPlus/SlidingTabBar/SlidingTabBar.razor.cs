using BMdcFoundation;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace BMdcPlus
{
    /// <summary>
    /// An <see cref="MdcTabBar{TItem}"/> with a <see cref="PMdcSlidingContent{TItem}"/> immediately
    /// beneath showing tabbed content.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    public partial class SlidingTabBar<TItem> : ComponentFoundation
    {
        private int _tabIndex;
        /// <summary>
        /// The tab index.
        /// </summary>
        [Parameter]
        public int TabIndex
        {
            get => _tabIndex;

            set
            {
                if (value != _tabIndex)
                {
                    _tabIndex = value;
                    TabIndexChanged.InvokeAsync(value);
                }
            }
        }

        /// <summary>
        /// The change event callback for <see cref="TabIndex"/>.
        /// </summary>
        [Parameter] public EventCallback<int> TabIndexChanged { get; set; }


        /// <summary>
        /// Stack icons vertically if True, otherwise icons are leading.
        /// </summary>
        [Parameter] public bool StackIcons { get; set; }


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
    }
}
