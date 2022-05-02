using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Material.Blazor.Internal
{
    /// <summary>
    /// Panel for the carousel, returning ShouldRender() => false;
    /// </summary>
    public partial class InternalCarouselPanel<TItem> : InputComponent<int>
    {
        /// <summary>
        /// The tab details plus items to be displayed under the tab bar depending upon tab index.
        /// </summary>
        [Parameter] public IEnumerable<TItem> Items { get; set; }


        /// <summary>
        /// Content render fragments under the tab bar.
        /// </summary>
        [Parameter] public RenderFragment<TItem> Content { get; set; }


        /// <summary>
        /// The index of the currently displayed item.
        /// </summary>
        [Parameter]
        public int ItemIndex { get; set; }


        ///// <summary>
        ///// The change event callback for <see cref="ItemIndex"/>.
        ///// </summary>
        //[Parameter] public EventCallback<int> ItemIndexChanged { get; set; }


        /// <summary>
        /// The embedded sliding content.
        /// </summary>
        public MBSlidingContent<TItem> SlidingContent { get; set; }


        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            ForceShouldRenderToTrue = false;
        }
    }
}

