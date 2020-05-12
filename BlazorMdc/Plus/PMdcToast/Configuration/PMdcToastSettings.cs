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

        public MdcIcon Icon { get; set; }

        public IMdcIconFoundry IconFoundry { get; set; }

        public PMdcToastCloseMethod? CloseMethod { get; set; }

        public uint? Timeout { get; set; }
#nullable restore annotations



        internal PMdcToastServiceConfiguration Configuration { get; set; }

        internal string AppliedHeading => Heading ?? ConfigHeading;

        internal string AppliedMessage => Message ?? "";

        internal string AppliedCssClass => CssClass ?? "";

        internal bool AppliedShowIcon => (AppliedIcon != null) && ((ShowIcon is null) ? Configuration?.ShowIcons ?? PMdcToastServiceConfiguration.DefaultShowIcons : (bool)ShowIcon);

        internal MdcIcon AppliedIcon => (Icon is null) ? ConfigIcon : Icon;

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

        internal MdcIcon ConfigIcon => Level switch
        {
            PMdcToastLevel.Error => Configuration?.ErrorIcon ?? Configuration.DefaultErrorIcon,
            PMdcToastLevel.Info => Configuration?.InfoIcon ?? Configuration.DefaultInfoIcon,
            PMdcToastLevel.Success => Configuration?.SuccessIcon ?? Configuration.DefaultSuccessIcon,
            PMdcToastLevel.Warning => Configuration?.WarningIcon ?? Configuration.DefaultWarningIcon,
            _ => throw new InvalidOperationException(),
        };

        internal string StatusClass => Status switch
        {
            ToastStatus.Show => "fade-in",
            ToastStatus.FadeOut => "fade-out",
            ToastStatus.Hide => "hide",
            _ => throw new InvalidOperationException(),
        };

        internal string LevelClass => $"bmdc-toast__{Level.ToString().ToLower()}";
    }
}
