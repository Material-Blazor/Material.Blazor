using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace Material.Blazor.MD2;

/// <summary>
/// Optionally applies a &lt;div&gt; element with class 'mdc-touch-target-wrapper' around the child content.
/// </summary>
public class MBTouchTargetWrapper : ComponentBase
{
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        if (ApplyTouchTargetWrapper)
        {
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "mdc-touch-target-wrapper");
        }
        builder.AddContent(2, ChildContent);
        if (ApplyTouchTargetWrapper)
        {
            builder.CloseElement();
        }
    }


    /// <summary>
    /// Determines whether to apply the wrapper.
    /// </summary>
    [Parameter] public bool ApplyTouchTargetWrapper { get; set; }


    /// <summary>
    /// Child content render fragment.
    /// </summary>
    [Parameter] public RenderFragment ChildContent { get; set; }
}
