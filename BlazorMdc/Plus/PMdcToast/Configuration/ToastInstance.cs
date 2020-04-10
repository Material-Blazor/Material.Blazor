using System;

namespace BlazorMdc
{
    internal class ToastInstance
    {
        public Guid Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public ToastSettings ToastSettings { get; set; }
    }
}
