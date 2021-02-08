using Microsoft.AspNetCore.Components;
using System;

namespace Material.Blazor
{
    public partial class MBTooltip : IDisposable
    {
        [Inject] private IMBTooltipService TooltipService { get; set; }


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
        [Parameter] public MBTooltipType TooltipType { get; set; } = MBTooltipType.Span;



        private readonly Guid id = Guid.NewGuid();
        private bool disposedValue;



        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            TooltipService.AddTooltip(id, Content);
        }


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


        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
