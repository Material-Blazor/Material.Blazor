using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;

using System;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// This is a general purpose Material Theme switch.
/// </summary>
public partial class MBSwitch : InputComponent<bool>
{
    /// <summary>
    /// The switch's label
    /// </summary>
    [Parameter] public string Label { get; set; } = "On/off";
    private string _cachedLabel;

    private ElementReference ElementReference { get; set; }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        ConditionalCssClasses
            .AddIf("mdc-switch--unselected", () => !ComponentValue)
            .AddIf("mdc-switch--selected", () => ComponentValue);

        _cachedLabel = Label;
    }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync().ConfigureAwait(false);

        if (_cachedLabel != Label)
        {
            _cachedLabel = Label;
            AllowNextRender(true);
        }
    }


    /// <summary>
    /// Toggles Value when the button is clicked.
    /// </summary>
    private void ToggleOnClick()
    {
        ComponentValue = !ComponentValue;
    }


    /// <inheritdoc/>
    private protected override Task SetComponentValueAsync()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBSwitch.setSelected", ElementReference, Value);
    }


    /// <inheritdoc/>
    private protected override Task OnDisabledSetAsync()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBSwitch.setDisabled", ElementReference, AppliedDisabled);
    }


    /// <inheritdoc/>
    internal override Task InstantiateMcwComponent()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBSwitch.init", ElementReference, ComponentValue);
    }
}
