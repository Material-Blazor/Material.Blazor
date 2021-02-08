using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Material.Blazor
{
    /// <summary>
    /// This component works with <see cref="IMBAnimatedNavigationManager"/> to navigate your page navigation.
    /// Place this component around your app's entire @Body render fragment (potentially in MainLayout.razor),
    /// but not surrounding your app bars and navigation menus - you don't want those to fade in and out when
    /// your user navigates from one page to another.
    /// </summary>
    public partial class MBAnimatedNavigation : ComponentFoundation
    {
        [Inject] private IMBAnimatedNavigationManager AnimatedNavigationService { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }


        /// <summary>
        /// This is potentially your @Body in MainLayout.razor.
        /// </summary>
        [Parameter] public RenderFragment ChildContent { get; set; }


        private const string FadeIn = "mb-navigation-fade-in";
        private const string FadeOut = "mb-navigation-fade-out";


        private MarkupString FadeInAnimation => (MarkupString)$"animation: mbNavFadeIn ease {AnimatedNavigationService.FadeInTime * 10:D}ms;";
        private MarkupString FadeInAnimationWebkit => (MarkupString)$"-webkit-animation: mbNavFadeIn ease {AnimatedNavigationService.FadeInTime * 10:D}ms;";

        private MarkupString FadeOutAnimation => (MarkupString)$"animation: mbNavFadeOut ease {AnimatedNavigationService.FadeOutTime * 10:D}ms;";
        private MarkupString FadeOutAnimationWebkit => (MarkupString)$"-webkit-animation: mbNavFadeOut ease {AnimatedNavigationService.FadeOutTime * 10:D}ms;";


        private string PageClass { get; set; } = "";


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            AnimatedNavigationService.RegisterNavigationComponent(this);
        }


        private bool _disposed = false;
        protected override void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                AnimatedNavigationService.DeregisterNavigationComponent(this);
            }

            _disposed = true;

            base.Dispose(disposing);
        }


        internal void NavigateTo(string uri, bool forceLoad = false)
        {
            InvokeAsync(async () =>
            {
                PageClass = FadeOut;
                await Task.Delay(AnimatedNavigationService.FadeOutTime);
                NavigationManager.NavigateTo(uri, forceLoad);
                PageClass = FadeIn;
            });
        }


        /// <summary>
        /// Stops page animation.
        /// </summary>
        internal void UnanimatePage()
        {
            PageClass = "";
        }
    }
}
