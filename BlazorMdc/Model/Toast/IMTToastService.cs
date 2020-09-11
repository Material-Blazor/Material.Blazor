using System;

namespace BlazorMdc
{
    /// <summary>
    /// Interface for the BlazorMdc toast service, developed from the code base of Blazored Toast by Chris Sainty.
    /// Works in conjunction with a <see cref="MTToastAnchor"/> that must be placed in either App.razor or
    /// MainLayout.razor to avoid an exception being thrown when you first attempt to show a toast notification.
    /// 
    /// <para>
    /// Throws a <see cref="System.InvalidOperationException"/> if
    /// <see cref="ShowToast(MTToastLevel, string, string, MTToastCloseMethod?, string, string, IMTIconFoundry?, bool?, uint?)"/>
    /// is called without an <see cref="MTToastAnchor"/> component used in the app.
    /// </para>
    /// <example>
    /// <para>You can optionally add configuration when you add this to the service collection:</para>
    /// <code>
    /// services.AddMTToastService(new MTToastServiceConfiguration()
    /// {
    ///     Postion = MTToastPosition.TopRight,
    ///     CloseMethod = MTToastCloseMethod.Timeout,
    ///     ... etc
    /// });
    /// </code>
    /// </example>
    /// </summary>
    public interface IMTToastService
    {
        /// <summary>
        /// Toast service configuration
        /// </summary>
        public MTToastServiceConfiguration Configuration { get; set; }



        /// <summary>
        /// A event that will be invoked when showing a toast
        /// </summary>
        internal event Action<MTToastLevel, MTToastSettings> OnAdd;



        /// <summary>
        /// Shows a toast using the supplied settings. Only the level and message parameters are required, with
        /// the remainder haveing defaults specified by the <see cref="MTToastServiceConfiguration"/> that you can supply
        /// when registering services. Failing that Blazor MDC provides defaults.
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
#nullable enable annotations
        void ShowToast(
            MTToastLevel level,
            string message,
            string heading = null,
            MTToastCloseMethod? closeMethod = null,
            string cssClass = null,
            string iconName = null,
            IMTIconFoundry? iconFoundry = null,
            bool? showIcon = null,
            uint? timeout = null);
#nullable restore annotations
    }
}
