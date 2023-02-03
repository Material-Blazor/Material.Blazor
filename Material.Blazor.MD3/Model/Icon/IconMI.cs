using Microsoft.AspNetCore.Components.Rendering;

namespace Material.Blazor;

/// <summary>
/// Material Icons icon.
/// </summary>
internal class IconMI3 : IMBIcon3
{
    private string MaterialIconsTheme
    {
        get
        {
            return "material-icons" + Theme switch
            {
                MBIconMITheme.Filled => "",
                MBIconMITheme.Outlined => "-outlined",
                MBIconMITheme.Round => "-round",
                MBIconMITheme.TwoTone => "-two-tone",
                MBIconMITheme.Sharp => "-sharp",
                _ => throw new System.NotImplementedException(),
            };
        }
    }


    private string IconName { get; }


    /// <inheritdoc />
    public bool RequiresColorFilter => Theme == MBIconMITheme.TwoTone;


    /// <inheritdoc />
    public IMBIcon3.IconFragment Render => (@class, style, attributes) => (RenderTreeBuilder builder) =>
    {
        if (IconName == null)
        {
            return;
        }
        builder.OpenElement(0, "i");
        builder.AddAttribute(1, "class", string.Join(" ", MaterialIconsTheme, @class));
        if (style != null)
        {
            builder.AddAttribute(2, "style", style);
        }
        if (attributes != null)
        {
            builder.AddMultipleAttributes(3, attributes);
        }
        builder.AddContent(4, IconName.ToLower());
        builder.CloseElement();
    };


    /// <summary>
    /// The Material Icons theme.
    /// <para>Overrides <see cref="MBCascadingDefaults.IconMITheme"/></para>
    /// </summary>
    public MBIconMITheme Theme { get; }


#nullable enable annotations
    public IconMI3(string iconName, IconFoundryMI3? foundry = null)
    {
        IconName = iconName;
    }
#nullable restore annotations
}
