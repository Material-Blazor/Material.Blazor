using BMdcModel;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BlazorMdc.Demo.WebServer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();

            // The configuration is optional
            services.AddToastService(new ToastServiceConfiguration()
            {
                InfoDefaultHeading = "Info",
                SuccessDefaultHeading = "Success",
                WarningDefaultHeading = "Warning",
                ErrorDefaultHeading = "Error",
                Timeout = 5000,
                MaxToastsShowing = 5
            });

            // The configuration is optional
            services.AddAnimatedNavigationManager(new AnimatedNaviationManagerConfiguration()
            {
                ApplyAnimation = true,
                AnimationTime = 300
            });

            services.AddScoped<DemoConfiguration>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
#if BlazorWebAssembly
                app.UseWebAssemblyDebugging();
#endif
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

#if BlazorWebAssembly
            app.UseBlazorFrameworkFiles();
#endif

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
#if BlazorWebAssembly
                endpoints.MapFallbackToPage("/index_webassembly");
#else
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/index_server");
#endif
            });
        }
    }
}
