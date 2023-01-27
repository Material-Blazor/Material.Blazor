using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Material.Blazor.Website.MD3.Pages;

public partial class Index
{
    [Inject] private NavigationManager NavigationManager { get; set; }
    [Inject] private IJSRuntime JSRuntime { get; set; }

#if MD2 && BLAZOR_SERVER
    private string BuildMode { get; set; } = "MD2Server";
#endif
#if MD2 && BLAZOR_WEBASSEMBLY
    private string BuildMode { get; set; } = "MD2WASM";
#endif
#if MD3 && BLAZOR_SERVER
    private string BuildMode { get; set; } = "MD3Server";
#endif
#if MD3 && BLAZOR_WEBASSEMBLY
    private string BuildMode { get; set; } = "MD3WASM";
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
}
