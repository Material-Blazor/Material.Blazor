using System;

namespace BlazorMdc
{
    public class PMdcToastServiceConfiguration
    {
        public const PMdcToastPosition DefaultPosition = PMdcToastPosition.BottomRight;
        public const string DefaultCloseButtonIcon = "close";
        public const bool DefaultShowIcons = true;
        public const PMdcToastCloseMethod DefaultCloseMethod = PMdcToastCloseMethod.TimeoutAndCloseButton;
        public const int DefaultTimeout = 3000; 
        public readonly MdcIconHelper DefaultInfoIcon = new MdcIconHelper(null, "notifications", MdcIconHelper.MIFoundry());
        public readonly MdcIconHelper DefaultSuccessIcon = new MdcIconHelper(null, "done", MdcIconHelper.MIFoundry());
        public readonly MdcIconHelper DefaultWarningIcon = new MdcIconHelper(null, "warning", MdcIconHelper.MIFoundry());
        public readonly MdcIconHelper DefaultErrorIcon = new MdcIconHelper(null, "error_outline", MdcIconHelper.MIFoundry());
        public readonly ulong DefaultIconFoundry = (ulong)MdcIconFoundryName.MaterialIcons | (ulong)MdcIconMITheme.Filled;


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


        private string _closeButtonIcon = DefaultCloseButtonIcon;
        /// <summary>
        /// The close icon. Defaults to <see cref="MdcIcons.MI__close"/>.
        /// </summary>
        public string CloseButtonIcon
        {
            get => _closeButtonIcon;
            set
            {
                if (value != _closeButtonIcon)
                {
                    _closeButtonIcon = value;
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


        private PMdcToastCloseMethod _closeMethod = DefaultCloseMethod;
        /// <summary>
        /// Determines how the toast closes. Defaults to <see cref="PMdcToastCloseMethod.TimeoutAndCloseButton"/>.
        /// </summary>
        public PMdcToastCloseMethod CloseMethod
        {
            get => _closeMethod;
            set
            {
                if (value != _closeMethod)
                {
                    _closeMethod = value;
                    OnUpdate?.Invoke();
                }
            }
        }


        private uint _timeout = DefaultTimeout;
        /// <summary>
        /// Timeout in milliseconds until the toast automatically closes. Defaults to 3000 and ignored if <see cref="PMdcToastServiceConfiguration.CloseMethod"/> is <see cref="PMdcToastCloseMethod.CloseButton"/>.
        /// </summary>
        public uint Timeout
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


        private MdcIconHelper _infoIcon;
        /// <summary>
        /// Icon for an Info toast.
        /// </summary>
        public MdcIconHelper InfoIcon
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


        private MdcIconHelper _successIcon;
        /// <summary>
        /// Icon for an Success toast.
        /// </summary>
        public MdcIconHelper SuccessIcon
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


        private MdcIconHelper _warningIcon;
        /// <summary>
        /// Icon for an waWrning toast.
        /// </summary>
        public MdcIconHelper WarningIcon
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


        private MdcIconHelper _errorIcon;
        /// <summary>
        /// Icon for an Error toast.
        /// </summary>
        public MdcIconHelper ErrorIcon
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

        public PMdcToastServiceConfiguration()
        {
            _infoIcon = DefaultInfoIcon;
            _successIcon = DefaultSuccessIcon;
            _warningIcon = DefaultWarningIcon;
            _errorIcon = DefaultErrorIcon;
        }
    }
}
