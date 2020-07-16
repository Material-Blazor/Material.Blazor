namespace BlazorMdc
{
    /// <summary>
    /// An interface implemented by BlazorMdc components that need to hand over 
    /// when to instantiate Material Theme js to and <see cref="MTDialog"/> when relevant.
    /// </summary>
    internal interface IMTDialogChild
    {
        /// <summary>
        /// A callback for use by <see cref="MTDialog"/> to request Material Theme instantiation.
        /// </summary>
        void RequestInstantiation();
    }
}
