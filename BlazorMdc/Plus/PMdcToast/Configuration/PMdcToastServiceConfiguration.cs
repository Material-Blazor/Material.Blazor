using System;
using System.Collections.Generic;

namespace BlazorMdc
{
    /// <summary>
    /// Configuration for <see cref="IPmdcToastService"/>.
    /// </summary>
    public class PMdcToastServiceConfiguration
    {
        public const BEnum.ToastPosition DefaultPosition = BEnum.ToastPosition.BottomRight;
        public const string DefaultCloseButtonIcon = "close";
        public const bool DefaultShowIcons = true;
        public const BEnum.ToastCloseMethod DefaultCloseMethod = BEnum.ToastCloseMethod.TimeoutAndCloseButton;
        public const int DefaultTimeout = 3000; 
        public const string DefaultInfoIconName = "notifications";
        public const string DefaultSuccessIconName = "done";
        public const string DefaultWarningIconName = "warning";
        public const string DefaultErrorIconName = "error_outline";
        

        /// <summary>
        /// Toast configuration update callback. Is this ever actually used?
        /// </summary>
        [Obsolete]
        internal event Action OnUpdate;


        private BEnum.ToastPosition _position = DefaultPosition;
        /// <summary>
        /// Sets the toast's position.
        /// </summary>
        public BEnum.ToastPosition Position
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


        private BEnum.ToastCloseMethod _closeMethod = DefaultCloseMethod;
        /// <summary>
        /// Determines how the toast closes. Defaults to <see cref="ToastCloseMethod.TimeoutAndCloseButton"/>.
        /// </summary>
        public BEnum.ToastCloseMethod CloseMethod
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
        /// Timeout in milliseconds until the toast automatically closes. Defaults to 3000 and ignored if <see cref="PMdcToastServiceConfiguration.CloseMethod"/> is <see cref="ToastCloseMethod.CloseButton"/>.
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


        private string _infoIconName;
        /// <summary>
        /// Icon for an Info toast.
        /// </summary>
        public string InfoIconName
        {
            get => _infoIconName;
            set
            {
                if (value != _infoIconName)
                {
                    _infoIconName = value;
                    OnUpdate?.Invoke();
                }
            }
        }


        private string _successIconName;
        /// <summary>
        /// Icon for an Success toast.
        /// </summary>
        public string SuccessIconName
        {
            get => _successIconName;
            set
            {
                if (value != _successIconName)
                {
                    _successIconName = value;
                    OnUpdate?.Invoke();
                }
            }
        }


        private string _warningIconName;
        /// <summary>
        /// Icon for an waWrning toast.
        /// </summary>
        public string WarningIconName
        {
            get => _warningIconName;
            set
            {
                if (value != _warningIconName)
                {
                    _warningIconName = value;
                    OnUpdate?.Invoke();
                }
            }
        }


        private string _errorIconName;
        /// <summary>
        /// Icon for an Error toast.
        /// </summary>
        public string ErrorIconName
        {
            get => _errorIconName;
            set
            {
                if (value != _errorIconName)
                {
                    _errorIconName = value;
                    OnUpdate?.Invoke();
                }
            }
        }


        private BModel.IIconFoundry _iconFoundry;
        /// <summary>
        /// Toast icon foundry.
        /// </summary>
        public BModel.IIconFoundry IconFoundry
        {
            get => _iconFoundry;
            set
            {
                if (!EqualityComparer<BModel.IIconFoundry>.Default.Equals(value, _iconFoundry))
                {
                    _iconFoundry = value;
                    OnUpdate?.Invoke();
                }
            }
        }


        public PMdcToastServiceConfiguration()
        {
            _infoIconName = DefaultInfoIconName;
            _successIconName = DefaultSuccessIconName;
            _warningIconName = DefaultWarningIconName;
            _errorIconName = DefaultErrorIconName;
        }
    }
}
