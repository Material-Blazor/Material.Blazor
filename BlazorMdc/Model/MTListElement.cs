namespace BlazorMdc
{
    /// <summary>
    /// A list item used by <see cref="MTSelect{TItem}"/>, <see cref="MTRadioButtonGroup{TItem}"/> and <see cref="MTPagedDataList{TItem}"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MTListElement<T>
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
        public bool Disabled { get; set; } = false;
    }
}
