namespace Material.Blazor;

/// <summary>
/// A list item used by <see cref="MBSelect{TItem}"/>, <see cref="MBRadioButtonGroup{TItem}"/> and <see cref="MBPagedDataList{TItem}"/>
/// </summary>
/// <typeparam name="T"></typeparam>
public record MBSelectElement<T>
{
    /// <summary>
    /// The value associated with the list element.
    /// </summary>
    public T SelectedValue { get; set; }


    /// <summary>
    /// The string label(s) expressing the value.
    /// </summary>
    public string LeadingLabel { get; set; }
    public string TrailingLabel { get; set; }


    /// <summary>
    /// Determines whether the list item is to be disabled
    /// </summary>
    public bool? Disabled { get; set; }
}
