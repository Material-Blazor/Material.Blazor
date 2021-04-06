using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace Material.Blazor
{
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
        [Parameter] public bool ApplyTouchTargetWrapper { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}
