using Microsoft.AspNetCore.Components;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Material.Blazor;

public partial class Select2Table: ComponentBase
{
    [Parameter] public string color { get; set; }
    [Parameter] public decimal fill { get; set; }
    [Parameter] public MBIconGradient gradient { get; set; }
    [Parameter] public MBIconSize size { get; set; }
    [Parameter] public MBIconStyle styleZ { get; set; }
    [Parameter] public MBIconWeight weight { get; set; }
}
