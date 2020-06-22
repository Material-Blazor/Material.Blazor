using Microsoft.AspNetCore.Components;

namespace BlazorMdc
{
    /// <summary>
    /// A Material Theme menu selection group.
    /// </summary>
    public partial class MTMenuSelectionGroup
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}
