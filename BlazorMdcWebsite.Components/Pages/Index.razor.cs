using BlazorMdc;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace BlazorMdcWebsite.Components.Pages
{
    public partial class Index
    {
        [Inject] IJSRuntime JsRuntime { get; set; }
        [Inject] IMTAnimatedNavigationManager AnimatedNavigationManager { get; set; }

#if DEBUG
        private string BuildMode { get; set; } = "debug";
#else
        private string BuildMode { get; set; } = "release";
#endif

        private string OSArchitecture { get; set; }
        private string OSDescription { get; set; }
        private string Runtime { get; set; }
        private string BaseURI { get; set; }

        private string DocsTarget
        {
            get
            {
                return BaseURI + "docs";
            }
        }

        public Index()
        {
            OSArchitecture = RuntimeInformation.OSArchitecture.ToString();
            OSDescription = RuntimeInformation.OSDescription.ToString();
            Runtime = RuntimeInformation.FrameworkDescription.ToString();
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            BaseURI = (string) await JsRuntime.InvokeAsync<object>("BlazorMdcWebsite.baseHref.getBaseURI");
        }



        private void NavigateToDocs()
        {
            AnimatedNavigationManager.NavigateTo($"{BaseURI}docs", true);
        }



        private void NavigateToButton()
        {
            AnimatedNavigationManager.NavigateTo("button");
        }
    }
}
