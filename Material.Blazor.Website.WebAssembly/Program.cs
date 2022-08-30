﻿using GoogleAnalytics.Blazor;
using Material.Blazor;
using Material.Blazor.Website;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Extensions.Logging;
using Serilog.Events;
using System;
using System.Net.Http;
using System.Threading.Tasks;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Option 1: add options to services, which are then accessed by the Material Blazor services.
//builder.Services.AddOptions<MBServicesOptions>().Configure(options =>
//{
//    options.LoggingServiceConfiguration = Utilities.GetDefaultLoggingServiceConfiguration();
//    options.SnackbarServiceConfiguration = Utilities.GetDefaultSnackbarServiceConfiguration();
//    options.ToastServiceConfiguration = Utilities.GetDefaultToastServiceConfiguration();
//});

//builder.Services.AddMBServices();

// Option 2: add options within the call to add the Material.Blazor services.
builder.Services.AddMBServices(options =>
{
    options.LoggingServiceConfiguration = Utilities.GetDefaultLoggingServiceConfiguration();
    options.SnackbarServiceConfiguration = Utilities.GetDefaultSnackbarServiceConfiguration();
    options.ToastServiceConfiguration = Utilities.GetDefaultToastServiceConfiguration();
});

Log.Logger = new LoggerConfiguration()
#if DEBUG
    .MinimumLevel.Debug()
#else
    .MinimumLevel.Information()
#endif
    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
    .MinimumLevel.Override("GoogleAnalytics.Blazor", LogEventLevel.Debug)
    .Enrich.FromLogContext()
    .WriteTo.Async(a => a.BrowserConsole(outputTemplate: "{Timestamp:HH:mm:ss.fff}\t[{Level:u3}]\t{Message}{NewLine}{Exception}"))
    .CreateLogger();

builder.Logging.AddProvider(new SerilogLoggerProvider());

builder.Services.AddGBService("G-TRLQX48ZSY");

await builder.Build().RunAsync();
