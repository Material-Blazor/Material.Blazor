using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components.Rendering;

namespace Material.Blazor;

/// <summary>
/// Open Iconic icon.
/// </summary>
internal class Icon_OI : IMBIcon
{
    private string IconName { get; }


    /// <inheritdoc />
    public bool RequiresColorFilter => false;


    /// <inheritdoc />
    public IMBIcon.IconFragment Render => (@class, style, attributes) => (RenderTreeBuilder builder) =>
    {
        builder.OpenElement(0, "i");
        builder.AddAttribute(1, "class", string.Join(" ", "oi", @class));
        if (style != null)
        {
            builder.AddAttribute(2, "style", style);
        }
        builder.AddAttribute(3, "data-glyph", IconName);
        if (attributes != null)
        {
            builder.AddMultipleAttributes(4, attributes);
        }
        builder.CloseElement();
    };


#nullable enable annotations
#pragma warning disable IDE0060 // Remove unused parameter
    public Icon_OI(MBCascadingDefaults cascadingDefaults, string iconName, IconFoundryOI? foundry = null)
    {
        IconName = iconName;
    }
#pragma warning restore IDE0060 // Remove unused parameter
#nullable restore annotations
}
