using Microsoft.AspNetCore.Components;

namespace BlazorMdc
{
    public class MdcFAIcon : IMdcIconBase
    {
        public MdcFAIconStyle? IconStyle { get; set; }

        public MdcFAIconRelativeSize? IconRelativeSize { get; set; }


        public string Class => $"fa{IconStyleText} {IconNameText}";

        public string Text => "";

        public string IconName { get; set; }

        [CascadingParameter] protected MdcCascadingDefaults CascadingDefaults { get; set; } = new MdcCascadingDefaults();


        public static implicit operator MdcFAIcon(string iconName) => new MdcFAIcon(iconName);


        private string IconStyleText => CascadingDefaults.AppliedFAIconStyle(IconStyle).ToString().Substring(0, 1).ToLower();

        private string IconNameText
        {
            get
            {
                return IconName.ToLower() + CascadingDefaults.AppliedFAIconRelativeSize(IconRelativeSize) switch
                {
                    MdcFAIconRelativeSize.Regular => "",
                    MdcFAIconRelativeSize.ExtraSmall => " fa-xs",
                    MdcFAIconRelativeSize.Small => " fa-sm",
                    MdcFAIconRelativeSize.Large => " fa-lg",
                    MdcFAIconRelativeSize.TwoTimes => " fa-2x",
                    MdcFAIconRelativeSize.ThreeTimes => " fa-3x",
                    MdcFAIconRelativeSize.FiveTimes => " fa-5x",
                    MdcFAIconRelativeSize.SevenTimes => " fa-7x",
                    MdcFAIconRelativeSize.TenTimes => " fa-10x",
                    _ => throw new System.NotImplementedException(),
                };
            }
        }



        public MdcFAIcon() { }

        public MdcFAIcon(string iconName, MdcFAIconStyle? iconStyle = null, MdcFAIconRelativeSize? iconRelativeSize = null)
        {
            IconName = iconName;
            IconStyle = iconStyle;
            IconRelativeSize = iconRelativeSize;
        }
    }
}
