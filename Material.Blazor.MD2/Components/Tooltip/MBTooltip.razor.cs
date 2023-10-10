using Material.Blazor.MD2.Internal;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace Material.Blazor.MD2;

public partial class MBTooltip : ComponentFoundation, IDisposable
{
    /// <summary>
    /// The render fragment requiring the tooltip.
    /// </summary>
    [Parameter] public RenderFragment Target { get; set; }



    /// <summary>
    /// The tooltip's content.
    /// </summary>
    [Parameter] public RenderFragment Content { get; set; }



    private readonly long tooltipId = TooltipIdProvider.NextId();
    private bool disposedValue;



    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor.MD2
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        TooltipService.AddTooltip(tooltipId, Content);
    }


    protected virtual new void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                TooltipService.RemoveTooltip(tooltipId);
            }
            disposedValue = true;
        }
    }


    public new void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
