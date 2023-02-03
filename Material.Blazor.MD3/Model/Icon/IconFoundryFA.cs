namespace Material.Blazor;

/// <summary>
/// Font Awesome foundry details.
/// </summary>
internal class IconFoundryFA3 : IMBIconFoundry3
{
    /// <inheritdoc/>
    MBIconFoundryName IMBIconFoundry3.FoundryName => MBIconFoundryName.FontAwesome;


    /// <summary>
    /// The Font Awesome style.
    /// </summary>
    public MBIconFAStyle? Style { get; }


    /// <summary>
    /// The Font Awesome relative size.
    /// </summary>
    public MBIconFARelativeSize? RelativeSize { get; }


    public IconFoundryFA3(MBIconFAStyle? style = null, MBIconFARelativeSize? relativesize = null)
    {
        Style = style;
        RelativeSize = relativesize;
    }
}
