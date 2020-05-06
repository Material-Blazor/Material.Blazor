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
            settings.Heading = heading;
            settings.Icon = icon;
            settings.Message = message;
            settings.ShowIcon = (showIcon == null) ? Configuration.ShowIcons : showIcon;
            settings.Timeout = (timeout <= 0) ? Configuration.Timeout : timeout;

            OnAdd?.Invoke(level, settings);
        }
    }
}
