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


        /// <summary>
        /// Sets the toast's position.
        /// </summary>
        public MBToastPosition Position { get; set; } = DefaultPosition;


        /// <summary>
        /// The close icon. Defaults to <see cref="MBToastServiceConfiguration.DefaultCloseButtonIcon"/> ("close").
        /// </summary>
        public string CloseButtonIcon { get; set; } = DefaultCloseButtonIcon;


        /// <summary>
        /// Determines whether default toasts show an icon.
        /// </summary>
        public bool ShowIcons { get; set; } = DefaultShowIcons;


        /// <summary>
        /// Determines how the toast closes. Defaults to <see cref="MBToastCloseMethod.TimeoutAndCloseButton"/>.
        /// </summary>
        public MBToastCloseMethod CloseMethod { get; set; } = DefaultCloseMethod;


        /// <summary>
        /// Timeout in milliseconds until the toast automatically closes. Defaults to 3000 and ignored if <see cref="MBToastServiceConfiguration.CloseMethod"/> is <see cref="MBToastCloseMethod.CloseButton"/>.
        /// </summary>
        public uint Timeout { get; set; } = DefaultTimeout;


        /// <summary>
        /// The maximum number of toasts that can be simultaneously shown. Further toasts are queued until others have been closed. Zero or negative means there is no limit.
        /// </summary>
        public int MaxToastsShowing { get; set; } = 0;


        /// <summary>
        /// Default heading for an Info toast.
        /// </summary>
        public string InfoDefaultHeading { get; set; } = "";


        /// <summary>
        /// Default heading for an Success toast.
        /// </summary>
        public string SuccessDefaultHeading { get; set; } = "";


        /// <summary>
        /// Default heading for an waWrning toast.
        /// </summary>
        public string WarningDefaultHeading { get; set; } = "";


        /// <summary>
        /// Default heading for an Error toast.
        /// </summary>
        public string ErrorDefaultHeading { get; set; } = "";


        /// <summary>
        /// Icon for an Info toast.
        /// </summary>
        public string InfoIconName { get; set; }


        /// <summary>
        /// Icon for an Success toast.
        /// </summary>
        public string SuccessIconName { get; set; }


        /// <summary>
        /// Icon for an warning toast.
        /// </summary>
        public string WarningIconName { get; set; }


        /// <summary>
        /// Icon for an Error toast.
        /// </summary>
        public string ErrorIconName { get; set; }


        /// <summary>
        /// Toast icon foundry.
        /// </summary>
        public IMBIconFoundry IconFoundry { get; set; }


        public MBToastServiceConfiguration()
        {
            InfoIconName = DefaultInfoIconName;
            SuccessIconName = DefaultSuccessIconName;
            WarningIconName = DefaultWarningIconName;
            ErrorIconName = DefaultErrorIconName;
        }
    }
}
