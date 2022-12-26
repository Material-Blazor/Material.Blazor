using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
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


    private ElementReference ElementReference { get; set; }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        ConditionalCssClasses
            .AddIf("mdc-switch--unselected", () => !ComponentValue)
            .AddIf("mdc-switch--selected", () => ComponentValue);

        SetComponentValue += OnValueSetCallback;
    }


    /// <summary>
    /// Toggles Value when the button is clicked.
    /// </summary>
    private void ToggleOnClick()
    {
        ComponentValue = !ComponentValue;
    }


    /// <summary>
    /// Callback for value the value setter.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected Task OnValueSetCallback() => InvokeJsVoidAsync("MaterialBlazor.MBSwitch.setSelected", ElementReference, Value);


    /// <summary>
    /// Callback for value the Disabled value setter.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private protected override Task OnDisabledSetAsync()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBSwitch.setDisabled", ElementReference, AppliedDisabled);
    }


    /// <inheritdoc/>
    internal override Task InstantiateMcwComponent() => InvokeJsVoidAsync("MaterialBlazor.MBSwitch.init", ElementReference, ComponentValue);
}
