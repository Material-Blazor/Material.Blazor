using Material.Blazor.MD2;

namespace Material.Blazor.Website.Shared
{
    public partial class MainLayout
    {
        private MBDrawer Drawer { get; set; }

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
