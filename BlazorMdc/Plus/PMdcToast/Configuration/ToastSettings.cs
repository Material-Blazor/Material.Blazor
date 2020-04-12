//
//  2020-04-10  Mark Stega
//              Created from github.com/ChrisSainty/Blazored.Toast by Chris Sainty
//

namespace BlazorMdc
{
    public class ToastSettings
    {
        public ToastSettings(string heading, string message, string baseClass, string additionalClasses, string iconClass, string iconName)
        {
            Heading = heading;
            Message = message;
            BaseClass = baseClass;
            AdditionalClasses = additionalClasses;
            IconClass = iconClass;
            IconName = iconName;
        }

        public string Heading { get; set; }
        public string Message { get; set; }
        public string BaseClass { get; set; }
        public string AdditionalClasses { get; set; }
        public string IconClass { get; set; }
        public string IconName { get; set; }
    }
}
