namespace Material.Blazor;

/// <summary>
/// A list item used by <see cref="MBSelect{TItem}"/>, <see cref="MBRadioButtonGroup{TItem}"/> and <see cref="MBPagedDataList{TItem}"/>
/// </summary>
/// <typeparam name="T"></typeparam>
public record MBSingleSelectElement<T>
{
    /// <summary>
    /// Determines whether the list item is to be disabled
    /// </summary>
    public bool? Disabled { get; set; }


    /// <summary>
    /// The string label(s) expressing the value.
    /// Only used by MBRadioButton
    /// </summary>
    public string LeadingLabel { get; set; }


    /// <summary>
    /// The value associated with the list element.
    /// </summary>
    public T SelectedValue { get; set; }


    /// <summary>
    /// The string label(s) expressing the value.
    /// This is the label used by all three MBSelect/MBRadioButtonGroup/MBPagedDataList
    /// </summary>
    public string TrailingLabel { get; set; }
}
