using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System.Linq;

namespace Material.Blazor;

/// <summary>
/// Renders icons from any of the Material Icons, Font Awesome and Open Iconic
/// foundries. Material Icons are essential for Material.Blazor and are included by the
/// library's CSS, while you can elect whether to include Font Awesome and Open Iconic
/// in your app.
/// </summary>
public class MBIcon : ComponentFoundation
{
    [CascadingParameter(Name = "IsInsideMBTabBar")] private bool IsInsideMBTabBar { get; set; }


    /// <summary>
    /// The icon name.
    /// </summary>
    [Parameter] public string IconName { get; set; }


    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToArray();
        
        builder.OpenElement(0, "md-icon");
        {
            if (attributesToSplat.Any())
            {
                builder.AddMultipleAttributes(1, attributesToSplat);
            }

            builder.AddAttribute(2, "class", @class);
            builder.AddAttribute(3, "style", style);
            builder.AddAttribute(4, "id", id);
            builder.AddContent(5, IconName);
        }
        builder.CloseElement();
    }
}
