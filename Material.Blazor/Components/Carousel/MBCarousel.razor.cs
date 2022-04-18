﻿using Material.Blazor.Internal;

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
        /// A function delegate to return the parameters for <c>@key</c> attributes. If unused
        /// "fake" keys set to GUIDs will be used.
        /// </summary>
        [Parameter] public Func<TItem, object> GetKeysFunc { get; set; }


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
        private MBSlidingContent<TItem> SlidingContent { get; set; }
        private int ItemIndex { get; set; } = 0;
        private List<MBSelectElement<int>> RadioElements { get; set; }

        private int RadioItemIndex
        {
            get => ItemIndex;
            set
            {
                ItemIndex = value;
                PlayStop(false);
            }
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            ForceShouldRenderToTrue = true;

            PlayStop(true);
        }


        protected override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();

            RadioElements = new();

            for (int i = 0; i < Items.Count(); i++)
            {
                RadioElements.Add(new() { SelectedValue = i, Label = "" });
            }
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

            InvokeAsync(StateHasChanged);
        }


        private void NavigatePrevious()
        {
            PlayStop(false);
            SlidingContent.SlidePrevious(true);
        }


        private void NavigateNext()
        {
            PlayStop(false);
            SlidingContent.SlideNext(true);
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
                        SlidingContent.SlideNext(true);
                        _ = InvokeAsync(StateHasChanged);
                    }
                }
            }, tokenSource.Token);
        }
    }
}
