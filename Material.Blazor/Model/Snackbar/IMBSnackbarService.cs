using System;

namespace Material.Blazor
{
    /// <summary>
    /// Interface for the Material.Blazor snackbar service, developed from the code base of Blazored Snackbar by Chris Sainty.
    /// Works in conjunction with a <see cref="MBSnackbarAnchor"/> that must be placed in either App.razor or
    /// MainLayout.razor to avoid an exception being thrown when you first attempt to show a snackbar notification.
    /// 
    /// <para>
    /// Throws a <see cref="System.InvalidOperationException"/> if
    /// <see cref="ShowSnackbar"/>
    /// is called without an <see cref="MBSnackbarAnchor"/> component used in the app.
    /// </para>
    /// <example>
    /// <para>You can optionally add configuration when you add this to the service collection:</para>
    /// <code>
    /// services.AddMBSnackbarService(new MBSnackbarServiceConfiguration()
    /// {
    ///     Postion = MBSnackbarPosition.TopRight,
    ///     CloseMethod = MBSnackbarCloseMethod.Timeout,
    ///     ... etc
    /// });
    /// </code>
    /// </example>
    /// </summary>
    public interface IMBSnackbarService
    {
        /// <summary>
        /// Snackbar service configuration
        /// </summary>
        public MBSnackbarServiceConfiguration Configuration { get; set; }



        /// <summary>
        /// A event that will be invoked when showing a snackbar
        /// </summary>
        internal event Action<MBSnackbarSettings> OnAdd;



        /// <summary>
        /// A event that will be invoked when snackbars should call StateHasChanged. This will
        /// be when the configuration is updated.
        /// </summary>
        internal event Action OnTriggerStateHasChanged;



        /// <summary>
        /// Shows a snackbar using the supplied settings. Only the level and message parameters are required, with
        /// the remainder haveing defaults specified by the <see cref="MBSnackbarServiceConfiguration"/> that you can supply
        /// when registering services. Failing that Material.Blazor provides defaults.
        /// </summary>
        /// <param name="message">Body text in the snackbar</param>
        /// <param name="action">The action that is performed when the button in the snackbar is clicked (optional. if set, <see cref="action_text"/> must also be set)</param>
        /// <param name="action_text">The text to display in the action button in the snackbar (optional. if set, <see cref="action"/> must also be set)</param>
        /// <param name="dismiss_icon">Snackbars are intended to dismiss on their own after a few seconds, but a dedicated dismiss icon may be optionally included as well for accessibility purposes</param>
        /// <param name="leading">By default, snackbars are centered horizontally within the viewport. On larger screens, they can optionally be displayed on the leading edge of the screen (the left side in LTR, or the right side in RTL)</param>
        /// <param name="stacked">Action buttons with long text should be positioned below the label instead of alongside it</param>
        /// <param name="timeout">Length of time before autodismiss</param>
        /// <param name="debug">If true only shows snackbars when compiling in DEBUG mode</param>
#nullable enable annotations
        void ShowSnackbar(
            string message,
            Action action = null,
            string actionText = null,
            bool dismissIcon = true,
            bool leading = false,
            bool stacked = false,
            int? timeout = null,
            bool debug = false);
#nullable restore annotations
    }
}
