//
//  2020-04-10  Mark Stega
//              Created from github.com/ChrisSainty/Blazored.Toast by Chris Sainty
//

using System;

namespace BlazorMdc
{
    /// <summary>
    /// The internal implementation of <see cref="IPmdcToastService"/>.
    /// </summary>
    internal class PMdcToastService : IPmdcToastService
    {
        ///<inheritdoc/>
        public PMdcToastServiceConfiguration Configuration { get; set; } = new PMdcToastServiceConfiguration();

        private event Action<BEnum.ToastLevel, PMdcToastSettings> OnAdd;

        ///<inheritdoc/>
        event Action<BEnum.ToastLevel, PMdcToastSettings> IPmdcToastService.OnAdd
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
            BEnum.ToastLevel level,
            string message,
            string heading = null,
            BEnum.ToastCloseMethod? closeMethod = null,
            string cssClass = null,
            string iconName = null,
            BModel.IIconFoundry? iconFoundry = null,
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
                IconName = iconName,
                IconFoundry = iconFoundry,
                ShowIcon = showIcon,
                Timeout = timeout
            };

            if (OnAdd is null)
            {
                throw new InvalidOperationException($"BlazorMdc: you attempted to show a toast notification from a {BBase.Utilities.GetTypeName(typeof(IPmdcToastService))} but have not placed a {BBase.Utilities.GetTypeName(typeof(PMdcToastAnchor))} component at the top of either App.razor or MainLayout.razor");
            }

            OnAdd?.Invoke(level, settings);
        }
    }
}
