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
    /// An anchor component that displays tooltips taht you add, and using 
    /// <see cref="IMBTooltipService"/>.
    /// Place this component at the top of either App.razor or MainLayout.razor.
    /// </summary>
    public partial class InternalTooltipAnchor : ComponentFoundation
    {
        private Dictionary<Guid, TooltipInstance> Tooltips { get; set; } = new Dictionary<Guid, TooltipInstance>();
        

        private readonly SemaphoreSlim semaphore = new SemaphoreSlim(1);


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside BlazorMdc
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
                await semaphore.WaitAsync();

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
                    semaphore.Release();
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
                await semaphore.WaitAsync();

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
                    semaphore.Release();
                }

                StateHasChanged();
            });
        }



        /// <summary>
        /// Removes a tooltip from the anchor.
        /// </summary>
        /// <param name="id"></param>
        public void RemoveTooltip(Guid id)
        {
            InvokeAsync(async () =>
            {

                await semaphore.WaitAsync();

                try
                {
                    if (Tooltips.TryGetValue(id, out var instance))
                    {
                        Tooltips.Remove(id);
                    }
                }
                finally
                {
                    semaphore.Release();
                }

                StateHasChanged();
            });
        }


        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            var refs = (from t in Tooltips.Values
                        where !t.Initiated
                        orderby t.TimeStamp
                        select t.ElementReference).ToArray();

            await JsRuntime.InvokeVoidAsync("BlazorMdc.tooltip.init", refs);

            foreach (var t in Tooltips.Values.Where(t => !t.Initiated))
            {
                t.Initiated = true;
            }
        }
    }
}
