using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Material.Blazor.Internal
{
    /// <summary>
    /// An anchor component that displays tooltips that you add, and using 
    /// <see cref="IMBTooltipService"/>.
    /// Place this component at the top of either App.razor or MainLayout.razor.
    /// </summary>
    public partial class InternalTooltipAnchor : ComponentFoundation
    {
        private Dictionary<Guid, TooltipInstance> Tooltips { get; set; } = new Dictionary<Guid, TooltipInstance>();


        private readonly SemaphoreSlim _semProtectTooltips = new SemaphoreSlim(1, 1);
        private readonly SemaphoreSlim _onAfterRenderSemaphore = new SemaphoreSlim(1, 1);


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            TooltipService.OnAddRenderFragment += AddTooltipRenderFragment;
            TooltipService.OnAddMarkupString += AddTooltipMarkupString;
            TooltipService.OnRemove += RemoveTooltip;
        }



        /// <summary>
        /// Adds a tooltip to the anchor.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="content"></param>
        private void AddTooltipRenderFragment(Guid id, RenderFragment content)
        {
            InvokeAsync(async () =>
            {
                await _semProtectTooltips.WaitAsync();

                try
                {
                    var instance = new TooltipInstance
                    {
                        Id = id,
                        TimeStamp = DateTime.Now,
                        RenderFragmentContent = content,
                        Initiated = false
                    };

                    Tooltips.TryAdd(id, instance);
                }
                finally
                {
                    _semProtectTooltips.Release();
                }

                StateHasChanged();
            });
        }



        /// <summary>
        /// Adds a tooltip to the anchor.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="content"></param>
        private void AddTooltipMarkupString(Guid id, MarkupString content)
        {
            InvokeAsync(async () =>
            {
                await _semProtectTooltips.WaitAsync();

                try
                {
                    var instance = new TooltipInstance
                    {
                        Id = id,
                        TimeStamp = DateTime.Now,
                        MarkupStringContent = content,
                        Initiated = false
                    };

                    Tooltips.TryAdd(id, instance);
                }
                finally
                {
                    _semProtectTooltips.Release();
                }

                StateHasChanged();
            });
        }


        /// <summary>
        /// Removes a tooltip from the anchor.
        /// </summary>
        /// <param name="id"></param>
        internal void RemoveTooltip(Guid id)
        {
            InvokeAsync(async () =>
            {
                await _semProtectTooltips.WaitAsync();

                try
                {
                    if (Tooltips.TryGetValue(id, out var instance))
                    {
                        await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBTooltip.destroy", instance.ElementReference).ConfigureAwait(false);
                        Tooltips.Remove(id);
                    }
                }
                finally
                {
                    _semProtectTooltips.Release();
                }

                StateHasChanged();
            });
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await _semProtectTooltips.WaitAsync();

            try
            {
                var refs = (from tooltip in Tooltips.Values
                            where !tooltip.Initiated &&
                                  !string.IsNullOrWhiteSpace(tooltip.ElementReference.Id)
                            orderby tooltip.TimeStamp
                            select tooltip).ToArray();

                if (refs.Count() > 0)
                {
                    await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBTooltip.init", refs.Select(r => r.ElementReference));

                    foreach (var item in refs)
                    {
                        item.Initiated = true;
                    }
                }
            }
            finally
            {
                _semProtectTooltips.Release();
            }
        }
    }
}
