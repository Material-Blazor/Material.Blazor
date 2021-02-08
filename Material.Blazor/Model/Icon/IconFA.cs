using System.Collections.Generic;

namespace Material.Blazor.Internal
{
    /// <summary>
    /// Font Awesome icon.
    /// </summary>
    internal class IconFA : IMBIcon
    {
        /// <inheritdoc />
        public string Class => $"fa{IconStyleText} {IconNameText}";


        /// <inheritdoc />
        public string Text => "";


        private readonly Dictionary<string, object> _attributes = new Dictionary<string, object>();
        /// <inheritdoc />
        public IDictionary<string, object> Attributes => _attributes;


        /// <inheritdoc />
        public string IconName { get; }


        /// <inheritdoc />
        public bool RequiresColorFilter => false;


        /// <summary>
        /// The Font Awesome style.
        /// <para>Overrides <see cref="MBCascadingDefaults.IconFAStyle"/></para>
        /// </summary>
        public MBIconFAStyle Style { get; }


        /// <summary>
        /// The Font Awesome relative size.
        /// <para>Overrides <see cref="MBCascadingDefaults.IconFARelativeSize"/></para>
        /// </summary>
        public MBIconFARelativeSize RelativeSize { get; }


        private string IconStyleText => Style.ToString().Substring(0, 1).ToLower();

        private string IconNameText
        {
            get
            {
                return IconName.ToLower() + RelativeSize switch
                {
                    MBIconFARelativeSize.Regular => "",
                    MBIconFARelativeSize.ExtraSmall => " fa-xs",
                    MBIconFARelativeSize.Small => " fa-sm",
                    MBIconFARelativeSize.Large => " fa-lg",
                    MBIconFARelativeSize.TwoTimes => " fa-2x",
                    MBIconFARelativeSize.ThreeTimes => " fa-3x",
                    MBIconFARelativeSize.FiveTimes => " fa-5x",
                    MBIconFARelativeSize.SevenTimes => " fa-7x",
                    MBIconFARelativeSize.TenTimes => " fa-10x",
                    _ => throw new System.NotImplementedException(),
                };
            }
        }


#nullable enable annotations
        public IconFA(MBCascadingDefaults cascadingDefaults, string iconName, IconFoundryFA? foundry = null)
        {
            IconName = iconName;
            Style = cascadingDefaults.AppliedIconFAStyle(foundry?.Style);
            RelativeSize = cascadingDefaults.AppliedIconFARelativeSize(foundry?.RelativeSize);
        }
#nullable restore annotations
    }
}
