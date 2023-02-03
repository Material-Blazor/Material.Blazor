namespace Material.Blazor;

/// <summary>
/// Material Icons foundry details.
/// </summary>
internal class IconFoundryMI3 : IMBIconFoundry3
{
    /// <inheritdoc/>
    MBIconFoundryName IMBIconFoundry3.FoundryName => MBIconFoundryName.MaterialIcons;


    /// <summary>
    /// The Material Icons theme.
    /// </summary>
    public MBIconMITheme? Theme { get; }


    public IconFoundryMI3(MBIconMITheme? theme = null)
    {
        Theme = theme;
    }
}
