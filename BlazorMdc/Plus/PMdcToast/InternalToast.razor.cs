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
        [Parameter] public ToastSettings ToastSettings { get; set; }

        private void Close()
        {
            ToastsContainer.RemoveToast(ToastId);
        }
    }
}
