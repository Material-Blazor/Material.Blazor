using Microsoft.AspNetCore.Components.Rendering;

namespace Material.Blazor.MD2;

/// <summary>
/// Font Awesome icon.
/// </summary>
internal class IconFA : IMBIcon
{
    private string IconName { get; }


    /// <inheritdoc />
    public bool RequiresColorFilter => false;


    /// <inheritdoc />
    public IMBIcon.IconFragment Render => (@class, style, attributes) => (RenderTreeBuilder builder) =>
    {
        builder.OpenElement(0, "i");
        builder.AddAttribute(1, "class", string.Join(" ", $"fa{IconStyleText}", IconName.ToLower(), Size, @class));
        if (style != null)
        {
            builder.AddAttribute(2, "style", style);
        }
        if (attributes != null)
        {
            builder.AddMultipleAttributes(3, attributes);
        }
        builder.CloseElement();
    };


    /// <summary>
    /// The Font Awesome style.
    /// <para>Overrides <see cref="MBCascadingDefaults.IconFAStyle"/></para>
    /// </summary>
    private MBIconFAStyle Style { get; }


    /// <summary>
    /// The Font Awesome relative size.
    /// <para>Overrides <see cref="MBCascadingDefaults.IconFARelativeSize"/></para>
    /// </summary>
    private MBIconFARelativeSize RelativeSize { get; }


    private string IconStyleText => Style.ToString().Substring(0, 1).ToLower();

    private string Size => RelativeSize switch
    {
        MBIconFARelativeSize.Regular => "",
        MBIconFARelativeSize.ExtraSmall => " fa-xs",
        MBIconFARelativeSize.Small => " fa-sm",
        MBIconFARelativeSize.Large => " fa-lg",
        MBIconFARelativeSize.TwoTimes => " fa-2x",
        MBIconFARelativeSize.ThreeTimes => " fa-3x",
        MBIconFARelativeSize.FiveTimes => " fa-5x",
        MBIconFARelativeSize.SevenTimes => " fa-7x",
        MBIconFARelativeSize.TenTimes => " fa-10x",
        _ => throw new System.NotImplementedException(),
    };


#nullable enable annotations
    public IconFA(string iconName, IconFoundryFA? foundry = null)
    {
        IconName = iconName;
        //Style = cascadingDefaults.AppliedIconFAStyle(foundry?.Style);
        //RelativeSize = cascadingDefaults.AppliedIconFARelativeSize(foundry?.RelativeSize);
    }
#nullable restore annotations
}
