using Microsoft.AspNetCore.Components;

using System;

namespace BlazorMdc
{
    public partial class PMdcToast
    {
        [CascadingParameter] private PMdcToasts ToastsContainer { get; set; }

        [Parameter] public Guid ToastId { get; set; }
        [Parameter] public ToastSettings ToastSettings { get; set; }

        private void Close()
        {
            ToastsContainer.RemoveToast(ToastId);
        }
    }
}
