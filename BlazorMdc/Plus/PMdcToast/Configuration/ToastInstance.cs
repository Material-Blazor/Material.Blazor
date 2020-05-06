//
//  2020-04-10  Mark Stega
//              Created from github.com/ChrisSainty/Blazored.Toast by Chris Sainty
//

using System;

namespace BlazorMdc
{
    internal enum ToastStatus { Show, FadeOut, Hide }

    internal class ToastInstance
    {
        public Guid Id { get; set; }

        public DateTime TimeStamp { get; set; }

        public PMdcToastSettings Settings { get; set; }
    }
}
