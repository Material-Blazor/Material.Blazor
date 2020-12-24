namespace Material.Blazor
{
    /// <summary>
    /// A list item used by <see cref="MBSelect{TItem}"/>, <see cref="MBRadioButtonGroup{TItem}"/> and <see cref="MBPagedDataList{TItem}"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MBSelectElement<T>
    {
        /// <summary>
        /// The value associated with the list element.
        /// </summary>
        public T SelectedValue { get; set; }


        /// <summary>
        /// The string label expressing the value.
        /// </summary>
        public string Label { get; set; }


        /// <summary>
        /// Determines whether the list item is to be disabled
        /// </summary>
        public bool? Disabled { get; set; }
    }
}
