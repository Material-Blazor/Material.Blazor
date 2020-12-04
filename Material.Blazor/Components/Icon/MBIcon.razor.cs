using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;

namespace Material.Blazor
{
    /// <summary>
    /// Renders icons from any of the Material Icons, Font Awesome and Open Iconic
    /// foundries. Material Icons are essential for Material.Blazor and are included by the
    /// library's CSS, while you can elect whether to include Font Awesome and Open Iconic
    /// in your app.
    /// </summary>
    public partial class MBIcon : ComponentFoundation
    {
        [CascadingParameter(Name = MBTabBar<object>.TabBarIdentifier)] private object TabBarIdentifier { get; set; }

#nullable enable annotations
        /// <summary>
        /// The icon name.
        /// </summary>
        [Parameter] public string IconName { get; set; }


        /// <summary>
        /// The foundry.
        /// <para><c>IconFoundry="IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.OIIcon()"</c></para>
        /// <para>Overrides <see cref="MBCascadingDefaults.IconFoundryName"/></para>
        /// </summary>
        [Parameter] public IMBIconFoundry? IconFoundry { get; set; }
#nullable restore annotations


        private MBIconHelper IconHelper { get; set; }


        /// <inheritdoc/>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            IconHelper = new MBIconHelper(CascadingDefaults, IconName, IconFoundry);
            ComponentPureHtmlAttributes = IconHelper.Attributes;

            //
            // Has to be here, the string in Add/AddIf is evaluated only once at the
            // time of the add.
            //
            ClassMapperInstance
                .Clear()
                .Add(IconHelper.Class)
                .AddIf("mdc-tab__icon", () => TabBarIdentifier != null);
        }
    }
}
