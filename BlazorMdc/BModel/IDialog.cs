namespace BModel
{
    /// <summary>
    /// An interface implemented by <see cref="MdcDialog"/> to allow child components to
    /// register themselves for Material Theme js instantiation.
    /// </summary>
    internal interface IDialog
    {
        /// <summary>
        /// The child component should implement <see cref="IDialogChild"/> and call this when running <see cref="Microsoft.AspNetCore.Components.ComponentBase.OnInitialized()"/>
        /// </summary>
        /// <param name="child">The child components that implements <see cref="IDialogChild"/></param>
        void RegisterLayoutAction(IDialogChild child);
    }
}
