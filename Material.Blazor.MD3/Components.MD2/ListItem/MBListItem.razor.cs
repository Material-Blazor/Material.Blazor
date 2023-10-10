using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace Material.Blazor.MD2;

public partial class MBListItem : ComponentFoundation
{
    [CascadingParameter] private MBDrawer Drawer { get; set; }
    [CascadingParameter] private MBMenu Menu { get; set; }

    [Parameter] public string Label { get; set; }

    [Parameter] public string LeadingIcon { get; set; }

    [Parameter] public string ListItemColor { get; set; } = "Black";

    [Parameter] public bool IsSelectedMenuItem { get; set; } = true;


    private string styleColor { get; set; }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        if (Drawer == null && Menu == null)
        {
            throw new ArgumentException($"MBListItem must be a child of either an MBDrawer or an MBMenu");
        }
        else if (Drawer != null && Menu != null)
        {
            throw new ArgumentException($"MBListItem can be a child of only an MBDrawer or an MBMenu but not both");
        }

        ConditionalCssClasses
            .AddIf("mdc-menu-item--selected", () => Menu != null && IsSelectedMenuItem)
            .AddIf("mdc-deprecated-list-item--disabled mb-list-item--disabled", () => AppliedDisabled);

        styleColor = "color: " + ListItemColor + "; ";
    }
}
