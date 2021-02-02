using Material.Blazor.Internal;
using System;
using System.Threading.Tasks;

namespace Material.Blazor
{
    /// <summary>
    /// Settings for an individual snackbar notification determining all aspects controlling
    /// it's markup and behaviour. All parameters are optional with defaults defined in
    /// the <see cref="MBSnackbarServiceConfiguration"/> that you define when creating the snackbar service.
    /// </summary>
    public class MBSnackbarSettings
    {
        /// <summary>
        /// The action that is performed when the button in the snackbar is clicked (optional. if set, <see cref="ActionText"/> must also be set).
        /// </summary>
        public Action Action { get; set; }
        /// <summary>
        /// The text to display in the action button in the snackbar (optional. if set, <see cref="Action"/> must also be set).
        /// </summary>
        public string ActionText { get; set; }
        /// <summary>
        /// By default, snackbars are centered horizontally within the viewport.
        /// On larger screens, they can optionally be displayed on the leading edge of the screen (the left side in LTR, or the right side in RTL) by setting this property to true.
        /// Default: false.
        /// </summary>
        public bool Leading { get; set; }
        /// <summary>
        /// Action buttons with long text should be positioned below the label instead of alongside it.
        /// This can be accomplished by setting this property to true.
        /// Default: false.
        /// </summary>
        public bool Stacked { get; set; }
        /// <summary>
        /// The message to be displayed in the snackbar.
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Snackbars are intended to dismiss on their own after a few seconds, but a dedicated dismiss icon may be optionally included as well for accessibility purposes.
        /// By default, a dismiss icon is displayed. This can be disabled by setting this property to false.
        /// </summary>
        public bool DismissIcon { get; set; }


        private int? timeout;
        /// <summary>
        /// The snackbar's timeout in milliseconds.
        /// Minimum value is 4000 (4 seconds), maximum value is 10000 (10s).
        /// Use -1 to disable.
        /// </summary>
        public int? Timeout
        {
            get => timeout;
            set
            {
                if (value == null)
                {
                    timeout = null;
                }
                else if (value == -1)
                {
                    timeout = -1;
                }
                else
                {
                    timeout = Math.Max(4000, Math.Min(value.Value, 10000));
                }
            }
        }

        /// <summary>
        /// The snackbar service's configuration.
        /// </summary>
        internal MBSnackbarServiceConfiguration Configuration { get; set; }

        internal int AppliedTimeout => (Timeout is null) ? Configuration?.Timeout ?? MBSnackbarServiceConfiguration.DefaultTimeout : (int)Timeout;

        internal Func<SnackbarInstance, Task> OnClose { get; set; }
        internal bool Closed { get; set; }
    }
}
