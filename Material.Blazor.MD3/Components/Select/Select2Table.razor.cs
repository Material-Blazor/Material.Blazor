using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;

namespace Material.Blazor;

public partial class Select2Table: ComponentFoundation
{
    [Parameter] public string color { get; set; }
    [Parameter] public decimal fill { get; set; }
    [Parameter] public MBIconGradient gradient { get; set; }
    [Parameter] public MBIconSize size { get; set; }
    [Parameter] public MBIconStyle styleZ { get; set; }
    [Parameter] public MBIconWeight weight { get; set; }
}
