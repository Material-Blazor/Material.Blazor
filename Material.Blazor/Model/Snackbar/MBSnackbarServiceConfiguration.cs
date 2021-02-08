using System;
using System.Collections.Generic;

namespace Material.Blazor
{
    /// <summary>
    /// Configuration for <see cref="IMBSnackbarService"/>.
    /// </summary>
    public class MBSnackbarServiceConfiguration
    {
        public const int DefaultTimeout = 5000;
        public const bool DefaultLeading = false;
        public const bool DefaultStacked = false;
        public const bool DefaultDismissIcon = true;


        private int? timeout = DefaultTimeout;

        /// <summary>
        /// The snackbar's timeout in milliseconds.
        /// Minimum value is 4000 (4 seconds), maximum value is 10000 (10s).
        /// Use -1 to disable.
        /// Defaults to 5000.
        /// </summary>
        public int? Timeout
        {
            get => timeout;
            set => Setter(ref timeout, value switch { null => null, -1 => -1, _ => Math.Max(4000, Math.Min(value.Value, 10000)) });
        }
        /// <summary>
        /// By default, snackbars are centered horizontally within the viewport.
        /// On larger screens, they can optionally be displayed on the leading edge of the screen (the left side in LTR, or the right side in RTL) by setting this property to true.
        /// Default: false.
        /// </summary>
        public bool? Leading { get; set; }
        /// <summary>
        /// Action buttons with long text should be positioned below the label instead of alongside it.
        /// This can be accomplished by setting this property to true.
        /// Default: false.
        /// </summary>
        public bool? Stacked { get; set; }
        /// <summary>
        /// Snackbars are intended to dismiss on their own after a few seconds, but a dedicated dismiss icon may be optionally included as well for accessibility purposes.
        /// By default, a dismiss icon is displayed. This can be disabled by setting this property to false.
        /// </summary>
        public bool? DismissIcon { get; set; }


        /// <summary>
        /// Used to notify the Snackbar service that a value has changed.
        /// </summary>
        internal event Action OnValueChanged;


        private bool Setter<T>(ref T property, T value)
        {
            if (!EqualityComparer<T>.Default.Equals(property, value))
            {
                property = value;
                OnValueChanged?.Invoke();
                return true;
            }

            return false;
        }
    }
}
