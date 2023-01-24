using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Material.Blazor.Website.Pages;

public partial class Index
{
    [Inject] private NavigationManager NavigationManager { get; set; }
    [Inject] private IJSRuntime JSRuntime { get; set; }

#if MD2Server
    private string BuildMode { get; set; } = "MD2Server";
#endif
#if MD2WASM
    private string BuildMode { get; set; } = "MD2WASM";
#endif
#if MD3Server
    private string BuildMode { get; set; } = "MD3Server";
#endif
#if MD3WASM
    private string BuildMode { get; set; } = "MD3WASM";
#endif

#if MD2Server || MD2WASM
    private string MaterialMode { get; set; } = "Material Design 2";
#else
    private string MaterialMode { get; set; } = "Material Design 3";
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


    private async Task NavigateToDocs()
    {
        var baseURI = NavigationManager.BaseUri;
        await JSRuntime.InvokeAsync<object>("open", $"{baseURI}docs", "_blank");
    }



    private void NavigateToButton()
    {
        NavigationManager.NavigateTo("button");
    }
}
