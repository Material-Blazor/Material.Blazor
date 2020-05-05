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

        public string BaseClass { get; set; }
        
        public string AdditionalClasses { get; set; }
        
        public string Icon { get; set; }
        
        public MdcIconType? IconType { get; set; }
        
        internal ToastStatus Status { get; set; }


        public PMdcToastSettings(
                    string heading,
                    RenderFragment message,
                    MdcIconType? iconType,
                    string baseClass,
                    string additionalClasses,
                    string icon)
        {
            Heading = heading;
            Message = message;
            IconType = iconType;
            BaseClass = baseClass;
            AdditionalClasses = additionalClasses;
            Icon = icon;
            Status = ToastStatus.Show;
        }
    }
}
