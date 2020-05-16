//
//  2020-04-10  Mark Stega
//              Created from github.com/ChrisSainty/Blazored.Toast by Chris Sainty
//

using Microsoft.AspNetCore.Components;
using System;
using System.Security.Cryptography.X509Certificates;

namespace BlazorMdc
{
    public class PMdcToastSettings
    {
#nullable enable annotations
        public string Heading { get; set; }

        public string Message { get; set; }

        public string CssClass { get; set; }

        public bool? ShowIcon { get; set; }

        public string IconName { get; set; }

        public IMdcIconFoundry? IconFoundry { get; set; }

        public PMdcToastCloseMethod? CloseMethod { get; set; }

        public uint? Timeout { get; set; }
#nullable restore annotations



        internal PMdcToastServiceConfiguration Configuration { get; set; }

        internal string AppliedHeading => Heading ?? ConfigHeading;

        internal string AppliedMessage => Message ?? "";

        internal string AppliedCssClass => CssClass ?? "";

        internal bool AppliedShowIcon => (AppliedIconName != null) && ((ShowIcon is null) ? Configuration?.ShowIcons ?? PMdcToastServiceConfiguration.DefaultShowIcons : (bool)ShowIcon);

        internal string AppliedIconName => string.IsNullOrWhiteSpace(IconName) ? ConfigIconName : IconName;
        
        internal IMdcIconFoundry AppliedIconFoundry => (IconFoundry is null) ? Configuration?.IconFoundry ?? new IconFoundryMI() : IconFoundry;

        internal PMdcToastCloseMethod AppliedCloseMethod => (CloseMethod is null) ? Configuration?.CloseMethod ?? PMdcToastServiceConfiguration.DefaultCloseMethod : (PMdcToastCloseMethod)CloseMethod;

        internal uint AppliedTimeout => (Timeout is null) ? Configuration?.Timeout ?? PMdcToastServiceConfiguration.DefaultTimeout : (uint)Timeout;



        internal PMdcToastLevel Level { get; set; }

        internal ToastStatus Status { get; set; }


        internal string ConfigHeading => Level switch
        {
            PMdcToastLevel.Error => Configuration?.ErrorDefaultHeading ?? "",
            PMdcToastLevel.Info => Configuration?.InfoDefaultHeading ?? "",
            PMdcToastLevel.Success => Configuration?.SuccessDefaultHeading ?? "",
            PMdcToastLevel.Warning => Configuration?.WarningDefaultHeading ?? "",
            _ => throw new InvalidOperationException(),
        };

        internal string ConfigIconName => Level switch
        {
            PMdcToastLevel.Error => Configuration?.ErrorIconName ?? Configuration.DefaultErrorIconName,
            PMdcToastLevel.Info => Configuration?.InfoIconName ?? Configuration.DefaultInfoIconName,
            PMdcToastLevel.Success => Configuration?.SuccessIconName ?? Configuration.DefaultSuccessIconName,
            PMdcToastLevel.Warning => Configuration?.WarningIconName ?? Configuration.DefaultWarningIconName,
            _ => throw new InvalidOperationException(),
        };

        internal string StatusClass => Status switch
        {
            ToastStatus.Show => "fade-in",
            ToastStatus.FadeOut => "fade-out",
            ToastStatus.Hide => "hide",
            _ => throw new InvalidOperationException(),
        };

        internal string ContainerLevelClass => $"bmdc-toast__{Level.ToString().ToLower()}";
        
        internal string IconFilterClass => $"{Level.ToString().ToLower()}-filter";
    }
}
