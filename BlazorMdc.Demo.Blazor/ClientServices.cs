using Microsoft.Extensions.DependencyInjection;

namespace BlazorMdc.Demo.Blazor
{
    public static class ClientServices
    {
        public static void Inject(IServiceCollection serviceCollection)
        {
            // The configuration is optional
            serviceCollection.AddMTToastService(new MTToastServiceConfiguration()
            {
                InfoDefaultHeading = "Info",
                SuccessDefaultHeading = "Success",
                WarningDefaultHeading = "Warning",
                ErrorDefaultHeading = "Error",
                Timeout = 5000,
                MaxToastsShowing = 5
            });

            serviceCollection.AddMTTooltipService();

            // The configuration is optional
            serviceCollection.AddMTAnimatedNavigationManager(new MTAnimatedNaviationManagerConfiguration()
            {
                ApplyAnimation = true,
                AnimationTime = 300
            });

            serviceCollection.AddScoped<DemoConfiguration>();
        }
    }
}
