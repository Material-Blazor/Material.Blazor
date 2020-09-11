using System;

namespace Material.Blazor.Internal
{
    /// <summary>
    /// The internal implementation of <see cref="IMBToastService"/>.
    /// </summary>
    internal class ToastService : IMBToastService
    {
        ///<inheritdoc/>
        public MBToastServiceConfiguration Configuration { get; set; } = new MBToastServiceConfiguration();

        private event Action<MBToastLevel, MBToastSettings> OnAdd;

        ///<inheritdoc/>
        event Action<MBToastLevel, MBToastSettings> IMBToastService.OnAdd
        {
            add => OnAdd += value;
            remove => OnAdd -= value;
        }


        public ToastService(MBToastServiceConfiguration configuration)
        {
            Configuration = configuration;
        }

        ///<inheritdoc/>
#nullable enable annotations
        public void ShowToast(
            MBToastLevel level,
            string message,
            string heading = null,
            MBToastCloseMethod? closeMethod = null,
            string cssClass = null,
            string iconName = null,
            IMBIconFoundry? iconFoundry = null,
            bool? showIcon = null,
            uint? timeout = null)
#nullable restore annotations
        {
            var settings = new MBToastSettings()
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
                throw new InvalidOperationException($"BlazorMdc: you attempted to show a toast notification from a {Utilities.GetTypeName(typeof(IMBToastService))} but have not placed a {Utilities.GetTypeName(typeof(MBToastAnchor))} component at the top of either App.razor or MainLayout.razor");
            }

            OnAdd?.Invoke(level, settings);
        }
    }
}
