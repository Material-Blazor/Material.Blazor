namespace Material.Blazor
{
    /// <summary>
    /// An interface for supplying icon foundry information to components.
    /// </summary>
    public interface IMBIconFoundry
    {
        /// <summary>
        /// The foundry's name.
        /// </summary>
        internal MBIconFoundryName FoundryName { get; }
    }
}
