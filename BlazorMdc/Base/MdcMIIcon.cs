using Microsoft.AspNetCore.Components;

namespace BlazorMdc
{
    public class MdcMIIcon : IMdcIconBase
    {
        public MdcMIIconTheme? IconTheme { get; set; } = MdcMIIconTheme.Filled;

        public string Class
        {
            get
            {
                return "material-icons" + CascadingDefaults.AppliedMCIconTheme(IconTheme) switch
                {
                    MdcMIIconTheme.Filled => "",
                    MdcMIIconTheme.Outlined => "-outlined",
                    MdcMIIconTheme.Round => "-round",
                    MdcMIIconTheme.TwoTone => "-two-tone",
                    MdcMIIconTheme.Sharp => "-sharp",
                    _ => throw new System.NotImplementedException(),
                };
            }
        }

        public string Text => IconName.ToLower();

        public string IconName { get; set; }

        [CascadingParameter] protected MdcCascadingDefaults CascadingDefaults { get; set; } = new MdcCascadingDefaults();

        public static implicit operator MdcMIIcon(string iconName) => new MdcMIIcon(iconName);


        public MdcMIIcon() { }

        public MdcMIIcon(string iconName, MdcMIIconTheme? iconTheme = null)
        {
            IconName = iconName;
            IconTheme = iconTheme;
        }
    }
}
