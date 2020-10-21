using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

#if Logging
using Serilog;
using Serilog.Events;
#endif

namespace Material.BlazorWebsite.Server
{
    public class Program
    {
#if Logging
        private const string _customTemplate = "{Timestamp:HH:mm:ss.fff}\t[{Level:u3}]\t{Message}{NewLine}{Exception}";
#endif
        public static int Main(string[] args)
        {
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
                CreateHostBuilder(args).Build().Run();
                return 0;
            }
            catch (Exception ex)
            {
#if Logging
                Log.Fatal(ex, "Material.Blazor.Website.Server terminated unexpectedly");
#endif
                return 1;
            }
#if Logging
            finally
            {
                Log.CloseAndFlush();
            }
#endif
        }

#if Logging
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
#else
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
#endif

    }
}
