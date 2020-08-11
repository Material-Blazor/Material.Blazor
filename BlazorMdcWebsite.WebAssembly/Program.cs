using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BlazorMdc;
using BlazorMdcWebsite.Components;

namespace BlazorMdcWebsite.WebAssembly
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddMTServices(
                toastServiceConfiguration: new MTToastServiceConfiguration()
                {
                    CloseMethod = MTToastCloseMethod.TimeoutAndCloseButton,
                    Position = MTToastPosition.TopRight
                },

                animatedNavigationManagerConfiguration: new MTAnimatedNaviationManagerConfiguration()
                {
                    ApplyAnimation = true,
                    AnimationTime = 300
                }
                );

            await builder.Build().RunAsync();
        }
    }
}
