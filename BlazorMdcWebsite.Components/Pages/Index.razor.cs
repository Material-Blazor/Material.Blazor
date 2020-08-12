using BlazorMdc;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace BlazorMdcWebsite.Components.Pages
{
    public partial class Index
    {
        [Inject] IJSRuntime JSRuntime { get; set; }
        [Inject] IMTAnimatedNavigationManager ANManager { get; set; }

#if DEBUG
        private string BuildMode { get; set; } = "debug";
#else
        private string BuildMode { get; set; } = "release";
#endif

        private string OSArchitecture { get; set; }
        private string OSDescription { get; set; }
        private string Runtime { get; set; }

        public Index()
        {
            OSArchitecture = RuntimeInformation.OSArchitecture.ToString();
            OSDescription = RuntimeInformation.OSDescription.ToString();
            Runtime = RuntimeInformation.FrameworkDescription.ToString();
        }

        private async Task NavigateToDocsAsync()
        {
            await JSRuntime.InvokeAsync<object>("open", "https://docs.blazormdc.com", "_blank");
        }



        private void NavigateToButton()
        {
            ANManager.NavigateTo("/button");
        }
    }
}
