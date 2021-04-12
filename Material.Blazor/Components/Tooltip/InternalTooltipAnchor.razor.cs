using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
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
        private ConcurrentDictionary<Guid, TooltipInstance> Tooltips { get; set; } = new();


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
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
            _ = Tooltips.TryAdd(id, new TooltipInstance
            {
                Id = id,
                RenderFragmentContent = content,
                Initiated = false
            });
            _ = InvokeAsync(StateHasChanged);
        }



        /// <summary>
        /// Adds a tooltip to the anchor.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="content"></param>
        private void AddTooltipMarkupString(Guid id, MarkupString content)
        {
            _ = Tooltips.TryAdd(id, new TooltipInstance
            {
                Id = id,
                MarkupStringContent = content,
                Initiated = false
            });
            _ = InvokeAsync(StateHasChanged);
        }


        /// <summary>
        /// Removes a tooltip from the anchor.
        /// </summary>
        /// <param name="id"></param>
        internal void RemoveTooltip(Guid id)
        {
            try
            {
                _ = Tooltips.Remove(id, out var _);
                _ = InvokeAsync(StateHasChanged);
            }
            catch (Exception ex)
            {
                // Ignore ObjectDisposedException to avoid exceptions being thrown when the user closes browser and tooltips are showing.
                if (ex is not ObjectDisposedException)
                {
                    throw;
                }
            }
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            var refs = (from tooltip in Tooltips.Values
                        where !tooltip.Initiated &&
                              !string.IsNullOrWhiteSpace(tooltip.ElementReference.Id)
                        select tooltip).ToArray();

            if (refs.Length > 0)
            {
                await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBTooltip.init", refs.Select(r => r.ElementReference));

                foreach (var item in refs)
                {
                    item.Initiated = true;
                }
            }
        }
    }
}
