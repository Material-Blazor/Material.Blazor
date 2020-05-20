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
    public partial class PMdcIcon : MdcComponentBase
    {
#nullable enable annotations
        /// <summary>
        /// The icon name.
        /// </summary>
        [Parameter] public string Icon { get; set; }


        /// <summary>
        /// The foundry.
        /// <para><c>IconFoundry="MdcIconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="MdcIconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="MdcIconHelper.OIIcon()"</c></para>
        /// </summary>
        [Parameter] public IMdcIconFoundry? IconFoundry { get; set; }


        /// <summary>
        /// Indicates if True that the icons is to be rendered in an <see cref="MdcTabBar{TItem}"/>,
        /// adding the "mdc-tab__icon" CSS class.
        /// </summary>
        [Parameter] public bool TabBar { get; set; }
#nullable restore annotations


        private MdcIconHelper IconHelper { get; set; }


        /// <inheritdoc/>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            IconHelper = new MdcIconHelper(CascadingDefaults, Icon, IconFoundry);

            ClassMapper
                .Clear()
                .Add(IconHelper.Class)
                .AddIf("mdc-tab__icon", () => TabBar);

            ComponentPureHtmlAttributes = IconHelper.Attributes;
        }
    }
}
