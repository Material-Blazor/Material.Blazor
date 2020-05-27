using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// This component works with <see cref="IPMdcAnimatedNavigationManager"/> to navigate your page navigation.
    /// Place this component around your app's entire @Body render fragment (potentially in MainLayout.razor),
    /// but not surrounding your app bars and navigation menus - you don't want those to fade in and out when
    /// your user navigates from one page to another.
    /// </summary>
    public partial class PMdcAnimatedNavigation: Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        [Inject] private IPMdcAnimatedNavigationManager PMdcAnimatedNavigationManager { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }


        /// <summary>
        /// This is potentially your @Body in MainLayout.razor.
        /// </summary>
        [Parameter] public RenderFragment ChildContent { get; set; }


        private const string FadeIn = "bmdc-navigation-fade-in";
        private const string FadeOut = "bmdc-navigation-fade-out";


        private MarkupString FadeInAnimation => (MarkupString)$"animation: bmdcNavFadeIn ease {(PMdcAnimatedNavigationManager.FadeOutTime * 10).ToString("D")}ms;";
        private MarkupString FadeInAnimationWebkit => (MarkupString)$"-webkit-animation: bmdcNavFadeIn ease {(PMdcAnimatedNavigationManager.FadeOutTime * 10).ToString("D")}ms;";

        private MarkupString FadeOutAnimation => (MarkupString)$"animation: bmdcNavFadeOut ease {(PMdcAnimatedNavigationManager.FadeOutTime * 10).ToString("D")}ms;";
        private MarkupString FadeOutAnimationWebkit => (MarkupString)$"-webkit-animation: bmdcNavFadeOut ease {(PMdcAnimatedNavigationManager.FadeOutTime * 10).ToString("D")}ms;";


        private string PageClass { get; set; } = "";


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            PMdcAnimatedNavigationManager.RegisterNavigationComponent(this);
        }


        /// <inheritdoc/>
        public void Dispose()
        {
            PMdcAnimatedNavigationManager.DeregisterNavigationComponent(this);
        }


        internal void NavigateTo(string uri, bool forceLoad = false)
        {
            InvokeAsync(async () =>
            {
                _ = await FadePageOutAsync().ConfigureAwait(false);

                NavigationManager.NavigateTo(uri, forceLoad);

                _ = await FadePageInAsync().ConfigureAwait(false);
            });
        }


        private async Task<object> FadePageInAsync()
        {
            PageClass = FadeIn;
            StateHasChanged();

            await Task.CompletedTask;

            return null;
        }


        private async Task<object> FadePageOutAsync()
        {
            PageClass = FadeOut;
            StateHasChanged();

            await Task.CompletedTask;

            await Task.Delay(PMdcAnimatedNavigationManager.FadeOutTime);

            return null;
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
