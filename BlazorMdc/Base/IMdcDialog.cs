namespace BlazorMdc
{
    /// <summary>
    /// An interface implemented by <see cref="MdcDialog"/> to allow child components to
    /// register themselves for Material Theme js instantiation.
    /// </summary>
    internal interface IMdcDialog
    {
        /// <summary>
        /// The child component should implement <see cref="IMdcDialogChild"/> and call this when running <see cref="Microsoft.AspNetCore.Components.ComponentBase.OnInitialized()"/>
        /// </summary>
        /// <param name="child">The child components that implements <see cref="IMdcDialogChild"/></param>
        void RegisterLayoutAction(IMdcDialogChild child);
    }
}
