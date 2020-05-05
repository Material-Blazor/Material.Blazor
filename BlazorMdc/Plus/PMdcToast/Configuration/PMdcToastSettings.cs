//
//  2020-04-10  Mark Stega
//              Created from github.com/ChrisSainty/Blazored.Toast by Chris Sainty
//

using Microsoft.AspNetCore.Components;

namespace BlazorMdc
{
    public class PMdcToastSettings
    {
        public string Heading { get; set; }

        public RenderFragment Message { get; set; }

        public string CssClass { get; set; }
        
        public string Icon { get; set; }
        
        internal ToastStatus Status { get; set; }


        public PMdcToastSettings(string heading,
                    RenderFragment message,
                    string cssClass,
                    string icon)
        {
            Heading = heading;
            Message = message;
            CssClass = cssClass;
            Icon = icon;
            Status = ToastStatus.Show;
        }
    }
}
