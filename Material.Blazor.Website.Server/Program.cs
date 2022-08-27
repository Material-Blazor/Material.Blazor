using GoogleAnalytics.Blazor;
using Material.Blazor;
using Material.Blazor.Website;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

#if Logging
using Serilog;
using Serilog.Events;
#endif

#if Logging
const string _customTemplate = "{Timestamp:HH:mm:ss.fff}\t[{Level:u3}]\t{Message}{NewLine}{Exception}";
#endif
#if Logging
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
    builder.Services.AddServerSideBlazor();
    builder.Services.AddMBServices(
        loggingServiceConfiguration: Utilities.GetDefaultLoggingServiceConfiguration(),
        toastServiceConfiguration: Utilities.GetDefaultToastServiceConfiguration(),
        snackbarServiceConfiguration: Utilities.GetDefaultSnackbarServiceConfiguration()
    );

    builder.Services.AddGBService("G-TRLQX48ZSY");

    var app = builder.Build();

    if (app.Environment.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
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

    app.UseEndpoints(endpoints =>
    {
        endpoints.MapBlazorHub();
        endpoints.MapFallbackToPage("/_Host");
    });

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
