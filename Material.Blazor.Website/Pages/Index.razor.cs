using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Material.Blazor.Website.Pages
{
    public partial class Index
    {
        [Inject] IJSRuntime JsRuntime { get; set; }
        [Inject] IMBAnimatedNavigationManager AnimatedNavigationManager { get; set; }

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
            Version = MBVersion.MaterialBlazorVersion();
        }


        private void NavigateToDocs()
        {
            var baseURI = AnimatedNavigationManager.NavigationManager.BaseUri;
            AnimatedNavigationManager.NavigateTo($"{baseURI}docs", true);
        }



        private void NavigateToButton()
        {
            AnimatedNavigationManager.NavigateTo("button");
        }
    }
}
