//using Material.Blazor.MD2;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System.Threading.Tasks;

namespace Material.Blazor.Website.Shared
{
    public partial class MainLayout
    {
        [Inject] private NavigationManager NavigationManager { get; set; } = default!;
        [Inject] private IJSRuntime JSRuntime { get; set; } = default!;

        private string Theme { get; set; } = "material-default-theme";

        protected async Task ThemeSetterAsync(string theme)
        {
            await JsRuntime.InvokeAsync<object>("MaterialBlazorWebsite.MBTheme.setTheme", theme, true);
            Theme = theme;
            StateHasChanged();
        }

        private readonly MBMenuItem[] mainMenuItems = new MBMenuItem[]
        {
            new MBMenuItem {
                Headline="Home",
                HeadlineColor="black",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "home",
                                    color: "black"),
                MenuItemType=MBMenuItemType.Regular },
            new MBMenuItem {
                Headline="Button",
                HeadlineColor="darkgreen",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "touch_app",
                                    color: "darkgreen"),
                MenuItemType=MBMenuItemType.Regular },
            new MBMenuItem {
                Headline="Card",
                HeadlineColor="darkred",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "dashboard",
                                    color: "darkred"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="Checkbox",
                HeadlineColor="darkgreen",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "check_box",
                                    color: "darkgreen"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="ChipSet",
                HeadlineColor="darkgreen",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "toggle_off",
                                    color: "darkgreen"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="Data Table",
                HeadlineColor="darkred",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "table_chart",
                                    color: "darkred"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="DateTime Field",
                HeadlineColor="darkblue",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "date_range",
                                    color: "darkblue"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="Decimal Field",
                HeadlineColor="darkblue",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "money",
                                    color: "darkblue"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="Dialog",
                HeadlineColor="darkgreen",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "picture_in_picture",
                                    color: "darkgreen"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="Double Field",
                HeadlineColor="darkblue",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "money",
                                    color: "darkblue"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="Floating Action Button",
                HeadlineColor="darkgreen",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "offline_bolt",
                                    color: "darkgreen"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="Grid",
                HeadlineColor="darkblue",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "table_chart",
                                    color: "darkblue"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="Icon",
                HeadlineColor="darkgreen",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "touch_app",
                                    color: "darkgreen"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="Icon Button",
                HeadlineColor="darkgreen",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "touch_app",
                                    color: "darkgreen"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="Int Field",
                HeadlineColor="darkblue",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "exposure_zero",
                                    color: "darkblue"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="List",
                HeadlineColor="darkgreen",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "list",
                                    color: "darkgreen"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="Menu",
                HeadlineColor="darkgreen",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "menu",
                                    color: "darkgreen"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="Progress Indicator",
                HeadlineColor="darkgreen",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "access_time",
                                    color: "darkgreen"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="Radio Button",
                HeadlineColor="darkgreen",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "radio_button_checked",
                                    color: "darkgreen"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="Radio Button Group",
                HeadlineColor="darkblue",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "radio_button_checked",
                                    color: "darkblue"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="Select",
                HeadlineColor="darkgreen",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "arrow_drop_down",
                                    color: "darkgreen"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="Slider",
                HeadlineColor="darkgreen",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "straighten",
                                    color: "darkgreen"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="Switch",
                HeadlineColor="darkgreen",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "switch_left",
                                    color: "darkgreen"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="Tabs",
                HeadlineColor="darkgreen",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "tab",
                                    color: "darkgreen"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="Text Field",
                HeadlineColor="darkgreen",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "text_format",
                                    color: "darkgreen"),
                MenuItemType=MBMenuItemType.Regular },
             new MBMenuItem {
                Headline="Toast",
                HeadlineColor="darkblue",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "textsms",
                                    color: "darkblue"),
                MenuItemType=MBMenuItemType.Regular },
};
        private readonly MBMenuItem[] themeMenuItems = new MBMenuItem[]
        {
            new MBMenuItem {
                Headline="Material Default Theme",
                HeadlineColor="black",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "check_box",
                                    color: "black"),
                MenuItemType=MBMenuItemType.Regular,
                SuppressLeadingIcon=false },
            new MBMenuItem {
                Headline="Material Alternate Theme",
                HeadlineColor="black",
                LeadingIcon=MBIcon.IconDescriptorConstructor(
                                    name: "check_box",
                                    color: "black"),
                MenuItemType=MBMenuItemType.Regular,
                SuppressLeadingIcon=true },
};


        protected void MainMenuSelectionReportHandler(MenuSelectionReportEventArgs args)
        {
            var destination = args.menuHeadline.ToLower() switch
            {
                "button" => "button",
                "card" => "card",
                "checkbox" => "checkbox",
                "chipset" => "chipset",
                "data table" => "datatable",
                "datetime field" => "datetimefield",
                "decimal field" => "decimalfield",
                "dialog" => "dialog",
                "double field" => "doublefield",
                "floating action button" => "floatingactionbutton",
                "grid" => "grid",
                "icon" => "icon",
                "icon button" => "iconbutton",
                "int field" => "intfield",
                "list" => "list",
                "menu" => "menu",
                "progress indicator" => "progress",
                "radio button" => "radiobutton",
                "radio button group" => "radiobuttongroup",
                "select" => "select",
                "slider" => "slider",
                "switch" => "switch",
                "tabs" => "tabs",
                "text field" => "textfield",
                "toast" => "toast",
                _ => "",
            };
            NavigationManager.NavigateTo(destination);
        }

        protected async Task ThemeMenuSelectionReportHandler(MenuSelectionReportEventArgs args)
        {
            if (args.menuHeadline.Equals("Material Alternate Theme"))
            {
                Theme = "material-alternate-theme";
                themeMenuItems[0].SuppressLeadingIcon = true;
                themeMenuItems[1].SuppressLeadingIcon = false;
            }
            else
            {
                Theme = "material-default-theme";
                themeMenuItems[0].SuppressLeadingIcon = false;
                themeMenuItems[1].SuppressLeadingIcon = true;
            }
            await ThemeSetterAsync(Theme);
        }
    }
}
