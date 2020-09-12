using Material.Blazor.Internal;

using System;
using System.Collections.Generic;

namespace Material.Blazor
{
    /// <summary>
    /// A helper class for defining which foundry to use for an icon.
    /// </summary>
    public class MBIconHelper : IMBIcon
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


        private readonly IMBIcon UnderlyingIcon;


        /// <summary>
        /// Returns a new Material Icons foundry.
        /// </summary>
        /// <param name="theme">Optional <see cref="MBIconMITheme"/> specifying the Material Icons theme.</param>
        /// <returns><see cref="IMBIconFoundry"/> to be passed to a Material.Blazor component.</returns>
        public static IMBIconFoundry MIFoundry(MBIconMITheme? theme = null) => new IconFoundryMI(theme);


        /// <summary>
        /// Returns a new Font Awesome foundry.
        /// </summary>
        /// <param name="style">Optional <see cref="MBIconFAStyle"/> specifying the Font Awesome style.</param>
        /// <param name="relativeSize">Optional <see cref="MBIconFARelativeSize"/> specifying the Font Awesome relative size.</param>
        /// <returns><see cref="IMBIconFoundry"/> to be passed to a Material.Blazor component.</returns>
        public static IMBIconFoundry FAFoundry(MBIconFAStyle? style = null, MBIconFARelativeSize? relativeSize = null) => new IconFoundryFA(style, relativeSize);


        /// <summary>
        /// Returns a Open Iconic foundry.
        /// </summary>
        /// <returns><see cref="IMBIconFoundry"/> to be passed to a Material.Blazor component.</returns>
        public static IMBIconFoundry OIFoundry() => new IconFoundryOI();


#nullable enable annotations
        internal MBIconHelper(MBCascadingDefaults cascadingDefaults, string iconName, IMBIconFoundry? foundry = null)
        {
            if (cascadingDefaults is null)
            {
                cascadingDefaults = new MBCascadingDefaults();
            }

            MBIconFoundryName iconFoundry = cascadingDefaults.AppliedIconFoundryName(foundry?.FoundryName);

            UnderlyingIcon = iconFoundry switch
            {
                MBIconFoundryName.MaterialIcons => new IconMI(cascadingDefaults, iconName, (IconFoundryMI?)foundry),
                MBIconFoundryName.FontAwesome => new IconFA(cascadingDefaults, iconName, (IconFoundryFA?)foundry),
                MBIconFoundryName.OpenIconic => new IconOI(cascadingDefaults, iconName, (IconFoundryOI?)foundry),
                _ => throw new NotImplementedException(),
            };
        }
#nullable restore annotations
    }
}
