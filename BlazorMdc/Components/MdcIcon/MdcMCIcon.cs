using Microsoft.AspNetCore.Components;

namespace BlazorMdc
{
    public class MdcMCIcon : IMdcIconBase
    {
        public MdcMCIconTheme? IconTheme { get; set; } = MdcMCIconTheme.Filled;

        public string Class
        {
            get
            {
                return "material-icons" + CascadingDefaults.AppliedMCIconTheme(IconTheme) switch
                {
                    MdcMCIconTheme.Filled => "",
                    MdcMCIconTheme.Outlined => "-outlined",
                    MdcMCIconTheme.Round => "-round",
                    MdcMCIconTheme.TwoTone => "-two-tone",
                    MdcMCIconTheme.Sharp => "-sharp",
                    _ => throw new System.NotImplementedException(),
                };
            }
        }

        public string Text => IconName.ToLower();

        public string IconName { get; set; }

        [CascadingParameter] protected MdcCascadingDefaults CascadingDefaults { get; set; } = new MdcCascadingDefaults();

        public static implicit operator MdcMCIcon(string iconName) => new MdcMCIcon(iconName);


        public MdcMCIcon() { }

        public MdcMCIcon(string iconName, MdcMCIconTheme? iconTheme = null)
        {
            IconName = iconName;
            IconTheme = iconTheme;
        }
    }
}
