using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;

using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// This is a Material Theme FAB or floating action button, with regular, mini or extended variants,
/// application of the "mdc-fab--exited" animated class and the choice of leading or trailing icons for
/// the extended variant.
/// </summary>
public partial class MBFloatingActionButton : ComponentFoundation
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


    /// <summary>
    /// Sets the FAB to be regular or the mini or extended variants.
    /// </summary>
    [Parameter] public MBFloatingActionButtonType Type { get; set; }


    /// <summary>
    /// Sets the label, which is ignored for anything other than the extended variant.
    /// </summary>
    [Parameter] public string Label { get; set; }


    private bool AppliedTouchTarget => CascadingDefaults.AppliedTouchTarget(TouchTarget);

    
    /// <summary>
    /// When true collapses the FAB.
    /// </summary>
    [Parameter]
    public bool Exited { get; set; }
    private bool _cachedExited;
#nullable restore annotations


    private ElementReference ElementReference { get; set; }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        _ = ConditionalCssClasses
            .AddIf("mdc-fab--mini mdc-fab--touch", () => Type == MBFloatingActionButtonType.Mini)
            .AddIf("mdc-fab--extended", () => Type == MBFloatingActionButtonType.ExtendedNoIcon || Type == MBFloatingActionButtonType.ExtendedLeadingIcon || Type == MBFloatingActionButtonType.ExtendedTrailingIcon)
            .AddIf("mdc-fab--exited", () => Exited);
    }


    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync().ConfigureAwait(false);

        if (_cachedExited != Exited)
        {
            _cachedExited = Exited;
            EnqueueJSInteropAction(() => InvokeJsVoidAsync("MaterialBlazor.MBFloatingActionButton.setExited", ElementReference, Exited));
        }
    }


    /// <inheritdoc/>
    internal override Task InstantiateMcwComponent()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBFloatingActionButton.init", ElementReference, Exited);
    }
}
