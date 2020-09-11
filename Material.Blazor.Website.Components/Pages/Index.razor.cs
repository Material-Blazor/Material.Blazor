using Material.Blazor;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Material.Blazor.Website.Components.Pages
{
    public partial class Index
    {
        [Inject] IJSRuntime JsRuntime { get; set; }
        [Inject] IMBAnimatedNavigationManager AnimatedNavigationService { get; set; }

#if DEBUG
        private string BuildMode { get; set; } = "debug";
#else
        private string BuildMode { get; set; } = "release";
#endif

        private string OSArchitecture { get; set; }
        private string OSDescription { get; set; }
        private string Runtime { get; set; }
        private string Version { get; set; }

        public Index()
        {
            OSArchitecture = RuntimeInformation.OSArchitecture.ToString();
            OSDescription = RuntimeInformation.OSDescription.ToString();
            Runtime = RuntimeInformation.FrameworkDescription.ToString();
            Version = MBVersion.BlazorMdcVersion();
        }


        private async Task NavigateToDocsAsync()
        {
            var baseURI = await JsRuntime.InvokeAsync<object>("BlazorMdcWebsite.baseHref.getBaseURI");
            AnimatedNavigationService.NavigateTo($"{baseURI}docs", true);
        }



        private void NavigateToButton()
        {
            AnimatedNavigationService.NavigateTo("button");
        }
    }
}
