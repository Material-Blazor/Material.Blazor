using BMdcFoundation;

using BMdcPlus;

using System;

namespace BMdcModel
{
    /// <summary>
    /// The internal implementation of <see cref="IToastService"/>.
    /// </summary>
    internal class ToastService : IToastService
    {
        ///<inheritdoc/>
        public ToastServiceConfiguration Configuration { get; set; } = new ToastServiceConfiguration();

        private event Action<EToastLevel, ToastSettings> OnAdd;

        ///<inheritdoc/>
        event Action<EToastLevel, ToastSettings> IToastService.OnAdd
        {
            add => OnAdd += value;
            remove => OnAdd -= value;
        }


        public ToastService(ToastServiceConfiguration configuration)
        {
            Configuration = configuration;
        }

        ///<inheritdoc/>
#nullable enable annotations
        public void ShowToast(
            EToastLevel level,
            string message,
            string heading = null,
            EToastCloseMethod? closeMethod = null,
            string cssClass = null,
            string iconName = null,
            IIconFoundry? iconFoundry = null,
            bool? showIcon = null,
            uint? timeout = null)
#nullable restore annotations
        {
            var settings = new ToastSettings()
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
                throw new InvalidOperationException($"BlazorMdc: you attempted to show a toast notification from a {Utilities.GetTypeName(typeof(IToastService))} but have not placed a {Utilities.GetTypeName(typeof(ToastAnchor))} component at the top of either App.razor or MainLayout.razor");
            }

            OnAdd?.Invoke(level, settings);
        }
    }
}
