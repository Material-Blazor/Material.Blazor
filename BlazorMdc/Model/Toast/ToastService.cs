using System;

namespace BlazorMdc.Internal
{
    /// <summary>
    /// The internal implementation of <see cref="IMTToastService"/>.
    /// </summary>
    internal class ToastService : IMTToastService
    {
        ///<inheritdoc/>
        public MTToastServiceConfiguration Configuration { get; set; } = new MTToastServiceConfiguration();

        private event Action<MTToastLevel, MTToastSettings> OnAdd;

        ///<inheritdoc/>
        event Action<MTToastLevel, MTToastSettings> IMTToastService.OnAdd
        {
            add => OnAdd += value;
            remove => OnAdd -= value;
        }


        public ToastService(MTToastServiceConfiguration configuration)
        {
            Configuration = configuration;
        }

        ///<inheritdoc/>
#nullable enable annotations
        public void ShowToast(
            MTToastLevel level,
            string message,
            string heading = null,
            MTToastCloseMethod? closeMethod = null,
            string cssClass = null,
            string iconName = null,
            IMTIconFoundry? iconFoundry = null,
            bool? showIcon = null,
            uint? timeout = null)
#nullable restore annotations
        {
            var settings = new MTToastSettings()
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
                throw new InvalidOperationException($"BlazorMdc: you attempted to show a toast notification from a {Utilities.GetTypeName(typeof(IMTToastService))} but have not placed a {Utilities.GetTypeName(typeof(MTToastAnchor))} component at the top of either App.razor or MainLayout.razor");
            }

            OnAdd?.Invoke(level, settings);
        }
    }
}
