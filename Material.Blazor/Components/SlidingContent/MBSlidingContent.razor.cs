using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Material.Blazor;

/// <summary>
/// A Plus component that take a set of renderfragments in a list and transitions from one to another
/// with slight sideways motion and fade, or "sliding". Only renders the currently displayed item.
/// </summary>
/// <typeparam name="TItem">The content type.</typeparam>
public partial class MBSlidingContent<TItem> : ComponentFoundation
{
    /// <summary>
    /// The index of the currently displayed item.
    /// </summary>
    [Parameter] public int ItemIndex { get; set; }
    private int _cachedItemIndex;


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
    private ElementReference ElementReference { get; set; }
    private bool IsRTL { get; set; } = false;
    private bool HasRendered { get; set; } = false;


    internal const string Hidden = "mb-visibility-hidden";
    internal const string Visible = "mb-visibility-visible";
    private const string InFromLeft = "mb-slide-in-from-left";
    private const string InFromRight = "mb-slide-in-from-right";
    private const string OutToLeft = "mb-slide-out-to-left";
    private const string OutToRight = "mb-slide-out-to-right";

    internal static string InFromPrevious(bool isRTL) => isRTL ? InFromRight : InFromLeft;
    internal static string InFromNext(bool isRTL) => isRTL ? InFromLeft : InFromRight;
    internal static string OutToPrevious(bool isRTL) => isRTL ? OutToRight : OutToLeft;
    internal static string OutToNext(bool isRTL) => isRTL ? OutToLeft : OutToRight;

    private enum SlideDirection { Backwards, Forwards }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();

        if (Items != null)
        {
            CurrentItem = Items.ElementAtOrDefault(_cachedItemIndex);
        }

        if (_cachedItemIndex != ItemIndex)
        {
            var direction = (ItemIndex > _cachedItemIndex) ? SlideDirection.Forwards : SlideDirection.Backwards;
            EnqueueJSInteropAction(() => SlideToItem(ItemIndex, direction));
        }

        IsRTL = await ElementIsRTL(ElementReference);
    }


    private async Task SlideToItem(int index, SlideDirection direction)
    {
        if (index != _cachedItemIndex)
        {
            if (HasRendered)
            {
                string nextClass;

                if (direction == SlideDirection.Backwards)
                {
                    nextClass = InFromPrevious(IsRTL);
                    ContentClass = OutToNext(IsRTL);
                }
                else
                {
                    nextClass = InFromNext(IsRTL);
                    ContentClass = OutToPrevious(IsRTL);
                }

                await InvokeAsync(StateHasChanged);
                await Task.Delay(100);

                HideContent = true;

                ContentClass = nextClass;
                CurrentItem = Items.ElementAt(index);

                _cachedItemIndex = index;
                ItemIndex = index;
                await ItemIndexChanged.InvokeAsync(index);
                
                HideContent = false;

                await InvokeAsync(StateHasChanged);
            }
            else
            {
                await ItemIndexChanged.InvokeAsync(index);
                _cachedItemIndex = index;
                CurrentItem = Items.ElementAt(index);
                ItemIndex = index;
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
        var nextIndex = _cachedItemIndex + 1;

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
        var previousIndex = _cachedItemIndex - 1;

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


    /// <summary>
    /// A back door to set the item index for use by the carousel. Required because the internal carousel sliding panel
    /// returns ShouldRender() => false;
    /// </summary>
    /// <param name="index"></param>
    internal async Task SetItemIndexAsync(int index)
    {
        var slideDirection = index < ItemIndex ? SlideDirection.Backwards : SlideDirection.Forwards;
        await SlideToItem(index, slideDirection).ConfigureAwait(false);
    }
}
