using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Material.Blazor.Website.MD3.Pages
{
    public partial class Dialog
    {
        private bool DisableInput { get; set; } = false;

        private MBDialogButton[] buttonsOKCancel = new MBDialogButton[]
        {
        new MBDialogButton
        {
          ButtonLabel = "OK",
          ButtonStyle = MBButtonStyle.Outlined,
          ButtonValue = "OK"
        },
        new MBDialogButton
        {
          ButtonLabel = "Cancel",
          ButtonStyle = MBButtonStyle.Outlined,
          ButtonValue = "cancel"
        },
        };

        #region DialogGeneral & DialogGeneralNoGesture

        private MBDialog DialogGeneral { get; set; }
        private MBDialog DialogGeneralNoGesture { get; set; }

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
        new MBDialogButton
        {
          ButtonLabel = "tangerine",
          ButtonStyle = MBButtonStyle.Outlined,
          ButtonValue = "tangerine"
        },
        };

        private bool Check { get; set; }
        private string RadioButtonResult1 { get; set; }

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

        private async Task ShowDialogGeneralNoGestureAsync()
        {
            var result = await DialogGeneralNoGesture.ShowAsync();
            ToastService.ShowToast(heading: "General Dialog (No gesture close)", message: $"Value: '{result}'", level: MBToastLevel.Success, showIcon: false);
        }

        #endregion

        #region DialogLogon

        private MBDialog DialogLogon { get; set; }
        private class UserLogonDefinition
        {
            [Required(ErrorMessage = "UserID is required")]
            public string UserID { get; set; }


            [Required(ErrorMessage = "Password is required")]
            [MinLength(8, ErrorMessage = "Password must be at least 8 characters.")]
            public string Password { get; set; }
        }

        private UserLogonDefinition UserLogon { get; set; } = new();
        private async Task ShowDialogLogonFormAsync()
        {
            UserLogon = new UserLogonDefinition();
            var result = await DialogLogon.ShowAsync();
            ToastService.ShowToast(heading: "Logon Dialog", message: $"Value: '{result}'", level: MBToastLevel.Success, showIcon: false);
        }

        private async Task DialogLogonFormSubmitted()
        {
            await Task.CompletedTask;
            await DialogLogon.HideAsync("submit");
            // notification will come from the Show completion
        }

        private void DialogLogonFormInvalid()
        {
            ToastService.ShowToast(heading: "Logon Dialog Invalid", message: $"Edit form was invalid", level: MBToastLevel.Warning, showIcon: false);
        }

        private async Task DialogLogonFormCanceled()
        {
            await DialogLogon.HideAsync("cancel");
            // notification will come from the Show completion
        }

        #endregion

        #region DialogNoBody

        private MBDialog DialogNoBody { get; set; }

        private async Task ShowDialogNoBodyAsync()
        {
            var result = await DialogNoBody.ShowAsync();
            ToastService.ShowToast(heading: "No Body Dialog", message: $"Value: '{result}'", level: MBToastLevel.Success, showIcon: false);
        }

        #endregion

        #region DialogNoTitle

        private MBDialog DialogNoTitle { get; set; }

        private async Task ShowDialogNoTitleAsync()
        {
            var result = await DialogNoTitle.ShowAsync();
            ToastService.ShowToast(heading: "No Title Dialog", message: $"Value: '{result}'", level: MBToastLevel.Success, showIcon: false);
        }

        #endregion

        #region DialogCustomHeader

        private MBDialog DialogCustomHeader { get; set; }

        private async Task ShowDialogCustomHeaderAsync()
        {
            var result = await DialogCustomHeader.ShowAsync();
            ToastService.ShowToast(heading: "Custom Header Dialog", message: $"Value: '{result}'", level: MBToastLevel.Success, showIcon: false);
        }

        #endregion

        #region DialogDatePicker

        private MBDialog DialogDatePicker { get; set; }
        private DateTime MinDate { get; set; } = new DateTime(2015, 1, 1);
        private DateTime MaxDate { get; set; } = new DateTime(2025, 12, 31);
        private DateTime DatePickerDate { get; set; } = DateTime.Today;

        private async Task ShowDialogDatePickerAsync()
        {
            var result = await DialogDatePicker.ShowAsync();
            ToastService.ShowToast(heading: "Datepicker Dialog", message: $"Value: '{result}'", level: MBToastLevel.Success, showIcon: false);
        }

        #endregion

    }
}
