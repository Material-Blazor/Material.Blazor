using Material.Blazor.Internal.MD2;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Material.Blazor.MD2;

/// <summary>
/// This is a general purpose Material Theme icon button, with provision for standard MB styling, leading 
/// and trailing icons and all standard Blazor events. Adds the "mdc-card__action--icon" class when 
/// placed inside an <see cref="MBCard"/>.
/// </summary>
public partial class MBIconButton : ComponentFoundationMD2
{
    [CascadingParameter] private MBCard Card { get; set; }

    [Parameter] public bool? TouchTarget { get; set; }


#nullable enable annotations
    [Parameter] public string IconColor { get; set; }
    [Parameter] public string IconName { get; set; }


    [Parameter] public MBDensity? Density { get; set; }


    [Parameter] public bool HasBadge { get; set; }

    [Parameter] public MBBadgeStyle BadgeStyle { get; set; } = MBBadgeStyle.ValueBearing;

    [Parameter] public string BadgeValue { get; set; }

    [Parameter] public bool BadgeExited { get; set; }


    private bool AppliedTouchTarget => false;
    private ElementReference ElementReference { get; set; }

    
    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        _ = ConditionalCssClasses
            .AddIf("mdc-button--touch", () => AppliedTouchTarget)
            .AddIf("mdc-card__action mdc-card__action--icon", () => Card != null);
    }


    /// <inheritdoc/>
    internal override Task InstantiateMcwComponent()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBIconButton.init", ElementReference);
    }
}
