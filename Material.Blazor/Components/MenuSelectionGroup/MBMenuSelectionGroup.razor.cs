using Microsoft.AspNetCore.Components;

namespace Material.Blazor
{
    /// <summary>
    /// A Material Theme menu selection group.
    /// </summary>
    public partial class MBMenuSelectionGroup
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}
