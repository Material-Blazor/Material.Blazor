﻿using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// A list of user provided render fragments that can be re-ordered with drag and drop.
/// </summary>
public partial class MBDragAndDropList<TItem> : InputComponent<List<TItem>>
{
    /// <summary>
    /// A function delegate to return the parameters for <c>@key</c> attributes. If unused
    /// "fake" keys set to GUIDs will be used.
    /// </summary>
    [Parameter] public Func<TItem, object> GetKeysFunc { get; set; }


    /// <summary>
    /// Render fragment for each displayable item.
    /// </summary>
    [Parameter] public RenderFragment<TItem> Content { get; set; }


    /// <summary>
    /// Render fragment for each displayable item.
    /// </summary>
    [Parameter] public string DragButtonTooltip { get; set; } = "Click and drag to re-order";


    private ElementReference ElementReference { get; set; }
    private Func<TItem, object> KeyGenerator { get; set; }


    //// Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    //protected override async Task OnInitializedAsync()
    //{
    //    await base.OnInitializedAsync();

    //    ConditionalCssClasses
    //        .AddIf(DensityInfo.CssClassName, () => DensityInfo.ApplyCssClass)
    //        .AddIf("mdc-data-table--sticky-header", () => StickyHeader);
    //}


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();

        KeyGenerator = GetKeysFunc ?? delegate (TItem item) { return item; };
    }
}
