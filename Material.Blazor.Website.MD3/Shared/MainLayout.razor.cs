using Material.Blazor.MD2;

using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Material.Blazor.Website.Shared
{
    public partial class MainLayout
    {
        private MBDrawer Drawer { get; set; }
        private Material.Blazor.MD2.MBMenu Menu { get; set; }
        private string Theme { get; set; } = "material-default-theme";

        private void ListItemClickHandler(string NavigationReference)
        {
            Drawer.NotifyNavigation();
            NavigationService.NavigateTo(NavigationReference);
        }

        private async Task OpenMenuAsync()
        {
            await Menu.ToggleAsync();
        }

        protected async Task ThemeSetterAsync(string theme)
        {
            await JsRuntime.InvokeAsync<object>("MaterialBlazorWebsite.MBTheme.setTheme", theme, true);
            Theme = theme;
            StateHasChanged();
        }


        private void SideBarToggle()
        {
            Drawer.Toggle();
        }
    }
}
