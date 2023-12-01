using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Material.Blazor.Website.Shared
{
    public partial class MainLayout
    {
        private const string materialDocRef = "https://github.com/material-components/material-components-web/tree/master/packages/";
        private MBDrawer Drawer { get; set; }
        private MBMenu Menu { get; set; }
        private string Theme { get; set; } = "material-default-theme";

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


        private void ListItemClickHandler(string NavigationReference)
        {
            Drawer.NotifyNavigation();
            NavigationService.NavigateTo(NavigationReference);
        }

        private void SideBarToggle()
        {
            Drawer.Toggle();
        }
    }
}
