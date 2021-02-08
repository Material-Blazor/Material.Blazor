using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Material.Blazor
{
    /// <summary>
    /// Configuration for <see cref="IMBToastService"/>.
    /// </summary>
    public class MBToastServiceConfiguration
    {
        public const MBToastPosition DefaultPosition = MBToastPosition.BottomRight;
        public const string DefaultCloseButtonIcon = "close";
        public const bool DefaultShowIcons = true;
        public const MBToastCloseMethod DefaultCloseMethod = MBToastCloseMethod.TimeoutAndCloseButton;
        public const int DefaultTimeout = 3000;
        public const string DefaultInfoIconName = "notifications";
        public const string DefaultSuccessIconName = "done";
        public const string DefaultWarningIconName = "warning";
        public const string DefaultErrorIconName = "error_outline";


        private MBToastPosition position = DefaultPosition;
        /// <summary>
        /// Sets the toast's position.
        /// </summary>
        public MBToastPosition Position { get => position; set => Setter(ref position, value); }


        private string closeButtonIcon = DefaultCloseButtonIcon;
        /// <summary>
        /// The close icon. Defaults to <see cref="MBToastServiceConfiguration.DefaultCloseButtonIcon"/> ("close").
        /// </summary>
        public string CloseButtonIcon { get => closeButtonIcon; set => Setter(ref closeButtonIcon, value); }


        private bool showIcons = DefaultShowIcons;
        /// <summary>
        /// Determines whether default toasts show an icon.
        /// </summary>
        public bool ShowIcons { get => showIcons; set => Setter(ref showIcons, value); }


        private MBToastCloseMethod closeMethod = DefaultCloseMethod;
        /// <summary>
        /// Determines how the toast closes. Defaults to <see cref="MBToastCloseMethod.TimeoutAndCloseButton"/>.
        /// </summary>
        public MBToastCloseMethod CloseMethod { get => closeMethod; set => Setter(ref closeMethod, value); }


        private uint timeout = DefaultTimeout;
        /// <summary>
        /// Timeout in milliseconds until the toast automatically closes. Defaults to 3000 and ignored if <see cref="MBToastServiceConfiguration.CloseMethod"/> is <see cref="MBToastCloseMethod.CloseButton"/>.
        /// </summary>
        public uint Timeout { get => timeout; set => Setter(ref timeout, value); }


        private int maxToastsShowing = 0;
        /// <summary>
        /// The maximum number of toasts that can be simultaneously shown. Further toasts are queued until others have been closed. Zero or negative means there is no limit.
        /// </summary>
        public int MaxToastsShowing { get => maxToastsShowing; set => Setter(ref maxToastsShowing, value); }


        private string infoDefaultHeading = "";
        /// <summary>
        /// Default heading for an Info toast.
        /// </summary>
        public string InfoDefaultHeading { get => infoDefaultHeading; set => Setter(ref infoDefaultHeading, value); }


        private string successDefaultHeading = "";
        /// <summary>
        /// Default heading for an Success toast.
        /// </summary>
        public string SuccessDefaultHeading { get => successDefaultHeading; set => Setter(ref successDefaultHeading, value); }


        private string warningDefaultHeading = "";
        /// <summary>
        /// Default heading for an waWrning toast.
        /// </summary>
        public string WarningDefaultHeading { get => warningDefaultHeading; set => Setter(ref warningDefaultHeading, value); }


        private string errorDefaultHeading = "";
        /// <summary>
        /// Default heading for an Error toast.
        /// </summary>
        public string ErrorDefaultHeading { get => errorDefaultHeading; set => Setter(ref errorDefaultHeading, value); }


        private string infoIconName;
        /// <summary>
        /// Icon for an Info toast.
        /// </summary>
        public string InfoIconName { get => infoIconName; set => Setter(ref infoIconName, value); }


        private string successIconName;
        /// <summary>
        /// Icon for an Success toast.
        /// </summary>
        public string SuccessIconName { get => successIconName; set => Setter(ref successIconName, value); }


        private string warningIconName;
        /// <summary>
        /// Icon for an warning toast.
        /// </summary>
        public string WarningIconName { get => warningIconName; set => Setter(ref warningIconName, value); }


        private string errorIconName;
        /// <summary>
        /// Icon for an Error toast.
        /// </summary>
        public string ErrorIconName { get => errorIconName; set => Setter(ref errorIconName, value); }


        /// <summary>
        /// Toast icon foundry.
        /// </summary>
        public IMBIconFoundry IconFoundry { get; set; }


        /// <summary>
        /// Used to notify the toast service that a value has changed.
        /// </summary>
        internal event Action OnValueChanged;


        public MBToastServiceConfiguration()
        {
            InfoIconName = DefaultInfoIconName;
            SuccessIconName = DefaultSuccessIconName;
            WarningIconName = DefaultWarningIconName;
            ErrorIconName = DefaultErrorIconName;
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
