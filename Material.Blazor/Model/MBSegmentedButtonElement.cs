namespace Material.Blazor
{
    /// <summary>
    /// A list item used by <see cref="MBSegmentedButtonMulti{TList, TItem}"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MBSegmentedButtonElement<T> : MBListElement<T>
    {
        /// <summary>
        /// The leading icon.
        /// </summary>
        public string LeadingIcon { get; set; }


        /// <summary>
        /// The trailing icon.
        /// </summary>
        public string TrailingIcon { get; set; }
    }
}
