using System;

namespace Material.Blazor
{
    /// <summary>
    /// Interface for the Material.Blazor toast service, developed from the code base of Blazored Toast by Chris Sainty.
    /// Works in conjunction with a <see cref="MBToastAnchor"/> that must be placed in either App.razor or
    /// MainLayout.razor to avoid an exception being thrown when you first attempt to show a toast notification.
    /// 
    /// <para>
    /// Throws a <see cref="System.InvalidOperationException"/> if
    /// <see cref="ShowToast(MBToastLevel, string, string, MBToastCloseMethod?, string, string, IMBIconFoundry?, bool?, uint?, bool)"/>
    /// is called without an <see cref="MBToastAnchor"/> component used in the app.
    /// </para>
    /// <example>
    /// <para>You can optionally add configuration when you add this to the service collection:</para>
    /// <code>
    /// services.AddMBToastService(new MBToastServiceConfiguration()
    /// {
    ///     Postion = MBToastPosition.TopRight,
    ///     CloseMethod = MBToastCloseMethod.Timeout,
    ///     ... etc
    /// });
    /// </code>
    /// </example>
    /// </summary>
    public interface IMBToastService
    {
        /// <summary>
        /// Toast service configuration
        /// </summary>
        public MBToastServiceConfiguration Configuration { get; set; }



        /// <summary>
        /// A event that will be invoked when showing a toast
        /// </summary>
        internal event Action<MBToastLevel, MBToastSettings> OnAdd;



        /// <summary>
        /// A event that will be invoked when toasts should call StateHasChanged. This will
        /// be when the configuration is updated.
        /// </summary>
        internal event Action OnTriggerStateHasChanged;



        /// <summary>
        /// Shows a toast using the supplied settings. Only the level and message parameters are required, with
        /// the remainder haveing defaults specified by the <see cref="MBToastServiceConfiguration"/> that you can supply
        /// when registering services. Failing that Material.Blazor provides defaults.
        /// </summary>
        /// <param name="level">Severity of the toast (info, error, etc)</param>
        /// <param name="message">Body text in the toast</param>
        /// <param name="heading">Text used in the heading of the toast</param>
        /// <param name="closeMethod">close method</param>
        /// <param name="cssClass">additional css applied to toast</param>
        /// <param name="iconName">Icon name</param>
        /// <param name="iconFoundry">The icon's foundry</param>
        /// <param name="showIcon">Show or hide icon</param>
        /// <param name="timeout">Length of time before autodismiss</param>
        /// <param name="debug">If true only shows toasts when compiling in DEBUG mode</param>
#nullable enable annotations
        void ShowToast(
            MBToastLevel level,
            string message,
            string heading = null,
            MBToastCloseMethod? closeMethod = null,
            string cssClass = null,
            string iconName = null,
            IMBIconFoundry? iconFoundry = null,
            bool? showIcon = null,
            uint? timeout = null,
            bool debug = false);
#nullable restore annotations
    }
}
