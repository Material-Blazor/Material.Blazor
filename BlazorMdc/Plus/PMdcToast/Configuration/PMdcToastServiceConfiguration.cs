using System;

namespace BlazorMdc
{
    public class PMdcToastServiceConfiguration
    {
        public const PMdcToastPosition DefaultPosition = PMdcToastPosition.BottomRight;
        public const bool DefaultShowCloseButton = true;
        public const string DefaultCloseIcon = MdcIcons.Icon__close;
        public const bool DefaultShowIcons = true;
        public const bool DefaultRequireInteraction = false;
        public const int DefaultTimeout = 3000; 
        public const string DefaultInfoIcon = MdcIcons.Icon__notifications;
        public const string DefaultSuccessIcon = MdcIcons.Icon__done;
        public const string DefaultWarningIcon = MdcIcons.Icon__warning;
        public const string DefaultErrorIcon = MdcIcons.Icon__error_outline;


        internal event Action OnUpdate;


        private PMdcToastPosition _position = DefaultPosition;
        /// <summary>
        /// Sets the toast's position.
        /// </summary>
        public PMdcToastPosition Position
        {
            get => _position;
            set
            {
                if (value != _position)
                {
                    _position = value;
                    OnUpdate?.Invoke();
                }
            }
        }


        private bool _showCloseButton = DefaultShowCloseButton;
        /// <summary>
        /// States if the close button has to be used for closing a toast. Defaults to true and overridden to true if <see cref="PMdcToastServiceConfiguration.RequireInteraction"/> is true.
        /// </summary>
        public bool ShowCloseButton
        {
            get => _showCloseButton;
            set
            {
                if (value != _showCloseButton)
                {
                    _showCloseButton = value;
                    OnUpdate?.Invoke();
                }
            }
        }


        private string _closeIcon = DefaultCloseIcon;
        /// <summary>
        /// The close icon. Defaults to <see cref="MdcIcons.Icon__close"/>.
        /// </summary>
        public string CloseIcon
        {
            get => _closeIcon;
            set
            {
                if (value != _closeIcon)
                {
                    _closeIcon = value;
                    OnUpdate?.Invoke();
                }
            }
        }


        private bool _showIcons = DefaultShowIcons;
        /// <summary>
        /// Determines whether default toasts show an icon.
        /// </summary>
        public bool ShowIcons
        {
            get => _showIcons;
            set
            {
                if (value != _showIcons)
                {
                    _showIcons = value;
                    OnUpdate?.Invoke();
                }
            }
        }


        private bool _requireInteraction = DefaultRequireInteraction;
        /// <summary>
        /// Determines whether the toast requires interation to be closed or closes automatically on a timeout. When true overrides <see cref="PMdcToastServiceConfiguration.ShowCloseButton"/> to true and ignores <see cref="PMdcToastServiceConfiguration.Timeout"/>.
        /// </summary>
        public bool RequireInteraction
        {
            get => _requireInteraction;
            set
            {
                if (value != _requireInteraction)
                {
                    _requireInteraction = value;
                    OnUpdate?.Invoke();
                }
            }
        }


        private int _timeout = DefaultTimeout;
        /// <summary>
        /// Timeout in milliseconds until the toast automatically closes. Defaults to 3000 and ignored if if <see cref="PMdcToastServiceConfiguration.RequireInteraction"/> is true.
        /// </summary>
        public int Timeout
        {
            get => _timeout;
            set
            {
                if (value != _timeout)
                {
                    _timeout = value;
                    OnUpdate?.Invoke();
                }
            }
        }


        private int _maxToastsShowing = 0;
        /// <summary>
        /// The maximum number of toasts that can be simultaneously shown. Further toasts are queued until others have been closed. Zero or negative means there is no limit.
        /// </summary>
        public int MaxToastsShowing
        {
            get => _maxToastsShowing;
            set
            {
                if (value != _maxToastsShowing)
                {
                    _maxToastsShowing = value;
                    OnUpdate?.Invoke();
                }
            }
        }


        private string _infoDefaultHeading = "";
        /// <summary>
        /// Default heading for an Info toast.
        /// </summary>
        public string InfoDefaultHeading
        {
            get => _infoDefaultHeading;
            set
            {
                if (value != _infoDefaultHeading)
                {
                    _infoDefaultHeading = value;
                    OnUpdate?.Invoke();
                }
            }
        }


        private string _successDefaultHeading = "";
        /// <summary>
        /// Default heading for an Success toast.
        /// </summary>
        public string SuccessDefaultHeading
        {
            get => _successDefaultHeading;
            set
            {
                if (value != _successDefaultHeading)
                {
                    _successDefaultHeading = value;
                    OnUpdate?.Invoke();
                }
            }
        }


        private string _warningDefaultHeading = "";
        /// <summary>
        /// Default heading for an waWrning toast.
        /// </summary>
        public string WarningDefaultHeading
        {
            get => _warningDefaultHeading;
            set
            {
                if (value != _warningDefaultHeading)
                {
                    _warningDefaultHeading = value;
                    OnUpdate?.Invoke();
                }
            }
        }


        private string _errorDefaultHeading = "";
        /// <summary>
        /// Default heading for an Error toast.
        /// </summary>
        public string ErrorDefaultHeading
        {
            get => _errorDefaultHeading;
            set
            {
                if (value != _errorDefaultHeading)
                {
                    _errorDefaultHeading = value;
                    OnUpdate?.Invoke();
                }
            }
        }


        private string _infoIcon = DefaultInfoIcon;
        /// <summary>
        /// Icon for an Info toast.
        /// </summary>
        public string InfoIcon
        {
            get => _infoIcon;
            set
            {
                if (value != _infoIcon)
                {
                    _infoIcon = value;
                    OnUpdate?.Invoke();
                }
            }
        }


        private string _successIcon = DefaultSuccessIcon;
        /// <summary>
        /// Icon for an Success toast.
        /// </summary>
        public string SuccessIcon
        {
            get => _successIcon;
            set
            {
                if (value != _successIcon)
                {
                    _successIcon = value;
                    OnUpdate?.Invoke();
                }
            }
        }


        private string _warningIcon = DefaultWarningIcon;
        /// <summary>
        /// Icon for an waWrning toast.
        /// </summary>
        public string WarningIcon
        {
            get => _warningIcon;
            set
            {
                if (value != _warningIcon)
                {
                    _warningIcon = value;
                    OnUpdate?.Invoke();
                }
            }
        }


        private string _errorIcon = DefaultErrorIcon;
        /// <summary>
        /// Icon for an Error toast.
        /// </summary>
        public string ErrorIcon
        {
            get => _errorIcon;
            set
            {
                if (value != _errorIcon)
                {
                    _errorIcon = value;
                    OnUpdate?.Invoke();
                }
            }
        }
    }
}
