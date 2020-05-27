using BBase;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// Renders icons from any of the Material Icons, Font Awesome and Open Iconic
    /// foundries. Material Icons are essential for BlazorMdc and are included by the
    /// library's CSS, while you can elect whether to include Font Awesome and Open Iconic
    /// in your app.
    /// </summary>
    public partial class PMdcIcon : BBase.ComponentBase
    {
#nullable enable annotations
        /// <summary>
        /// The icon name.
        /// </summary>
        [Parameter] public string Icon { get; set; }


        /// <summary>
        /// The foundry.
        /// <para><c>IconFoundry="BModel.IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="BModel.IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="BModel.IconHelper.OIIcon()"</c></para>
        /// </summary>
        [Parameter] public BModel.IIconFoundry? IconFoundry { get; set; }


        /// <summary>
        /// Indicates if True that the icons is to be rendered in an <see cref="MdcTabBar{TItem}"/>,
        /// adding the "mdc-tab__icon" CSS class.
        /// </summary>
        [Parameter] public bool TabBar { get; set; }
#nullable restore annotations


        private BModel.IconHelper IconHelper { get; set; }


        /// <inheritdoc/>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            IconHelper = new BModel.IconHelper(CascadingDefaults, Icon, IconFoundry);

            ClassMapper
                .Clear()
                .Add(IconHelper.Class)
                .AddIf("mdc-tab__icon", () => TabBar);

            ComponentPureHtmlAttributes = IconHelper.Attributes;
        }
    }
}
