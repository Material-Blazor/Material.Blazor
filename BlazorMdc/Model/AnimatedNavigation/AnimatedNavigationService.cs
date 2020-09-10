using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;

using System;

namespace BlazorMdc
{
    /// <summary>
    /// The internal implementation of <see cref="IMTAnimatedNavigationService"/>.
    /// </summary>
    internal class AnimatedNavigationService : IMTAnimatedNavigationService
    {
        private readonly NavigationManager NavigationManager;


        /// <summary>
        /// A reference to the registered <see cref="MTAnimatedNavigation"/>.
        /// </summary>
        internal MTAnimatedNavigation NavigationComponent { get; set; } = null;
        

        /// <inheritdoc/>
        public MTAnimatedNavigationServiceConfiguration Configuration { get; set; } = new MTAnimatedNavigationServiceConfiguration();


        /// <inheritdoc/>
        int IMTAnimatedNavigationService.FadeOutTime => Configuration.AnimationTime * 4 / 10;


        /// <inheritdoc/>
        int IMTAnimatedNavigationService.FadeInTime => Configuration.AnimationTime * 6 / 10;


        public AnimatedNavigationService(NavigationManager navigationManager, MTAnimatedNavigationServiceConfiguration configuration)
        {
            NavigationManager = navigationManager;
            Configuration = configuration;
        }


        /// <inheritdoc/>
        public void NavigateTo(string uri, bool forceLoad = false)
        {
            if (NavigationComponent is null)
            {
                throw new InvalidOperationException($"BlazorMdc: you have registered a {Utilities.GetTypeName(typeof(IMTAnimatedNavigationService))} but have not placed a {Utilities.GetTypeName(typeof(MTAnimatedNavigation))} component around your markup in either App.razor or MainLayout.razor");
            }

            if (!Configuration.ApplyAnimation)
            {
                NavigationManager.NavigateTo(uri, forceLoad);
            }
            else
            {
                NavigationComponent.NavigateTo(uri, forceLoad);
            }
        }


        /// <inheritdoc/>
        void IMTAnimatedNavigationService.RegisterNavigationComponent(MTAnimatedNavigation navigationComponent)
        {
            NavigationComponent = navigationComponent;
        }


        /// <inheritdoc/>
        void IMTAnimatedNavigationService.DeregisterNavigationComponent(MTAnimatedNavigation navigationComponent)
        {
            if (navigationComponent.Equals(NavigationComponent))
            {
                NavigationComponent = null;
            }
        }
    }
}
