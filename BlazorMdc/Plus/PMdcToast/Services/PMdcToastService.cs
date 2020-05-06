//
//  2020-04-10  Mark Stega
//              Created from github.com/ChrisSainty/Blazored.Toast by Chris Sainty
//

using System;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Components;

namespace BlazorMdc
{
    public class PMdcToastService : IPmdcToastService
    {
        ///<inheritdoc/>
        public PMdcToastServiceConfiguration Configuration { get; set; } = new PMdcToastServiceConfiguration();

        private event Action<PMdcToastLevel, PMdcToastSettings> OnAdd;
        ///<inheritdoc/>
        event Action<PMdcToastLevel, PMdcToastSettings> IPmdcToastService.OnAdd
        {
            add => OnAdd += value;
            remove => OnAdd -= value;
        }


        public PMdcToastService(PMdcToastServiceConfiguration configuration)
        {
            Configuration = configuration;
        }

        ///<inheritdoc/>
#nullable enable annotations
        public void ShowToast(
            PMdcToastCloseMethod? closeMethod = null,
            string cssClass = null,
            string heading = null,
            string icon = null,
            PMdcToastLevel level = PMdcToastLevel.Info,
            string message = "",
            bool? showIcon = null,
            int timeout = -1)
#nullable restore annotations
        {
            var settings = new PMdcToastSettings();

            settings.CloseMethod = (closeMethod == null) ? Configuration.CloseMethod : closeMethod;
            settings.CssClass = cssClass;
            if (heading == null)
            {
                switch (level)
                {
                    case PMdcToastLevel.Error:
                        settings.Heading = Configuration.ErrorDefaultHeading;
                        break;

                    case PMdcToastLevel.Info:
                        settings.Heading = Configuration.InfoDefaultHeading;
                        break;

                    case PMdcToastLevel.Success:
                        settings.Heading = Configuration.SuccessDefaultHeading;
                        break;

                    case PMdcToastLevel.Warning:
                        settings.Heading = Configuration.WarningDefaultHeading;
                        break;
                }
            }
            else
            {
                settings.Heading = heading;
            }

            if (icon == null)
            {
                switch (level)
                {
                    case PMdcToastLevel.Error:
                        settings.Icon = Configuration.ErrorIcon;
                        break;

                    case PMdcToastLevel.Info:
                        settings.Icon = Configuration.InfoIcon;
                        break;

                    case PMdcToastLevel.Success:
                        settings.Icon = Configuration.SuccessIcon;
                        break;

                    case PMdcToastLevel.Warning:
                        settings.Icon = Configuration.WarningIcon;
                        break;
                }
            }
            else
            {
                settings.Icon = icon;
            }
            settings.Message = message;
            settings.ShowIcon = (showIcon == null) ? Configuration.ShowIcons : showIcon;
            settings.Timeout = (timeout <= 0) ? Configuration.Timeout : timeout;

            OnAdd?.Invoke(level, settings);
        }
    }
}
