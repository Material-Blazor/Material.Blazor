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
            PMdcToastLevel level,
            string message,
            string heading = null,
            PMdcToastCloseMethod? closeMethod = null,
            string cssClass = null,
            MdcIconHelper? icon = null,
            bool? showIcon = null,
            uint? timeout = null)
#nullable restore annotations
        {
            var settings = new PMdcToastSettings()
            {
                Message = message,
                Heading = heading,
                CloseMethod = closeMethod,
                CssClass = cssClass,
                Icon = icon,
                ShowIcon = showIcon,
                Timeout = timeout
            };

            OnAdd?.Invoke(level, settings);
        }
    }
}
