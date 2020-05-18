using Microsoft.AspNetCore.Components;

namespace BlazorMdc
{
    /// <summary>
    /// A Material Theme menu selection group.
    /// </summary>
    public partial class MdcMenuSelectionGroup
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}
