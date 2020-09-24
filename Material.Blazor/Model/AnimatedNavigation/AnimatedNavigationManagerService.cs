using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using System;

namespace Material.Blazor
{
    /// <summary>
    /// The internal implementation of <see cref="IMBAnimatedNavigationManager"/>.
    /// </summary>
    internal class AnimatedNavigationManagerService : IMBAnimatedNavigationManager
    {
        /// <summary>
        /// A reference to the registered <see cref="MBAnimatedNavigation"/>.
        /// </summary>
        internal MBAnimatedNavigation NavigationComponent { get; set; } = null;


        /// <inheritdoc/>
        public NavigationManager NavigationManager { get; set; }


        /// <inheritdoc/>
        public MBAnimatedNavigationManagerServiceConfiguration Configuration { get; set; } = new MBAnimatedNavigationManagerServiceConfiguration();


        /// <inheritdoc/>
        int IMBAnimatedNavigationManager.FadeOutTime => Configuration.AnimationTime * 4 / 10;


        /// <inheritdoc/>
        int IMBAnimatedNavigationManager.FadeInTime => Configuration.AnimationTime * 6 / 10;


        public AnimatedNavigationManagerService(NavigationManager navigationManager, MBAnimatedNavigationManagerServiceConfiguration configuration)
        {
            NavigationManager = navigationManager;
            Configuration = configuration;
        }


        /// <inheritdoc/>
        public void NavigateTo(string uri, bool forceLoad = false)
        {
            if (NavigationComponent is null)
            {
                throw new InvalidOperationException($"Material.Blazor: you have registered a {Utilities.GetTypeName(typeof(IMBAnimatedNavigationManager))} but have not placed a {Utilities.GetTypeName(typeof(MBAnimatedNavigation))} component around your markup in either App.razor or MainLayout.razor");
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
        void IMBAnimatedNavigationManager.RegisterNavigationComponent(MBAnimatedNavigation navigationComponent)
        {
            NavigationComponent = navigationComponent;
        }


        /// <inheritdoc/>
        void IMBAnimatedNavigationManager.DeregisterNavigationComponent(MBAnimatedNavigation navigationComponent)
        {
            if (navigationComponent.Equals(NavigationComponent))
            {
                NavigationComponent = null;
            }
        }
    }
}
