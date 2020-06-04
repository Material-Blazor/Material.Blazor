using System;

namespace BMdcModel
{
    /// <summary>
    /// Settings for an individual toast notification determining all aspects controlling
    /// it's markup and behaviour. All parameters are optional with defaults defined in
    /// the <see cref="ToastServiceConfiguration"/> that you define when creating the toast service.
    /// </summary>
    public class ToastSettings
    {
#nullable enable annotations
        /// <summary>
        /// The heading - first line.
        /// </summary>
        public string Heading { get; set; }


        /// <summary>
        /// The message - second line.
        /// </summary>
        public string Message { get; set; }


        /// <summary>
        /// CSS class to be applied to the toast message.
        /// </summary>
        public string CssClass { get; set; }


        /// <summary>
        /// Determines whether to show the icon to the left.
        /// </summary>
        public bool? ShowIcon { get; set; }


        /// <summary>
        /// The icon's name.
        /// </summary>
        public string IconName { get; set; }


        /// <summary>
        /// The foundry to use for both leading and trailing icons.
        /// <para><c>IconFoundry="IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.OIIcon()"</c></para>
        /// </summary>
        public IIconFoundry? IconFoundry { get; set; }

        
        /// <summary>
        /// How the toast message gets closed. See <see cref="EToastCloseMethod"/>.
        /// </summary>
        public EToastCloseMethod? CloseMethod { get; set; }


        /// <summary>
        /// The toast's timeout in milliseconds.
        /// </summary>
        public uint? Timeout { get; set; }
#nullable restore annotations


        /// <summary>
        /// The toast service's configuration.
        /// </summary>
        internal ToastServiceConfiguration Configuration { get; set; }

        internal string AppliedHeading => Heading ?? ConfigHeading;

        internal string AppliedMessage => Message ?? "";

        internal string AppliedCssClass => CssClass ?? "";

        internal bool AppliedShowIcon => (AppliedIconName != null) && ((ShowIcon is null) ? Configuration?.ShowIcons ?? ToastServiceConfiguration.DefaultShowIcons : (bool)ShowIcon);

        internal string AppliedIconName => string.IsNullOrWhiteSpace(IconName) ? ConfigIconName : IconName;
        
        internal IIconFoundry AppliedIconFoundry => (IconFoundry is null) ? Configuration?.IconFoundry ?? new IconFoundryMI() : IconFoundry;

        internal EToastCloseMethod AppliedCloseMethod => (CloseMethod is null) ? Configuration?.CloseMethod ?? ToastServiceConfiguration.DefaultCloseMethod : (EToastCloseMethod)CloseMethod;

        internal uint AppliedTimeout => (Timeout is null) ? Configuration?.Timeout ?? ToastServiceConfiguration.DefaultTimeout : (uint)Timeout;


        /// <summary>
        /// The level of the toast. See <see cref="EToastLevel"/>.
        /// </summary>
        internal EToastLevel Level { get; set; }


        /// <summary>
        /// The current display status of the toast message driven by its CSS class.
        /// </summary>
        internal ToastStatus Status { get; set; }


        /// <summary>
        /// Default heading from the configuration, dependent upon <see cref="Level/>.
        /// </summary>
        internal string ConfigHeading => Level switch
        {
            EToastLevel.Error => Configuration?.ErrorDefaultHeading ?? "",
            EToastLevel.Info => Configuration?.InfoDefaultHeading ?? "",
            EToastLevel.Success => Configuration?.SuccessDefaultHeading ?? "",
            EToastLevel.Warning => Configuration?.WarningDefaultHeading ?? "",
            _ => throw new InvalidOperationException(),
        };


        /// <summary>
        /// Default icon from the configuration, dependent upon <see cref="Level/>.
        /// </summary>
        internal string ConfigIconName => Level switch
        {
            EToastLevel.Error => Configuration?.ErrorIconName ?? ToastServiceConfiguration.DefaultErrorIconName,
            EToastLevel.Info => Configuration?.InfoIconName ?? ToastServiceConfiguration.DefaultInfoIconName,
            EToastLevel.Success => Configuration?.SuccessIconName ?? ToastServiceConfiguration.DefaultSuccessIconName,
            EToastLevel.Warning => Configuration?.WarningIconName ?? ToastServiceConfiguration.DefaultWarningIconName,
            _ => throw new InvalidOperationException(),
        };


        /// <summary>
        /// CSS class to apply to the toast message driven by <see cref="Status"/>.
        /// </summary>
        internal string StatusClass => Status switch
        {
            ToastStatus.Show => "fade-in",
            ToastStatus.FadeOut => "fade-out",
            ToastStatus.Hide => "hide",
            _ => throw new InvalidOperationException(),
        };


        /// <summary>
        /// CSS class for the toast message driven by <see cref="Level"/>.
        /// </summary>
        internal string ContainerLevelClass => $"bmdc-toast__{Level.ToString().ToLower()}";
        

        /// <summary>
        /// CSS filter for the toast required for Material Icons Two-Tone theme.
        /// </summary>
        internal string IconFilterClass => $"{Level.ToString().ToLower()}-filter";
    }
}
