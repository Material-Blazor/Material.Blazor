namespace BModel
{
    /// <summary>
    /// An interface implemented by BlazorMdc components that need to hand over 
    /// when to instantiate Material Theme js to and <see cref="MdcDialog"/> when relevant.
    /// </summary>
    internal interface IDialogChild
    {
        /// <summary>
        /// A callback for use by <see cref="MdcDialog"/> to request Material Theme instantiation.
        /// </summary>
        void RequestInstantiation();
    }
}
