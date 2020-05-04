//
//  2020-04-10  Mark Stega
//              Created from github.com/ChrisSainty/Blazored.Toast by Chris Sainty
//

using Microsoft.AspNetCore.Components;

using System;

namespace BlazorMdc
{
    public partial class InternalToast
    {
        [CascadingParameter] private PMdcToasts ToastsContainer { get; set; }

        [Parameter] public Guid ToastId { get; set; }

        [Parameter] public PMdcToastSettings Settings { get; set; }


        private string statusClass = "";


        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            statusClass = Settings.Status switch
            {
                ToastStatus.Show => "fade-in",
                ToastStatus.FadeOut => "fade-out",
                ToastStatus.Hide => "hide",
                _ => throw new InvalidOperationException(),
            };
        }

        private void Close()
        {
            ToastsContainer.CloseToast(ToastId);
        }
    }
}
