namespace Material.Blazor;

/// <summary>
/// Material Symbols foundry details.
/// </summary>
internal class IconFoundryMS : IMBIconFoundry
{
    /// <inheritdoc/>
    MBIconFoundryName IMBIconFoundry.FoundryName => MBIconFoundryName.MaterialSymbols;


    /// <summary>
    /// The Material Symbols modifiers.
    /// </summary>
    
    public string Color { get; }
    public bool? Fill { get; }
    public MBIconMSGradient? Gradient { get; }
    public MBIconMSSize? Size { get; }
    public MBIconMSStyle? Style { get; }
    public MBIconMSWeight? Weight { get; }

    public IconFoundryMS(
        string color = null,
        bool? fill = null,
        MBIconMSGradient? gradient = null,
        MBIconMSSize? size = null,
        MBIconMSStyle? style = null,
        MBIconMSWeight? weight = null)
    {
        Color = color;
        Fill = fill;
        Gradient = gradient;
        Size = size;
        Style = style;
        Weight = weight;
    }
}
