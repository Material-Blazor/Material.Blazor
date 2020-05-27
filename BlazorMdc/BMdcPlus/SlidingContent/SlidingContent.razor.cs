using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMdcPlus
{
    /// <summary>
    /// A Plus component that take a set of renderfragments in a list and transitions from one to another
    /// with slight sideways motion and fade, or "sliding". Only renders the currently displayed item.
    /// </summary>
    /// <typeparam name="TItem">The content type.</typeparam>
    public partial class SlidingContent<TItem>
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
                    ItemIndexChanged.InvokeAsync(value);

                    SlideDirection direction = (value > _itemIndex) ? SlideDirection.Forwards : SlideDirection.Backwards;

                    if (HasRendered)
                    {
                        InvokeAsync(() => SlideToItem(value, direction));
                    }

                    _itemIndex = value;
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


        internal const string Hidden = "bmdc-visibility-hidden";
        internal const string Visible = "bmdc-visibility-visible";
        internal const string InFromLeft = "bmdc-slide-in-from-left";
        internal const string InFromRight = "bmdc-slide-in-from-right";
        internal const string OutToLeft = "bmdc-slide-out-to-left";
        internal const string OutToRight = "bmdc-slide-out-to-right";

        private enum SlideDirection { Backwards, Forwards }


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            CurrentItem = Items.ElementAt(_itemIndex);
        }


        private async Task SlideToItem(int index, SlideDirection direction)
        {
            if (index != _itemIndex)
            {
                string nextClass = "";

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

                await Task.Delay(100);

                HideContent = true;
                ContentClass = nextClass;
                CurrentItem = Items.ElementAt(index);
                HideContent = false;

                StateHasChanged();
            }
        }


        /// <inheritdoc/>
        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                HasRendered = true;
            }
        }
    }
}
