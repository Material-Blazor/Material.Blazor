using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Material.Blazor
{
    /// <summary>
    /// A Material Theme divider.
    /// </summary>
    public partial class MBDivider : ComponentFoundation
    {
        /// <summary>
        /// Material Theme "mdc-list-divider--inset" if True.
        /// </summary>
        [Parameter] public bool Inset { get; set; }


        /// <summary>
        /// Material Theme "mdc-list-divider--padded" if True.
        /// </summary>
        [Parameter] public bool Padded { get; set; }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            ClassMapperInstance
                .Add("mdc-list-divider")
                .AddIf("mdc-list-divider--inset", () => Inset)
                .AddIf("mdc-list-divider--padded", () => Padded);
        }

    }
}
