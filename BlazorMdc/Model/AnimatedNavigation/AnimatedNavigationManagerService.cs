using BlazorMdc.Internal;
using Microsoft.AspNetCore.Components;
using System;

namespace BlazorMdc
{
    /// <summary>
    /// The internal implementation of <see cref="IMTAnimatedNavigationManager"/>.
    /// </summary>
    internal class AnimatedNavigationManagerService : IMTAnimatedNavigationManager
    {
        /// <summary>
        /// The Blazor <see cref="NavigationManager"/>.
        /// </summary>
        public NavigationManager NavigationManager { get; private set; }


        /// <summary>
        /// A reference to the registered <see cref="MTAnimatedNavigation"/>.
        /// </summary>
        internal MTAnimatedNavigation NavigationComponent { get; set; } = null;
        

        /// <inheritdoc/>
        public MTAnimatedNavigationManagerServiceConfiguration Configuration { get; set; } = new MTAnimatedNavigationManagerServiceConfiguration();


        /// <inheritdoc/>
        int IMTAnimatedNavigationManager.FadeOutTime => Configuration.AnimationTime * 4 / 10;


        /// <inheritdoc/>
        int IMTAnimatedNavigationManager.FadeInTime => Configuration.AnimationTime * 6 / 10;


        public AnimatedNavigationManagerService(NavigationManager navigationManager, MTAnimatedNavigationManagerServiceConfiguration configuration)
        {
            NavigationManager = navigationManager;
            Configuration = configuration;
        }


        /// <inheritdoc/>
        public void NavigateTo(string uri, bool forceLoad = false)
        {
            if (NavigationComponent is null)
            {
                throw new InvalidOperationException($"BlazorMdc: you have registered a {Utilities.GetTypeName(typeof(IMTAnimatedNavigationManager))} but have not placed a {Utilities.GetTypeName(typeof(MTAnimatedNavigation))} component around your markup in either App.razor or MainLayout.razor");
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
        void IMTAnimatedNavigationManager.RegisterNavigationComponent(MTAnimatedNavigation navigationComponent)
        {
            NavigationComponent = navigationComponent;
        }


        /// <inheritdoc/>
        void IMTAnimatedNavigationManager.DeregisterNavigationComponent(MTAnimatedNavigation navigationComponent)
        {
            if (navigationComponent.Equals(NavigationComponent))
            {
                NavigationComponent = null;
            }
        }
    }
}
