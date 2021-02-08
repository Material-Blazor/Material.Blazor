﻿using Material.Blazor;
using Material.Blazor.Website;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Material.BlazorWebsite.WebAssembly
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddMBServices(
                animatedNavigationManagerServiceConfiguration: Utilities.GetDefaultAnimatedNavigationServiceConfiguration(),
                toastServiceConfiguration: Utilities.GetDefaultToastServiceConfiguration()
            );

            await builder.Build().RunAsync();
        }
    }
}
