﻿namespace BlazorMdc
{
    /// <summary>
    /// An interface implemented by <see cref="MTDialog"/> to allow child components to
    /// register themselves for Material Theme js instantiation.
    /// </summary>
    internal interface IMTDialog
    {
        /// <summary>
        /// The child component should implement <see cref="IMTDialogChild"/> and call this when running <see cref="Microsoft.AspNetCore.Components.Componentbase.OnInitialized()"/>
        /// </summary>
        /// <param name="child">The child components that implements <see cref="IMTDialogChild"/></param>
        void RegisterLayoutAction(IMTDialogChild child);


        /// <summary>
        /// True once the dialog has instantiated components for the first time.
        /// </summary>
        internal bool HasInstantiated { get; }
    }
}
