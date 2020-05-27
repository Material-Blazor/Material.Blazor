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
        /// <param name="theme">Optional <see cref="BMdcModel.IconMITheme"/> specifying the Material Icons theme.</param>
        /// <returns><see cref="IIconFoundry"/> to be passed to a BlazorMdc component.</returns>
        public static IIconFoundry MIFoundry(BMdcModel.IconMITheme? theme = null) => new IconFoundryMI(theme);


        /// <summary>
        /// Returns a new <see cref="IconHelper"> for a Font Awesome icon.
        /// </summary>
        /// <param name="style">Optional <see cref="BMdcModel.IconFAStyle"/> specifying the Font Awesome style.</param>
        /// <param name="relativeSize">Optional <see cref="BMdcModel.IconFARelativeSize"/> specifying the Font Awesome relative size.</param>
        /// <returns><see cref="IIconFoundry"/> to be passed to a BlazorMdc component.</returns>
        public static IIconFoundry FAFoundry(BMdcModel.IconFAStyle? style = null, BMdcModel.IconFARelativeSize? relativeSize = null) => new IconFoundryFA(style, relativeSize);


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

            BMdcModel.IconFoundryName iconFoundry = (foundry is null) ? cascadingDefaults.IconFoundryName : foundry.FoundryName;

            UnderlyingIcon = iconFoundry switch
            {
                BMdcModel.IconFoundryName.MaterialIcons => new IconMI(cascadingDefaults, iconName, (IconFoundryMI?)foundry),
                BMdcModel.IconFoundryName.FontAwesome => new IconFA(cascadingDefaults, iconName, (IconFoundryFA?)foundry),
                BMdcModel.IconFoundryName.OpenIconic => new IconOI(cascadingDefaults, iconName, (IconFoundryOI?)foundry),
                _ => throw new NotImplementedException(),
            };
        }
#nullable restore annotations
    }
}
