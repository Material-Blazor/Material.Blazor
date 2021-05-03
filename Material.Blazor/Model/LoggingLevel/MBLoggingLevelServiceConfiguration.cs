using System;
using System.Collections.Generic;

namespace Material.Blazor
{
    /// <summary>
    /// Configuration for <see cref="IMBLoggingLevelService"/>.
    /// </summary>
    public class MBLoggingLevelServiceConfiguration
    {
        public const MBLoggingLevel DefaultLoggingLevel = MBLoggingLevel.Warning;


        private MBLoggingLevel loggingLevel = DefaultLoggingLevel;
        /// <summary>
        /// Sets the logging level.
        /// </summary>
        public MBLoggingLevel LoggingLevel { get => loggingLevel; set => Setter(ref loggingLevel, value); }


        /// <summary>
        /// Used to notify the logging level service that a value has changed.
        /// </summary>
        internal event Action OnValueChanged;


        public MBLoggingLevelServiceConfiguration()
        {
            LoggingLevel = DefaultLoggingLevel;
        }


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
