using Material.Blazor.Internal.MD2;
using Microsoft.AspNetCore.Components;

using System;
using System.Threading.Tasks;

namespace Material.Blazor.MD2;

/// <summary>
/// This is a general purpose Material Theme radio button. Accepts a generic class TItem
/// and displays as checked if <see cref="InputComponent{T}.Value"/> equals <see cref="TargetCheckedValue"/>.
/// </summary>
public partial class MBRadioButton<TItem> : InputComponentMD2<TItem>
{
    /// <summary>
    /// <see cref="InputComponent{T}.Value"/> is set to this when the 
    /// radio button is clicked. If the consumer sets <see cref="InputComponent{T}.Value"/>
    /// to this the radio state will change to checked, or cleared for any other value.
    /// </summary>
    [Parameter] public TItem TargetCheckedValue { get; set; }


    /// <summary>
    /// The radio button label.
    /// </summary>
    [Parameter] public string Label { get; set; }


    /// <summary>
    /// The radio button's density.
    /// </summary>
    [Parameter] public MBDensity? Density { get; set; }


    /// <summary>
    /// The radio button group name. This is applied to a group of radio buttons
    /// so Material Theme can identify them as representing different values of the
    /// same property.
    /// </summary>
    [Parameter] public string RadioGroupName { get; set; }


    private readonly string radioId = Utilities.GenerateUniqueElementName();


    private ElementReference FormReference { get; set; }
    private bool InputDisabled { get; set; }
    private bool IsChecked { get; set; }
    private ElementReference RadioButtonReference { get; set; }
    private string DisabledClass { get; set; } = "";

    private MBCascadingDefaults.DensityInfo DensityInfo => CascadingDefaults.GetDensityCssClass(CascadingDefaults.AppliedRadioButtonDensity(Density));


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        ConditionalCssClasses
            .AddIf(DensityInfo.CssClassName, () => DensityInfo.ApplyCssClass)
            .AddIf("mdc-checkbox--disabled", () => AppliedDisabled);

        InputDisabled = AppliedDisabled;
        IsChecked = ComponentValue != null && ComponentValue.Equals(TargetCheckedValue);

        ForceShouldRenderToTrue = true;
    }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();

        if (string.IsNullOrEmpty(RadioGroupName))
        {
            throw new ArgumentException("RadioGroupName is a required parameter in MBRadioButton.");
        }

        if (AppliedDisabled)
        {
            DisabledClass = "mdc-radio--disabled";
        }
    }


    /// <inheritdoc/>
    protected private override Task SetComponentValueAsync()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBRadioButton.setChecked", RadioButtonReference, Value.Equals(TargetCheckedValue));
    }


    /// <inheritdoc/>
    private protected override Task OnDisabledSetAsync() => InvokeJsVoidAsync("MaterialBlazor.MBRadioButton.setDisabled", RadioButtonReference, AppliedDisabled);


    private void OnInternalItemClick()
    {
        ComponentValue = TargetCheckedValue;
    }


    /// <inheritdoc/>
    internal override Task InstantiateMcwComponent()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBRadioButton.init", RadioButtonReference, FormReference, Value?.Equals(TargetCheckedValue) ?? false);
    }
}
