using System;

namespace Material.Blazor.Internal
{
    /// <summary>
    /// The internal implementation of <see cref="IMBToastService"/>.
    /// </summary>
    internal class ToastService : IMBToastService
    {
        private MBToastServiceConfiguration configuration = new MBToastServiceConfiguration();
        ///<inheritdoc/>
        public MBToastServiceConfiguration Configuration
        { 
            get => configuration; 
            set
            { 
                configuration = value;
                configuration.OnValueChanged += ConfigurationChanged;
                OnTriggerStateHasChanged?.Invoke(); 
            }
        }


        private event Action<MBToastLevel, MBToastSettings> OnAdd;
        private event Action OnTriggerStateHasChanged;

        ///<inheritdoc/>
        event Action<MBToastLevel, MBToastSettings> IMBToastService.OnAdd
        {
            add => OnAdd += value;
            remove => OnAdd -= value;
        }


        ///<inheritdoc/>
        event Action IMBToastService.OnTriggerStateHasChanged
        {
            add => OnTriggerStateHasChanged += value;
            remove => OnTriggerStateHasChanged -= value;
        }


        public ToastService(MBToastServiceConfiguration configuration)
        {
            Configuration = configuration;
        }

        private void ConfigurationChanged() => OnTriggerStateHasChanged?.Invoke();


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
            uint? timeout = null,
            bool debug = false)
#nullable restore annotations
        {
#if !DEBUG
            if (debug)
            {
                return;
            }
#endif

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
                throw new InvalidOperationException($"Material.Blazor: you attempted to show a toast notification from a {Utilities.GetTypeName(typeof(IMBToastService))} but have not placed a {Utilities.GetTypeName(typeof(MBAnchor))} component at the top of either App.razor or MainLayout.razor");
            }

            OnAdd?.Invoke(level, settings);
        }
    }
}
