using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// An carousel, implementing animation using an <see cref="MBSlidingContent{TItem}"/>.
/// </summary>
/// <typeparam name="TItem"></typeparam>
public partial class MBCarousel<TItem> : InputComponent<int>
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
    /// The interval in milliseconds to roll over from one panel of content to the next. Clamped between 1,000 and 60,000. Defaults to 3,000.
    /// </summary>
    [Parameter] public int RolloverInterval { get; set; } = 3000;


    private ElementReference ElementReference { get; set; }
    private bool Play { get; set; }
    private string PlayIcon => Play ? "stop" : "play_arrow";
    private CancellationTokenSource TokenSource { get; set; } = new();
    internal InternalCarouselPanel<TItem> ICP { get; set; }
    private int ItemIndex { get; set; } = 0;
    private bool IsRTL { get; set; } = false;
    private int RadioItemIndex { get; set; }
    private List<MBSelectElement<int>> RadioElements { get; set; }
    private string PreviousIcon => IsRTL ? "navigate_next" : "navigate_before";
    private string NextIcon => IsRTL ? "navigate_before" : "navigate_next";



    private async Task AfterSetRadioItemIndex()
    {
        PlayStop(false);
        ItemIndex = RadioItemIndex;
        await ICP.SlidingContent.SetItemIndexAsync(ItemIndex).ConfigureAwait(false);
        await InvokeAsync(StateHasChanged).ConfigureAwait(false);
    }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        AllowAllRenders();
    }


    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();

        RolloverInterval = Math.Clamp(RolloverInterval, 1000, 60000);

        RadioElements = new();

        for (var i = 0; i < Items.Count(); i++)
        {
            RadioElements.Add(new() { SelectedValue = i, Label = $"Image {i}" });
        }

        IsRTL = await IsElementRTL(ElementReference);
    }


    protected override Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            PlayStop(true);
        }

        return base.OnAfterRenderAsync(firstRender);
    }


    private void PlayStop(bool? play = null)
    {
        Play = play?? !Play;

        if (Play)
        {
            RunPanels();
        }
        else
        {
            TokenSource.Cancel();
            TokenSource.Dispose();
            TokenSource = new();
        }

        _ = InvokeAsync(StateHasChanged);
    }


    private async Task NavigatePrevious()
    {
        PlayStop(false);
        await ICP.SlidingContent.SlidePrevious(true).ConfigureAwait(false);
        ItemIndex = ICP.SlidingContent.ItemIndex;
        RadioItemIndex = ICP.SlidingContent.ItemIndex;
        await InvokeAsync(StateHasChanged).ConfigureAwait(false);
    }


    private async Task NavigateNext()
    {
        PlayStop(false);
        await ICP.SlidingContent.SlideNext(true).ConfigureAwait(false);
        ItemIndex = ICP.SlidingContent.ItemIndex;
        RadioItemIndex = ICP.SlidingContent.ItemIndex;
        await InvokeAsync(StateHasChanged).ConfigureAwait(false);
    }


    private void RunPanels()
    {
        var ct = TokenSource.Token;

        _ = Task.Run(async () =>
        {
            var continuePanelTransition = true;

            while (continuePanelTransition)
            {
                await Task.Delay(RolloverInterval).ConfigureAwait(false);

                if (ct.IsCancellationRequested)
                {
                    continuePanelTransition = false;
                }
                else
                {
                    await ICP.SlidingContent.SlideNext(true).ConfigureAwait(false);
                    ItemIndex = ICP.SlidingContent.ItemIndex;
                    RadioItemIndex = ICP.SlidingContent.ItemIndex;
                    await InvokeAsync(StateHasChanged).ConfigureAwait(false);
                }
            }
        }, TokenSource.Token);
    }
}
