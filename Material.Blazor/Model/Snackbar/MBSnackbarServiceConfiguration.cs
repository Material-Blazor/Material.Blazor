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
            set
            {
                Setter(ref timeout, value switch { null => null, -1 => -1, _ => Math.Max(4000, Math.Min(value.Value, 10000)) });
            }
        }


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
