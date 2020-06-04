using System;
using System.Collections.Generic;

namespace BMdcModel
{
    /// <summary>
    /// A helper class for defining which foundry to use for an icon.
    /// </summary>
    public class IconHelper : IIcon
    {
        /// <inheritdoc/>
        public string Class => UnderlyingIcon.Class;


        /// <inheritdoc/>
        public string Text => UnderlyingIcon.Text;


        /// <inheritdoc/>
        public IDictionary<string, object> Attributes => UnderlyingIcon.Attributes;


        /// <inheritdoc/>
        public string IconName => UnderlyingIcon.IconName;


        /// <inheritdoc/>
        public bool RequiresColorFilter => UnderlyingIcon.RequiresColorFilter;


        private readonly IIcon UnderlyingIcon;


        /// <summary>
        /// Returns a new <see cref="IconHelper"> for a Material Icons icon.
        /// </summary>
        /// <param name="theme">Optional <see cref="EIconMITheme"/> specifying the Material Icons theme.</param>
        /// <returns><see cref="IIconFoundry"/> to be passed to a BlazorMdc component.</returns>
        public static IIconFoundry MIFoundry(EIconMITheme? theme = null) => new IconFoundryMI(theme);


        /// <summary>
        /// Returns a new <see cref="IconHelper"> for a Font Awesome icon.
        /// </summary>
        /// <param name="style">Optional <see cref="EIconFAStyle"/> specifying the Font Awesome style.</param>
        /// <param name="relativeSize">Optional <see cref="EIconFARelativeSize"/> specifying the Font Awesome relative size.</param>
        /// <returns><see cref="IIconFoundry"/> to be passed to a BlazorMdc component.</returns>
        public static IIconFoundry FAFoundry(EIconFAStyle? style = null, EIconFARelativeSize? relativeSize = null) => new IconFoundryFA(style, relativeSize);


        /// <summary>
        /// Returns a new <see cref="IconHelper"> for a Open Iconic icon.
        /// </summary>
        /// <returns><see cref="IIconFoundry"/> to be passed to a BlazorMdc component.</returns>
        public static IIconFoundry OIFoundry() => new IconFoundryOI();


#nullable enable annotations
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cascadingDefaults"></param>
        /// <param name="iconName"></param>
        /// <param name="foundry"></param>
        internal IconHelper(CascadingDefaults cascadingDefaults, string iconName, IIconFoundry? foundry = null)
        {
            if (cascadingDefaults is null)
            {
                cascadingDefaults = new CascadingDefaults();
            }

            EIconFoundryName iconFoundry = (foundry is null) ? cascadingDefaults.IconFoundryName : foundry.FoundryName;

            UnderlyingIcon = iconFoundry switch
            {
                EIconFoundryName.MaterialIcons => new IconMI(cascadingDefaults, iconName, (IconFoundryMI?)foundry),
                EIconFoundryName.FontAwesome => new IconFA(cascadingDefaults, iconName, (IconFoundryFA?)foundry),
                EIconFoundryName.OpenIconic => new IconOI(cascadingDefaults, iconName, (IconFoundryOI?)foundry),
                _ => throw new NotImplementedException(),
            };
        }
#nullable restore annotations
    }
}
