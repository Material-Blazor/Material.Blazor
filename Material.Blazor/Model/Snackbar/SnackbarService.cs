using System;

namespace Material.Blazor.Internal
{
    /// <summary>
    /// The internal implementation of <see cref="IMBSnackbarService"/>.
    /// </summary>
    internal class SnackbarService : IMBSnackbarService
    {
        private MBSnackbarServiceConfiguration configuration = new ();

        ///<inheritdoc/>
        public MBSnackbarServiceConfiguration Configuration
        {
            get => configuration;
            set
            {
                configuration = value;
                configuration.OnValueChanged += ConfigurationChanged;
                OnTriggerStateHasChanged?.Invoke();
            }
        }


        private event Action<MBSnackbarSettings> OnAdd;
        private event Action OnTriggerStateHasChanged;


        ///<inheritdoc/>
        event Action<MBSnackbarSettings> IMBSnackbarService.OnAdd
        {
            add => OnAdd += value;
            remove => OnAdd -= value;
        }


        ///<inheritdoc/>
        event Action IMBSnackbarService.OnTriggerStateHasChanged
        {
            add => OnTriggerStateHasChanged += value;
            remove => OnTriggerStateHasChanged -= value;
        }


        public SnackbarService(MBSnackbarServiceConfiguration configuration)
        {
            Configuration = configuration;
        }


        private void ConfigurationChanged() => OnTriggerStateHasChanged?.Invoke();


        ///<inheritdoc/>
#nullable enable annotations
        public void ShowSnackbar(
            string message,
            Action action = null,
            string actionText = null,
            bool dismissIcon = true,
            bool leading = false,
            bool stacked = false,
            int? timeout = null,
            bool debug = false)
#nullable restore annotations
        {
#if !DEBUG
            if (debug)
            {
                return;
            }
#endif

            var settings = new MBSnackbarSettings()
            {
                Action = action,
                Message = message,
                ActionText = actionText,
                DismissIcon = dismissIcon,
                Leading = leading,
                Stacked = stacked,
                Timeout = timeout
            };

            if (OnAdd is null)
            {
                throw new InvalidOperationException($"Material.Blazor: you attempted to show a snackbar notification from a {Utilities.GetTypeName(typeof(IMBSnackbarService))} but have not placed a {Utilities.GetTypeName(typeof(MBAnchor))} component at the top of either App.razor or MainLayout.razor");
            }

            OnAdd?.Invoke(settings);
        }
    }
}
