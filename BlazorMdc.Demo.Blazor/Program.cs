using BMdcModel;
using BMdcPlus;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorMdc.Demo.Blazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddSingleton(
                new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            // The configuration is optional
            builder.Services.AddToastService(new BMdcModel.ToastServiceConfiguration()
            {
                InfoDefaultHeading = "Info",
                SuccessDefaultHeading = "Success",
                WarningDefaultHeading = "Warning",
                ErrorDefaultHeading = "Error",
                Timeout = 5000,
                MaxToastsShowing = 5
            });

            // The configuration is optional
            builder.Services.AddAnimatedNavigationManager(new AnimatedNaviationManagerConfiguration()
            {
                ApplyAnimation = true,
                AnimationTime = 300
            });

            builder.Services.AddScoped<DemoConfiguration>();

            await builder.Build().RunAsync();
        }
    }
}
