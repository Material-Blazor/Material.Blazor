﻿//
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

        public string? Icon { get; set; }

        public PMdcToastCloseMethod? CloseMethod { get; set; }

        public int? Timeout { get; set; }
#nullable restore annotations



        internal PMdcToastServiceConfiguration Configuration { get; set; }

        internal string AppliedHeading => Heading ?? ConfigHeading;

        internal string AppliedMessage => Message ?? "";

        internal string AppliedCssClass => CssClass ?? "";

        internal bool AppliedShowIcon => !string.IsNullOrWhiteSpace(AppliedIcon) && ((ShowIcon is null) ? Configuration?.ShowIcons ?? PMdcToastServiceConfiguration.DefaultShowIcons : (bool)ShowIcon);

        internal string AppliedIcon => (Icon is null) ? ConfigIcon : (string)Icon;

        internal PMdcToastCloseMethod AppliedCloseMethod => (CloseMethod is null) ? Configuration?.CloseMethod ?? PMdcToastServiceConfiguration.DefaultCloseMethod : (PMdcToastCloseMethod)CloseMethod;

        internal int AppliedTimeout => (Timeout is null) ? Configuration?.Timeout ?? PMdcToastServiceConfiguration.DefaultTimeout : (int)Timeout;



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

        internal string ConfigIcon => Level switch
        {
            PMdcToastLevel.Error => Configuration?.ErrorIcon ?? PMdcToastServiceConfiguration.DefaultErrorIcon,
            PMdcToastLevel.Info => Configuration?.InfoIcon ?? PMdcToastServiceConfiguration.DefaultInfoIcon,
            PMdcToastLevel.Success => Configuration?.SuccessIcon ?? PMdcToastServiceConfiguration.DefaultSuccessIcon,
            PMdcToastLevel.Warning => Configuration?.WarningIcon ?? PMdcToastServiceConfiguration.DefaultWarningIcon,
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
