using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;

namespace BlazorMdc
{
    /// <summary>
    /// Renders icons from any of the Material Icons, Font Awesome and Open Iconic
    /// foundries. Material Icons are essential for BlazorMdc and are included by the
    /// library's CSS, while you can elect whether to include Font Awesome and Open Iconic
    /// in your app.
    /// </summary>
    public partial class MTIcon : ComponentFoundation
    {
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
        /// <para>Overrides <see cref="MTCascadingDefaults.IconFoundryName"/></para>
        /// </summary>
        [Parameter] public IMTIconFoundry? IconFoundry { get; set; }


        /// <summary>
        /// Indicates if True that the icons is to be rendered in an <see cref="MTTabBar{TItem}"/>,
        /// adding the "mdc-tab__icon" CSS class.
        /// </summary>
        [Parameter] public bool TabBar { get; set; }
#nullable restore annotations


        private MTIconHelper IconHelper { get; set; }


        /// <inheritdoc/>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            IconHelper = new MTIconHelper(CascadingDefaults, IconName, IconFoundry);
            ComponentPureHtmlAttributes = IconHelper.Attributes;

            //
            // Has to be here, the string in Add/AddIf is evaluated only once at the
            // time of the add.
            //
            ClassMapper
                .Clear()
                .Add(IconHelper.Class)
                .AddIf("mdc-tab__icon", () => TabBar);
        }
    }
}
