using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Material.Blazor.Website.MD3.Pages
{
    public partial class Dialog
    {
        private bool DisableInput { get; set; } = false;
        private MBDialog DialogGeneral { get; set; }
        private MBDialog Dialog2 { get; set; }
        private MBDialog Dialog3 { get; set; }
        private MBDialog Dialog4 { get; set; }
        private MBDialog Dialog5 { get; set; }
        private MBDialog Dialog6 { get; set; }
        private MBDialog Dialog7 { get; set; }

        private MBDialogButton[] buttonsFruit = new MBDialogButton[]
        {
        new MBDialogButton
        {
          ButtonLabel = "apple",
          ButtonStyle = MBButtonStyle.Outlined,
          ButtonValue = "apple"
        },
        new MBDialogButton
        {
          ButtonLabel = "orange",
          ButtonStyle = MBButtonStyle.Outlined,
          ButtonValue = "orange"
        },
        };

        private bool Check { get; set; }

        private string _radioButtonResult1 = "brit-short";
        private string RadioButtonResult1
        {
            get => _radioButtonResult1;
            set
            {
                _radioButtonResult1 = value;

                ToastService.ShowToast(heading: "Dialog 1 Radio Click", message: $"Value: '{_radioButtonResult1}'", level: MBToastLevel.Success, showIcon: false);
            }
        }

        private MBSingleSelectElement<string>[] CatBreedItems = new MBSingleSelectElement<string>[]
        {
        new MBSingleSelectElement<string>
            { SelectedValue = "brit-short", TrailingLabel = "British Shorthair" },
        new MBSingleSelectElement<string>
            { SelectedValue = "russ-blue", TrailingLabel = "Russian Blue" },
        new MBSingleSelectElement<string>
            { SelectedValue = "ice-invis", TrailingLabel = "Icelandic Invisible" }
        };

        private async Task ShowDialogGeneralAsync()
        {
            var result = await DialogGeneral.ShowAsync();
            ToastService.ShowToast(heading: "General Dialog", message: $"Value: '{result}'", level: MBToastLevel.Success, showIcon: false);
        }

        private async Task ShowDialog2Async()
        {
            var result = await Dialog2.ShowAsync();
            ToastService.ShowToast(heading: "General Dialog w/o Scrim/Esc", message: $"Value: '{result}'", level: MBToastLevel.Success, showIcon: false);
        }

        private async Task OnButtonClick(string button)
        {
            //await Dialog2.CloseAsync();
            ToastService.ShowToast(heading: "General Dialog w/o Scrim/Esc by @onclick", message: $"Value: '{button}'", level: MBToastLevel.Success, showIcon: false);
        }

        private DateTime MinDate { get; set; } = new DateTime(2015, 1, 1);
        private DateTime MaxDate { get; set; } = new DateTime(2025, 12, 31);
        private DateTime Date5 { get; set; } = DateTime.Today;

        private async Task ShowDialog3Async()
        {
            var result = await Dialog3.ShowAsync();
            ToastService.ShowToast(heading: "Datepicker Dialog", message: $"Value: '{result}'", level: MBToastLevel.Success, showIcon: false);
        }

        private UserLogonDefinition UserLogon { get; set; }
        private async Task ShowDialog4Async()
        {
            UserLogon = new UserLogonDefinition();
            _ = Dialog4.ShowAsync();
            await Task.CompletedTask;
        }

        private async Task Dialog4Submitted()
        {
            //await Dialog4.CloseAsync();
            ToastService.ShowToast(heading: "Logon Dialog Submit", message: $"User / Password: '{UserLogon.UserID}' / '{UserLogon.Password}'", level: MBToastLevel.Success, showIcon: false);
        }

        private void Dialog4Invalid()
        {
            ToastService.ShowToast(heading: "Logon Dialog Invalid", message: $"Edit form was invalid", level: MBToastLevel.Warning, showIcon: false);
        }

        private async Task Dialog4Canceled()
        {
            //await Dialog4.CloseAsync();
            ToastService.ShowToast(heading: "Logon Dialog Canceled", message: "The cancel button was selected", level: MBToastLevel.Success, showIcon: false);
        }

        private async Task ShowDialog5Async()
        {
            var result = await Dialog5.ShowAsync();
            ToastService.ShowToast(heading: "No Body Dialog", message: $"Value: '{result}'", level: MBToastLevel.Success, showIcon: false);
        }

        private async Task ShowDialog6Async()
        {
            var result = await Dialog6.ShowAsync();
            ToastService.ShowToast(heading: "No Title Dialog", message: $"Value: '{result}'", level: MBToastLevel.Success, showIcon: false);
        }

        private async Task ShowDialog7Async()
        {
            UserLogon = new UserLogonDefinition();
            _ = Dialog7.ShowAsync();
            await Task.CompletedTask;
        }

        private async Task Dialog7Submitted()
        {
            //await Dialog7.CloseAsync();
            ToastService.ShowToast(heading: "Logon Dialog #2 Submit", message: $"User / Password: '{UserLogon.UserID}' / '{UserLogon.Password}'", level: MBToastLevel.Success, showIcon: false);
        }

        private void Dialog7Invalid()
        {
            ToastService.ShowToast(heading: "Logon Dialog #2 Invalid", message: $"Edit form was invalid", level: MBToastLevel.Warning, showIcon: false);
        }

        private async Task Dialog7Canceled()
        {
            //await Dialog7.CloseAsync();
            ToastService.ShowToast(heading: "Logon Dialog #2 Canceled", message: "The cancel button was selected", level: MBToastLevel.Success, showIcon: false);
        }

        private class UserLogonDefinition
        {
            [Required(ErrorMessage = "UserID is required")]
            public string UserID { get; set; }


            [Required(ErrorMessage = "Password is required")]
            [MinLength(8, ErrorMessage = "Password must be at least 8 characters.")]
            public string Password { get; set; }
        }
    }
}
