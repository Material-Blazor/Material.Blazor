using Material.Blazor.Internal;

using System;

namespace Material.Blazor
{
    /// <summary>
    /// Settings for an individual toast notification determining all aspects controlling
    /// it's markup and behaviour. All parameters are optional with defaults defined in
    /// the <see cref="MBToastServiceConfiguration"/> that you define when creating the toast service.
    /// </summary>
    public class MBToastSettings
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
        public IMBIconFoundry? IconFoundry { get; set; }


        /// <summary>
        /// How the toast message gets closed. See <see cref="MBToastCloseMethod"/>.
        /// </summary>
        public MBToastCloseMethod? CloseMethod { get; set; }


        /// <summary>
        /// The toast's timeout in milliseconds.
        /// </summary>
        public uint? Timeout { get; set; }
#nullable restore annotations


        /// <summary>
        /// The toast service's configuration.
        /// </summary>
        internal MBToastServiceConfiguration Configuration { get; set; }

        internal string AppliedHeading => Heading ?? ConfigHeading;

        internal string AppliedMessage => Message ?? "";

        internal string AppliedCssClass => CssClass ?? "";

        internal bool AppliedShowIcon => (AppliedIconName != null) && ((ShowIcon is null) ? Configuration?.ShowIcons ?? MBToastServiceConfiguration.DefaultShowIcons : (bool)ShowIcon);

        internal string AppliedIconName => string.IsNullOrWhiteSpace(IconName) ? ConfigIconName : IconName;

        internal IMBIconFoundry AppliedIconFoundry => (IconFoundry is null) ? Configuration?.IconFoundry ?? new IconFoundryMI() : IconFoundry;

        internal MBToastCloseMethod AppliedCloseMethod => (CloseMethod is null) ? Configuration?.CloseMethod ?? MBToastServiceConfiguration.DefaultCloseMethod : (MBToastCloseMethod)CloseMethod;

        internal uint AppliedTimeout => (Timeout is null) ? Configuration?.Timeout ?? MBToastServiceConfiguration.DefaultTimeout : (uint)Timeout;


        /// <summary>
        /// The level of the toast. See <see cref="MBToastLevel"/>.
        /// </summary>
        internal MBToastLevel Level { get; set; }


        /// <summary>
        /// The current display status of the toast message driven by its CSS class.
        /// </summary>
        internal ToastStatus Status { get; set; }


        /// <summary>
        /// Default heading from the configuration, dependent upon <see cref="Level/>.
        /// </summary>
        internal string ConfigHeading => Level switch
        {
            MBToastLevel.Error => Configuration?.ErrorDefaultHeading ?? "",
            MBToastLevel.Info => Configuration?.InfoDefaultHeading ?? "",
            MBToastLevel.Success => Configuration?.SuccessDefaultHeading ?? "",
            MBToastLevel.Warning => Configuration?.WarningDefaultHeading ?? "",
            _ => throw new InvalidOperationException(),
        };


        /// <summary>
        /// Default icon from the configuration, dependent upon <see cref="Level/>.
        /// </summary>
        internal string ConfigIconName => Level switch
        {
            MBToastLevel.Error => Configuration?.ErrorIconName ?? MBToastServiceConfiguration.DefaultErrorIconName,
            MBToastLevel.Info => Configuration?.InfoIconName ?? MBToastServiceConfiguration.DefaultInfoIconName,
            MBToastLevel.Success => Configuration?.SuccessIconName ?? MBToastServiceConfiguration.DefaultSuccessIconName,
            MBToastLevel.Warning => Configuration?.WarningIconName ?? MBToastServiceConfiguration.DefaultWarningIconName,
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
        internal string ContainerLevelClass => $"mb-toast__{Level.ToString().ToLower()}";


        /// <summary>
        /// CSS filter for the toast required for Material Icons Two-Tone theme.
        /// </summary>
        internal string IconFilterClass => $"{Level.ToString().ToLower()}-filter";
    }
}
