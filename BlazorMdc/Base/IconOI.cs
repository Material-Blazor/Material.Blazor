using System.Collections.Generic;

namespace BlazorMdc
{
    internal class IconOI : IMdcIcon
    {
        public string Class => "oi";

        public string Text => "";

        private readonly Dictionary<string, object> _attributes;
        public IDictionary<string, object> Attributes => _attributes;

        public string IconName { get; }

        public bool RequiresWhiteFilter => false;

        public MdcIconFAStyle Style { get; }

        public MdcIconFARelativeSize RelativeSize { get; }


        private string IconStyleText => Style.ToString().Substring(0, 1).ToLower();

        private string IconNameText
        {
            get
            {
                return IconName.ToLower() + RelativeSize switch
                {
                    MdcIconFARelativeSize.Regular => "",
                    MdcIconFARelativeSize.ExtraSmall => " fa-xs",
                    MdcIconFARelativeSize.Small => " fa-sm",
                    MdcIconFARelativeSize.Large => " fa-lg",
                    MdcIconFARelativeSize.TwoTimes => " fa-2x",
                    MdcIconFARelativeSize.ThreeTimes => " fa-3x",
                    MdcIconFARelativeSize.FiveTimes => " fa-5x",
                    MdcIconFARelativeSize.SevenTimes => " fa-7x",
                    MdcIconFARelativeSize.TenTimes => " fa-10x",
                    _ => throw new System.NotImplementedException(),
                };
            }
        }


#nullable enable annotations
        public IconOI(MdcCascadingDefaults cascadingDefaults, string iconName, IconFoundryOI? foundry = null)
        {
            IconName = iconName;

            _attributes = new Dictionary<string, object>
            {
                { "data-glyph", iconName }
            };
        }
#nullable restore annotations
    }
}
