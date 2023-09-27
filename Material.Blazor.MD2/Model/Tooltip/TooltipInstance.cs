using Microsoft.AspNetCore.Components;

namespace Material.Blazor.MD2.Internal;

/// <summary>
/// An instance of a tooltip.
/// </summary>
internal class TooltipInstance
{
    /// <summary>
    /// The tooltip's content.
    /// </summary>
    public RenderFragment RenderFragmentContent { get; set; }


    /// <summary>
    /// The tooltip's content.
    /// </summary>
    public MarkupString MarkupStringContent { get; set; }


    /// <summary>
    /// The instance's reference for JS Interop use.
    /// </summary>
    public ElementReference ElementReference { get; set; }


    /// <summary>
    /// True if Material Theme ias intiated the tooltip.
    /// </summary>
    public bool Initiated { get; set; } = false;
}
