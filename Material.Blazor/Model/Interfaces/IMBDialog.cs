namespace Material.Blazor
{
    /// <summary>
    /// An interface implemented by <see cref="MBDialog"/> to allow child components to
    /// register themselves for Material Theme js instantiation.
    /// </summary>
    internal interface IMBDialog
    {
        /// <summary>
        /// The child component should implement <see cref="DialogChildComponentFoundation"/> and call this when running <see cref="Microsoft.AspNetCore.Components.Componentbase.OnInitialized()"/>
        /// </summary>
        /// <param name="child">The child components that implements <see cref="DialogChildComponentFoundation"/></param>
        void RegisterLayoutAction(DialogChildComponentFoundation child);


        /// <summary>
        /// True once the dialog has instantiated components for the first time.
        /// </summary>
        internal bool DialogHasInstantiated { get; }
    }
}
