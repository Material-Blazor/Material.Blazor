namespace Material.Blazor;

/// <summary>
/// Material Symbols foundry details.
/// </summary>
public class MBIconDescriptor
{
    /// <summary>
    /// The Material Symbols descriptors.
    /// </summary>
    
    public string Color { get; }
    public decimal? Fill { get; }
    public MBIconGradient? Gradient { get; }
    public string Name { get; }
    public MBIconSize? Size { get; }
    public MBIconStyle? Style { get; }
    public MBIconWeight? Weight { get; }

    public MBIconDescriptor()
    {
        Color = null;
        Fill = null;
        Gradient = null;
        Name = null;
        Size = null;
        Style = null;
        Weight = null;
    }

    public MBIconDescriptor(
        string color = null,
        decimal? fill = null,
        MBIconGradient? gradient = null,
        string name = null,
        MBIconSize? size = null,
        MBIconStyle? style = null,
        MBIconWeight? weight = null)
    {
        Color = color;
        Fill = fill;
        Gradient = gradient;
        Name = name;
        Size = size;
        Style = style;
        Weight = weight;
    }
}
