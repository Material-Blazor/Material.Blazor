using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System.Threading.Tasks;

namespace Material.Blazor
{
    /// <summary>
    /// Renders icons from any of the Material Icons, Font Awesome and Open Iconic
    /// foundries. Material Icons are essential for Material.Blazor and are included by the
    /// library's CSS, while you can elect whether to include Font Awesome and Open Iconic
    /// in your app.
    /// </summary>
    public class MBIcon : ComponentFoundation
    {
        [CascadingParameter(Name = "IsInsideMBTabBar")] private bool IsInsideMBTabBar { get; set; }

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
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            if (IconHelper == null)
            {
                return;
            }
            builder.AddContent(0, IconHelper.Render(@class: string.Join(" ", (IsInsideMBTabBar ? "mdc-tab__icon" : ""), @class), style: style, attributes: AttributesToSplat()));
        }

        /// <inheritdoc/>
        protected override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();

            IconHelper = new MBIconHelper(CascadingDefaults, IconName, IconFoundry);
        }
    }
}
