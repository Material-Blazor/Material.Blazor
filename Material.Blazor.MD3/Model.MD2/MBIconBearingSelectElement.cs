namespace Material.Blazor.MD2;

/// <summary>
/// A list item used by <see cref="MBSegmentedButtonMulti{IList{TItem}}"/>
/// </summary>
/// <typeparam name="T"></typeparam>
public record MBIconBearingSelectElementMD2<T> : MBSelectElementMD2<T>
{
    /// <summary>
    /// The leading icon.
    /// </summary>
    public string Icon { get; set; }
}
