using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;

namespace Material.Blazor
{
    /// <summary>
    /// A Plus component that take a set of renderfragments in a list and transitions from one to another
    /// with slight sideways motion and fade, or "sliding". Only renders the currently displayed item.
    /// </summary>
    /// <typeparam name="TItem">The content type.</typeparam>
    public partial class MBSlidingContent<TItem> : ComponentFoundation
    {
        private int _itemIndex;
        /// <summary>
        /// The index of the currently displayed item.
        /// </summary>
        [Parameter]
        public int ItemIndex
        {
            get => _itemIndex;

            set
            {
                if (value != _itemIndex)
                {
                    var direction = (value > _itemIndex) ? SlideDirection.Forwards : SlideDirection.Backwards;

                    _ = InvokeAsync(() => SlideToItem(value, direction));
                }
            }
        }


        /// <summary>
        /// The change event callback for <see cref="ItemIndex"/>.
        /// </summary>
        [Parameter] public EventCallback<int> ItemIndexChanged { get; set; }


        /// <summary>
        /// The items to be displayed.
        /// </summary>
        [Parameter] public IEnumerable<TItem> Items { get; set; }


        /// <summary>
        /// Render fragment for each displayable item.
        /// </summary>
        [Parameter] public RenderFragment<TItem> Content { get; set; }


        private string ContentClass { get; set; } = "";
        private bool HideContent { get; set; } = false;
        private string VisibilityClass => HideContent ? Hidden : Visible;
        private TItem CurrentItem { get; set; }
        private bool HasRendered { get; set; } = false;


        internal const string Hidden = "mb-visibility-hidden";
        internal const string Visible = "mb-visibility-visible";
        internal const string InFromLeft = "mb-slide-in-from-left";
        internal const string InFromRight = "mb-slide-in-from-right";
        internal const string OutToLeft = "mb-slide-out-to-left";
        internal const string OutToRight = "mb-slide-out-to-right";

        private enum SlideDirection { Backwards, Forwards }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();

            if (Items != null)
            {
                CurrentItem = Items.ElementAtOrDefault(_itemIndex);
            }
        }


        private async Task SlideToItem(int index, SlideDirection direction)
        {
            if (index != _itemIndex)
            {
                if (HasRendered)
                {
                    string nextClass;

                    if (direction == SlideDirection.Backwards)
                    {
                        nextClass = InFromLeft;
                        ContentClass = OutToRight;
                    }
                    else
                    {
                        nextClass = InFromRight;
                        ContentClass = OutToLeft;
                    }

                    await InvokeAsync(StateHasChanged);
                    await Task.Delay(100);

                    HideContent = true;

                    ContentClass = nextClass;
                    CurrentItem = Items.ElementAt(index);

                    _itemIndex = index;
                    await ItemIndexChanged.InvokeAsync(index);
                    
                    HideContent = false;

                    await InvokeAsync(StateHasChanged);
                }
                else
                {
                    await ItemIndexChanged.InvokeAsync(index);
                    _itemIndex = index;
                }
            }
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);

            if (firstRender)
            {
                HasRendered = true;
            }
        }


        /// <summary>
        /// Moves to the next slide, always scrolling forwards. 
        /// </summary>
        /// <param name="rollover">Rolls from last to first if true, scrolling forwards.</param>
        public async Task SlideNext(bool rollover)
        {
            int nextIndex = _itemIndex + 1;

            if (nextIndex == Items.Count())
            {
                if (!rollover)
                {
                    return;
                }

                nextIndex = 0;
            }

            await SlideToItem(nextIndex, SlideDirection.Forwards).ConfigureAwait(false);
        }


        /// <summary>
        /// Moves to the previous slide, always scrolling backwards. 
        /// </summary>
        /// <param name="rollover">Rolls from first to last if true, scrolling backwards.</param>
        public async Task SlidePrevious(bool rollover)
        {
            int previousIndex = _itemIndex - 1;

            if (previousIndex == -1)
            {
                if (!rollover)
                {
                    return;
                }

                previousIndex = Items.Count() - 1;
            }

            await SlideToItem(previousIndex, SlideDirection.Backwards).ConfigureAwait(false);
        }
    }
}
