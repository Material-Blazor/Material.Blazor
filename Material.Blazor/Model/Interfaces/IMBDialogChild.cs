namespace Material.Blazor
{
    /// <summary>
    /// An interface implemented by Material.Blazor components that need to hand over 
    /// when to instantiate Material Theme js to and <see cref="MBDialog"/> when relevant.
    /// </summary>
    internal interface IMBDialogChild
    {
        /// <summary>
        /// A callback for use by <see cref="MBDialog"/> to request Material Theme instantiation.
        /// </summary>
        void RequestInstantiation();
    }
}
