using Material.Blazor;
using System;

namespace Material.Blazor;

/// <summary>
/// A helper class for defining which foundry to use for an icon.
/// </summary>
public class MBIconHelper3 : IMBIcon3
{
    /// <inheritdoc/>
    public bool RequiresColorFilter => UnderlyingIcon.RequiresColorFilter;


    /// <inheritdoc/>
    public IMBIcon3.IconFragment Render => UnderlyingIcon.Render;

    private readonly IMBIcon3 UnderlyingIcon;


    /// <summary>
    /// Returns a new Material Icons foundry.
    /// </summary>
    /// <param name="theme">Optional <see cref="MBIconMITheme"/> specifying the Material Icons theme.</param>
    /// <returns><see cref="IMBIconFoundry"/> to be passed to a Material.Blazor component.</returns>
    public static IMBIconFoundry3 MIFoundry(MBIconMITheme? theme = null) => new IconFoundryMI3(theme);


    /// <summary>
    /// Returns a new Font Awesome foundry.
    /// </summary>
    /// <param name="style">Optional <see cref="MBIconFAStyle"/> specifying the Font Awesome style.</param>
    /// <param name="relativeSize">Optional <see cref="MBIconFARelativeSize"/> specifying the Font Awesome relative size.</param>
    /// <returns><see cref="IMBIconFoundry"/> to be passed to a Material.Blazor component.</returns>
    public static IMBIconFoundry3 FAFoundry(MBIconFAStyle? style = null, MBIconFARelativeSize? relativeSize = null) => new IconFoundryFA3(style, relativeSize);


    /// <summary>
    /// Returns a Open Iconic foundry.
    /// </summary>
    /// <returns><see cref="IMBIconFoundry"/> to be passed to a Material.Blazor component.</returns>
    public static IMBIconFoundry3 OIFoundry() => new IconFoundryOI3();


#nullable enable annotations
    internal MBIconHelper3(string iconName, IMBIconFoundry3? foundry = null)
    {
        //if (cascadingDefaults is null)
        //{
        //    cascadingDefaults = new MBCascadingDefaults();
        //}

        MBIconFoundryName iconFoundry = MBIconFoundryName.MaterialIcons;

        UnderlyingIcon = iconFoundry switch
        {
            MBIconFoundryName.MaterialIcons => new IconMI3(iconName, (IconFoundryMI3?)foundry),
            MBIconFoundryName.FontAwesome => new IconFA3(iconName, (IconFoundryFA3?)foundry),
            MBIconFoundryName.OpenIconic => new IconOI3(iconName, (IconFoundryOI3?)foundry),
            _ => throw new NotImplementedException(),
        };
    }
#nullable restore annotations
}
