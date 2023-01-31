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


    /// <summary>
    /// Inclusion of touch target
    /// </summary>
    [Parameter] public bool? TouchTarget { get; set; }


#nullable enable annotations
    /// <summary>
    /// The icon's name.
    /// </summary>
    [Parameter] public string Icon { get; set; }


    /// <summary>
    /// The foundry to use for both leading and trailing icons.
    /// <para><c>IconFoundry="IconHelper.MIIcon()"</c></para>
    /// <para><c>IconFoundry="IconHelper.FAIcon()"</c></para>
    /// <para><c>IconFoundry="IconHelper.OIIcon()"</c></para>
    /// <para>Overrides <see cref="MBCascadingDefaults.IconFoundryName"/></para>
    /// </summary>
    [Parameter] public IMBIconFoundry? IconFoundry { get; set; }
#nullable restore annotations


    /// <summary>
    /// The button's density.
    /// </summary>
    [Parameter] public MBDensity? Density { get; set; }


    /// <summary>
    /// Determines whether the button has a badge - defaults to false.
    /// </summary>
    [Parameter] public bool HasBadge { get; set; }


    /// <summary>
    /// The badge's style - see <see cref="MBBadgeStyle"/>, defaults to <see cref="MBBadgeStyle.ValueBearing"/>.
    /// </summary>
    [Parameter] public MBBadgeStyle BadgeStyle { get; set; } = MBBadgeStyle.ValueBearing;


    /// <summary>
    /// The button's density.
    /// </summary>
    [Parameter] public string BadgeValue { get; set; }


    /// <summary>
    /// When true collapses the badge.
    /// </summary>
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
