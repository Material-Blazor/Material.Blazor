using System;
using System.Collections.Generic;

namespace BlazorMdc
{
    /// <summary>
    /// A helper class for defining which foundry to use for an icon.
    /// </summary>
    public class MdcIconHelper : IMdcIcon
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


        private readonly IMdcIcon UnderlyingIcon;


        /// <summary>
        /// Returns a new <see cref="MdcIconHelper"> for a Material Icons icon.
        /// </summary>
        /// <param name="theme">Optional <see cref="MdcIconMITheme"/> specifying the Material Icons theme.</param>
        /// <returns><see cref="IMdcIconFoundry"/> to be passed to a BlazorMdc component.</returns>
        public static IMdcIconFoundry MIFoundry(MdcIconMITheme? theme = null) => new IconFoundryMI(theme);


        /// <summary>
        /// Returns a new <see cref="MdcIconHelper"> for a Font Awesome icon.
        /// </summary>
        /// <param name="style">Optional <see cref="MdcIconFAStyle"/> specifying the Font Awesome style.</param>
        /// <param name="relativeSize">Optional <see cref="MdcIconFARelativeSize"/> specifying the Font Awesome relative size.</param>
        /// <returns><see cref="IMdcIconFoundry"/> to be passed to a BlazorMdc component.</returns>
        public static IMdcIconFoundry FAFoundry(MdcIconFAStyle? style = null, MdcIconFARelativeSize? relativeSize = null) => new IconFoundryFA(style, relativeSize);


        /// <summary>
        /// Returns a new <see cref="MdcIconHelper"> for a Open Iconic icon.
        /// </summary>
        /// <returns><see cref="IMdcIconFoundry"/> to be passed to a BlazorMdc component.</returns>
        public static IMdcIconFoundry OIFoundry() => new IconFoundryOI();


#nullable enable annotations
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cascadingDefaults"></param>
        /// <param name="iconName"></param>
        /// <param name="foundry"></param>
        internal MdcIconHelper(MdcCascadingDefaults cascadingDefaults, string iconName, IMdcIconFoundry? foundry = null)
        {
            if (cascadingDefaults is null)
            {
                cascadingDefaults = new MdcCascadingDefaults();
            }

            MdcIconFoundryName iconFoundry = (foundry is null) ? cascadingDefaults.IconFoundryName : foundry.FoundryName;

            UnderlyingIcon = iconFoundry switch
            {
                MdcIconFoundryName.MaterialIcons => new IconMI(cascadingDefaults, iconName, (IconFoundryMI?)foundry),
                MdcIconFoundryName.FontAwesome => new IconFA(cascadingDefaults, iconName, (IconFoundryFA?)foundry),
                MdcIconFoundryName.OpenIconic => new IconOI(cascadingDefaults, iconName, (IconFoundryOI?)foundry),
                _ => throw new NotImplementedException(),
            };
        }
#nullable restore annotations
    }
}
