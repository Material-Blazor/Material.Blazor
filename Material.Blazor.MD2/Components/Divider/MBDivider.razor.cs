using Material.Blazor.MD2.Internal;

using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Material.Blazor.MD2;

/// <summary>
/// A Material Theme divider.
/// </summary>
public partial class MBDivider : ComponentFoundation
{
    /// <summary>
    /// Material Theme "mdc-deprecated-list-divider--inset" if True.
    /// </summary>
    [Parameter] public bool Inset { get; set; }


    /// <summary>
    /// Material Theme "mdc-deprecated-list-divider--padded" if True.
    /// </summary>
    [Parameter] public bool Padded { get; set; }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor.MD2
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        ConditionalCssClasses
            .AddIf("mdc-deprecated-list-divider--inset", () => Inset)
            .AddIf("mdc-deprecated-list-divider--padded", () => Padded);
    }

}
