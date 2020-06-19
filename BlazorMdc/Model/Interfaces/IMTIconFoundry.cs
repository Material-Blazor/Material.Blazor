namespace BlazorMdc
{
    /// <summary>
    /// An interface for supplying icon foundry information to components.
    /// </summary>
    public interface IMTIconFoundry
    {
        /// <summary>
        /// The foundry's name.
        /// </summary>
        internal IconFoundryName FoundryName { get;}
    }
}
