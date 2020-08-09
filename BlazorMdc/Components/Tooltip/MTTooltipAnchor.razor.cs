using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// An anchor component that displays tooltips taht you add, and using 
    /// <see cref="IMTTooltipService"/>.
    /// Place this component at the top of either App.razor or MainLayout.razor.
    /// </summary>
    public partial class MTTooltipAnchor : ComponentFoundation
    {
        [Inject] private IMTTooltipService TooltipService { get; set; }


        private List<TooltipInstance> Tooltips { get; set; } = new List<TooltipInstance>();
        

        private readonly SemaphoreSlim semaphore = new SemaphoreSlim(1);


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside BlazorMdc
        protected override void OnInitialized()
        {
            TooltipService.OnAdd += AddTooltip;
            TooltipService.OnRemove += RemoveTooltip;
        }



        /// <summary>
        /// Adds a tooltip to the anchor.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="content"></param>
        private void AddTooltip(Guid id, RenderFragment content)
        {
            InvokeAsync(async () =>
            {
                var instance = new TooltipInstance
                {
                    Id = id,
                    TimeStamp = DateTime.Now,
                    Content = content,
                    Initiated = false
                };

                await semaphore.WaitAsync();

                try
                {
                    Tooltips.Add(instance);
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
                    var instance = Tooltips.SingleOrDefault(x => x.Id == id);

                    if (instance is null)
                    {
                        return;
                    }

                    Tooltips.Remove(instance);
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
            var refs = (from t in Tooltips
                        where !t.Initiated
                        orderby t.TimeStamp
                        select t.ElementReference).ToArray();

            await JsRuntime.InvokeAsync<object>("BlazorMdc.tooltip.init", refs);

            foreach (var t in Tooltips.Where(t => !t.Initiated))
            {
                t.Initiated = true;
            }
        }
    }
}
