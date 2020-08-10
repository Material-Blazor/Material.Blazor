using Microsoft.AspNetCore.Components;
using System;

namespace BlazorMdc
{
    public partial class MTTooltip : IDisposable
    {
        [Inject] private IMTTooltipService TooltipService { get; set; }


        /// <summary>
        /// The render fragment requiring the tooltip.
        /// </summary>
        [Parameter] public RenderFragment Target { get; set; }



        /// <summary>
        /// The tooltip's content.
        /// </summary>
        [Parameter] public RenderFragment Content { get; set; }



        /// <summary>
        /// The tooltip's content.
        /// </summary>
        [Parameter] public MTTooltipType TooltipType { get; set; } = MTTooltipType.Span;



        private readonly Guid id = Guid.NewGuid();
        private bool disposedValue;



        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside BlazorMdc
        protected override void OnInitialized()
        {
            base.OnInitialized();

            TooltipService.AddTooltip(id, Content);
        }


        /// <inheritdoc/>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    TooltipService.RemoveTooltip(id);
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        
        /// <inheritdoc/>
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
