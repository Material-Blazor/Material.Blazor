using System.Collections.Generic;

namespace BMdcModel
{
    /// <summary>
    /// Font Awesome icon.
    /// </summary>
    internal class IconFA : BMdcModel.IIcon
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
        /// </summary>
        public BMdcModel.IconFAStyle Style { get; }


        /// <summary>
        /// The Font Awesome relative size.
        /// </summary>
        public BMdcModel.IconFARelativeSize RelativeSize { get; }


        private string IconStyleText => Style.ToString().Substring(0, 1).ToLower();

        private string IconNameText
        {
            get
            {
                return IconName.ToLower() + RelativeSize switch
                {
                    BMdcModel.IconFARelativeSize.Regular => "",
                    BMdcModel.IconFARelativeSize.ExtraSmall => " fa-xs",
                    BMdcModel.IconFARelativeSize.Small => " fa-sm",
                    BMdcModel.IconFARelativeSize.Large => " fa-lg",
                    BMdcModel.IconFARelativeSize.TwoTimes => " fa-2x",
                    BMdcModel.IconFARelativeSize.ThreeTimes => " fa-3x",
                    BMdcModel.IconFARelativeSize.FiveTimes => " fa-5x",
                    BMdcModel.IconFARelativeSize.SevenTimes => " fa-7x",
                    BMdcModel.IconFARelativeSize.TenTimes => " fa-10x",
                    _ => throw new System.NotImplementedException(),
                };
            }
        }


#nullable enable annotations
        public IconFA(CascadingDefaults cascadingDefaults, string iconName, IconFoundryFA? foundry = null)
        {
            IconName = iconName;
            Style = cascadingDefaults.AppliedIconFAStyle(foundry?.Style);
            RelativeSize = cascadingDefaults.AppliedIconFARelativeSize(foundry?.RelativeSize);
        }
#nullable restore annotations
    }
}
