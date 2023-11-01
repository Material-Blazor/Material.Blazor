using System.Threading.Tasks;

namespace Material.Blazor.Website.MD3.Pages
{
    public partial class Menu
    {
        private Material.Blazor.MD2.MBMenu MenuElement { get; set; }
        private bool SevenSelected { get; set; }
        private bool EightSelected { get; set; }

        private MBMenuItem[] menuItems = new MBMenuItem[]
        {
            new MBMenuItem {
                Headline="One",
                HeadlineColor="darkblue",
                ItemType=MBMenuItemType.Regular },
            new MBMenuItem {
                Headline="Two",
                HeadlineColor="darkblue",
                ItemType=MBMenuItemType.Regular },
            new MBMenuItem {
                Headline="Three",
                HeadlineColor="darkblue",
                ItemType=MBMenuItemType.Regular },
            new MBMenuItem {
                Headline="Four",
                HeadlineColor="darkblue",
                ItemType=MBMenuItemType.Regular,
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "home",
                                    color: "darkblue")},
            new MBMenuItem {
                Headline="Five",
                HeadlineColor="darkblue",
                ItemType=MBMenuItemType.Regular,
                TrailingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "alarm",
                                    color: "darkblue")},
            new MBMenuItem {
                Headline="Six",
                HeadlineColor="darkblue",
                ItemType=MBMenuItemType.Regular,
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "home",
                                    color: "darkblue"),
                TrailingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "alarm",
                                    color: "darkblue")},
            new MBMenuItem {
                Headline="Seven",
                HeadlineColor="darkblue",
                ItemType=MBMenuItemType.Regular,
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "done",
                                    color: "darkgreen"),
                SuppressLeadingIcon=true },
            new MBMenuItem {
                Headline="Eight",
                HeadlineColor="darkblue",
                ItemType=MBMenuItemType.Regular,
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "done",
                                    color: "darkgreen"),
                SuppressLeadingIcon=true },
            new MBMenuItem {
                Headline="Nine (disabled)",
                HeadlineColor="darkblue",
                IsDisabled=true,
                ItemType=MBMenuItemType.Regular },
        };

        private async Task OpenMenuAsync()
        {
            await MenuElement.ToggleAsync();
        }

        protected void OnClickHandler(string NavigationReference)
        {
            var result = NavigationReference;
            ToastService.ShowToast(heading: "Menu result", message: $"Value: '{result}'", level: MBToastLevel.Success, showIcon: false);

            SevenSelected = (result == "Seven") ? !SevenSelected : SevenSelected;
            menuItems[6].SuppressLeadingIcon = !SevenSelected;
            EightSelected = (result == "Eight") ? !EightSelected : EightSelected;
            menuItems[7].SuppressLeadingIcon = !EightSelected;
        }

    }
}
