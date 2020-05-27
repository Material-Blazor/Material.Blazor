//
//  2020-04-10  Mark Stega
//              Created from github.com/ChrisSainty/Blazored.Toast by Chris Sainty
//

using System;

namespace BMdcPlus
{
    /// <summary>
    /// The current status of a Toast, expressed through it's CSS class.
    /// </summary>
    internal enum ToastStatus { Show, FadeOut, Hide }


    /// <summary>
    /// An instance of a toast message.
    /// </summary>
    internal class ToastInstance
    {
        /// <summary>
        /// The toast's unique id.
        /// </summary>
        public Guid Id { get; set; }


        /// <summary>
        /// It's timestamp for when it was raised.
        /// </summary>
        public DateTime TimeStamp { get; set; }


        /// <summary>
        /// The settings containing all data determining the toast's style and behaviour.
        /// </summary>
        public ToastSettings Settings { get; set; }
    }
}
