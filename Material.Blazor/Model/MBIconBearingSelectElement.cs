namespace Material.Blazor
{
    /// <summary>
    /// A list item used by <see cref="MBSegmentedButtonMulti{IList{TItem}}"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MBIconBearingSelectElement<T> : MBSelectElement<T>
    {
        /// <summary>
        /// The leading icon.
        /// </summary>
        public string Icon { get; set; }
    }
}
