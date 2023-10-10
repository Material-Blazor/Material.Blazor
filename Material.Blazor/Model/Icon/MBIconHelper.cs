using Material.Blazor.Internal;
using System;
using System.Drawing;

namespace Material.Blazor;

/// <summary>
/// A helper class for defining which foundry to use for an icon.
/// </summary>
public class MBIconHelper : IMBIcon
{
    /// <inheritdoc/>
    public bool RequiresColorFilter => UnderlyingIcon.RequiresColorFilter;


    /// <inheritdoc/>
    public IMBIcon.IconFragment Render => UnderlyingIcon.Render;

    private readonly IMBIcon UnderlyingIcon;


    /// <summary>
    /// Returns a new Material Icons foundry.
    /// </summary>
    /// <param name="theme">Optional <see cref="MBIconMITheme"/> specifying the Material Icons theme.</param>
    /// <returns><see cref="IMBIconFoundry"/> to be passed to a Material.Blazor component.</returns>
    public static IMBIconFoundry MIFoundry(MBIconMITheme? theme = null) => new IconFoundryMI(theme);


    /// <summary>
    /// Returns a new Material Symbols foundry.
    /// </summary>
    /// <param name="theme">Optional <see cref="MBIconMSStyle"/> specifying the Material Styles style.</param>
    /// <returns><see cref="IMBIconFoundry"/> to be passed to a Material.Blazor component.</returns>
    public static IMBIconFoundry MSFoundry(
        string color = null,
        bool? fill = null,
        MBIconMSGradient? gradient = null,
        MBIconMSSize? size = null,
        MBIconMSStyle? style = null,
        MBIconMSWeight? weight = null)
        =>
        new IconFoundryMS(
            color,
            fill,
            gradient,
            size,
            style,
            weight);

    /// <summary>
    /// Returns a new Font Awesome foundry.
    /// </summary>
    /// <param name="style">Optional <see cref="MBIconFAStyle"/> specifying the Font Awesome style.</param>
    /// <param name="relativeSize">Optional <see cref="MBIconFARelativeSize"/> specifying the Font Awesome relative size.</param>
    /// <returns><see cref="IMBIconFoundry"/> to be passed to a Material.Blazor component.</returns>
    public static IMBIconFoundry FAFoundry(MBIconFAStyle? style = null, MBIconFARelativeSize? relativeSize = null) => new IconFoundryFA(style, relativeSize);


    /// <summary>
    /// Returns a Open Iconic foundry.
    /// </summary>
    /// <returns><see cref="IMBIconFoundry"/> to be passed to a Material.Blazor component.</returns>
    public static IMBIconFoundry OIFoundry() => new IconFoundryOI();


#nullable enable annotations
    internal MBIconHelper(MBCascadingDefaults cascadingDefaults, string iconName, IMBIconFoundry? foundry = null)
    {
        if (cascadingDefaults is null)
        {
            cascadingDefaults = new MBCascadingDefaults();
        }

        MBIconFoundryName iconFoundry = cascadingDefaults.AppliedIconFoundryName(foundry?.FoundryName);

        UnderlyingIcon = iconFoundry switch
        {
            MBIconFoundryName.MaterialIcons => new Icon_MI(cascadingDefaults, iconName, (IconFoundryMI?)foundry),
            MBIconFoundryName.MaterialSymbols => new Icon_MS(cascadingDefaults, iconName, (IconFoundryMS?)foundry),
            MBIconFoundryName.FontAwesome => new Icon_FA(cascadingDefaults, iconName, (IconFoundryFA?)foundry),
            MBIconFoundryName.OpenIconic => new Icon_OI(cascadingDefaults, iconName, (IconFoundryOI?)foundry),
            _ => throw new NotImplementedException(),
        };
    }
#nullable restore annotations
}
