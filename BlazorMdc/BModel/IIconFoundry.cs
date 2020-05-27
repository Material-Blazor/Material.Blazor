namespace BModel
{
    /// <summary>
    /// An interface for supplying icon foundry information to components.
    /// </summary>
    public interface IIconFoundry
    {
        /// <summary>
        /// The foundry's name.
        /// </summary>
        internal BEnum.IconFoundryName FoundryName { get;}
    }
}
