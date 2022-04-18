using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Material.Blazor
{
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


        private int _rolloverInterval = 3000;
        /// <summary>
        /// The interval in milliseconds to roll over from one panel of content to the next. Clamped between 1,000 and 60,000. Defaults toi 3,000.
        /// </summary>
        [Parameter] public int RolloverInterval { get => _rolloverInterval; set => _rolloverInterval = Math.Clamp(value, 1000, 60000); }


        private bool Play { get; set; }
        private string PlayIcon => Play ? "stop" : "play_arrow";
        private CancellationTokenSource tokenSource { get; set; } = new();
        private InternalCarouselPanel<TItem> ICP { get; set; }
        private int ItemIndex { get; set; } = 0;
        private List<MBSelectElement<int>> RadioElements { get; set; }

        private int RadioItemIndex
        {
            get => ItemIndex;
            set
            {
                ItemIndex = value;
                ICP.SlidingContent.SetItemIndex(ItemIndex);
                PlayStop(false);
            }
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            ForceShouldRenderToTrue = true;
        }


        protected override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();

            RadioElements = new();

            for (var i = 0; i < Items.Count(); i++)
            {
                RadioElements.Add(new() { SelectedValue = i, Label = "" });
            }
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
                tokenSource.Cancel();
                tokenSource.Dispose();
                tokenSource = new();
            }

            _ = InvokeAsync(StateHasChanged);
        }


        private async Task NavigatePrevious()
        {
            PlayStop(false);
            await ICP.SlidingContent.SlidePrevious(true).ConfigureAwait(false);
            ItemIndex = ICP.SlidingContent.ItemIndex;
        }


        private async Task NavigateNext()
        {
            PlayStop(false);
            await ICP.SlidingContent.SlideNext(true).ConfigureAwait(false);
            ItemIndex = ICP.SlidingContent.ItemIndex;
        }


        private void RunPanels()
        {
            var ct = tokenSource.Token;

            _ = Task.Run(async () =>
            {
                bool continuePanelTransition = true;

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
                        await InvokeAsync(StateHasChanged);
                    }
                }
            }, tokenSource.Token);
        }
    }
}
