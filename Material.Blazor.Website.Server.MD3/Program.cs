using GoogleAnalytics.Blazor;
using Material.Blazor;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

#if Logging
using Serilog;
using Serilog.Events;

const string _customTemplate = "{Timestamp:HH:mm:ss.fff}\t[{Level:u3}]\t{Message}{NewLine}{Exception}";

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
    .Enrich.FromLogContext()
    .WriteTo.Async(a => a.Console(outputTemplate: _customTemplate))
    .CreateLogger();
#endif

try
{
#if Logging
    Log.Information("Starting Material.Blazor.Website.Server");
#endif
    var builder = WebApplication.CreateBuilder(args);

#if Logging
    builder.Host.UseSerilog();
#endif

    // Add services to the container.
    builder.Services.AddRazorPages();

#if SERVER

    builder.Services.AddServerSideBlazor();
    builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

#endif


    // Option 1: add options to services, which are then accessed by the Material Blazor services.
    builder.Services.AddOptions<MBServicesOptions>().Configure(options =>
    {
        options.LoggingServiceConfiguration = Utilities.GetDefaultLoggingServiceConfiguration();
        //options.SnackbarServiceConfiguration = Utilities.GetDefaultSnackbarServiceConfiguration();
        options.ToastServiceConfiguration = Utilities.GetDefaultToastServiceConfiguration();
    });

    // Option 2: add options within the call to add the Material.Blazor services.
    //builder.Services.AddMBServices(options =>
    //{
    //    options.LoggingServiceConfiguration = Utilities.GetDefaultLoggingServiceConfiguration();
    //    options.SnackbarServiceConfiguration = Utilities.GetDefaultSnackbarServiceConfiguration();
    //    options.ToastServiceConfiguration = Utilities.GetDefaultToastServiceConfiguration();
    //});

    builder.Services.AddMBServices();

    builder.Services.AddGBService(options =>
    {
        options.TrackingId = "G-TRLQX48ZSY";
    });

    var app = builder.Build();

    if (app.Environment.IsDevelopment())
    {
#if SERVER
        app.UseDeveloperExceptionPage();
#else
        app.UseWebAssemblyDebugging();
#endif
    }
    else
    {
        app.UseExceptionHandler("/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }

#if Logging
    app.UseSerilogRequestLogging();
#endif
    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();

#if SERVER
    app.MapBlazorHub();
#else
    app.UseBlazorFrameworkFiles();
#endif

    app.MapFallbackToPage("/Host");

    app.Run();
}
catch (Exception ex)
{
#if Logging
    Log.Fatal(ex, "Material.Blazor.Website.Server terminated unexpectedly");
#endif
}
#if Logging
finally
{
    Log.CloseAndFlush();
}
#endif
