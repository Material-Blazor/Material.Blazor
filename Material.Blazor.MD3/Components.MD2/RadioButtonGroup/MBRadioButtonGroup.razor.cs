﻿using Material.Blazor.Internal.MD2;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Material.Blazor.MD2;

/// <summary>
/// A group of <see cref="MBRadioButton{TItem}"/>s displayed horizontally or vertically.
/// </summary>
public partial class MBRadioButtonGroup<TItem> : SingleSelectComponentMD2<TItem, Material.Blazor.MD2.MBSelectElement<TItem>>
{
    /// <summary>
    /// The radio button's density.
    /// </summary>
    [Parameter] public MBDensity? Density { get; set; }


    /// <summary>
    /// Stack the radio buttons vertically if True, otherwise default horizontal placement.
    /// </summary>
    [Parameter] public bool Vertical { get; set; } = false;


    private string RadioGroupName { get; set; } = Utilities.GenerateUniqueElementName();


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        MBItemValidation appliedItemValidation = MBItemValidation.DefaultToFirst;

        ForceShouldRenderToTrue = true;

        bool hasValue;

        (hasValue, ComponentValue) = ValidateItemList(Items, appliedItemValidation);

        ConditionalCssClasses.AddIf("mb-mdc-radio-group-vertical", () => Vertical);
    }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();

        KeyGenerator = GetKeysFunc ?? delegate (TItem item) { return item; };
    }
}
