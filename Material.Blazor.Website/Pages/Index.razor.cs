using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Material.Blazor.Website.Pages;

public partial class Index
{
    [Inject] private NavigationManager NavigationManager { get; set; }
    [Inject] private IJSRuntime JSRuntime { get; set; }

    // Determined at runtime: the same assembly is hosted by both the Server and WebAssembly launch projects
    private string BuildMode { get; set; } = OperatingSystem.IsBrowser() ? "WebAssembly" : "Server";

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
        await JSRuntime.InvokeVoidAsync("open", $"{baseURI}docs", "_blank");
    }
    private void NavigateToButton()
    {
        NavigationManager.NavigateTo("anchor");
    }
}
