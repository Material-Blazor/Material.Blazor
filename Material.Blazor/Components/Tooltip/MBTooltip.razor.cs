using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace Material.Blazor;

public partial class MBTooltip : ComponentFoundation, IDisposable
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



    private readonly long id = TooltipIdProvider.NextId();
    private bool disposedValue;



    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

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
