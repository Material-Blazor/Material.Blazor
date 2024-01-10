using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Material.Blazor.MD2;

/// <summary>
/// This is a general purpose Material Theme data table.
/// </summary>
public partial class MBDataTable<TItem> : ComponentFoundation
{
    /// <summary>
    /// A function delegate to return the parameters for <c>@key</c> attributes. If unused
    /// "fake" keys set to GUIDs will be used.
    /// </summary>
    [Parameter] public Func<TItem, object> GetKeysFunc { get; set; }


    /// <summary>
    /// Data to render in the <see cref="TableRow"/> render fragment.
    /// </summary>
    [Parameter] public IEnumerable<TItem> Items { get; set; }


    /// <summary>
    /// The table header as a render fragment using <c>&lt;th&gt;</c> HTML elements.
    /// </summary>
    [Parameter] public RenderFragment TableHeader { get; set; }


    /// <summary>
    /// Render fragment for each row of the table using <c>&lt;td&gt;</c> HTML elements.
    /// </summary>
    [Parameter] public RenderFragment<TItem> TableRow { get; set; }


    /// <summary>
    /// The data table's density.
    /// </summary>
    [Parameter] public MBDensity? Density { get; set; }


//    private MBCascadingDefaults.DensityInfo DensityInfo => CascadingDefaults.GetDensityCssClass(CascadingDefaults.AppliedDataTableDensity(Density));
    private ElementReference ElementReference { get; set; }
    private Func<TItem, object> KeyGenerator { get; set; }


 
    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();

        KeyGenerator = GetKeysFunc ?? delegate (TItem item) { return item; };
    }


    /// <inheritdoc/>
    internal override Task InstantiateMcwComponent()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBDataTable.init", ElementReference);
    }
}
