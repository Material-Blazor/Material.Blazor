using Material.Blazor.MD2.Internal;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor.MD2;

/// <summary>
/// A Material Theme segmented button orientated as a single-select.
/// </summary>
public partial class MBChipsSelectSingle<TItem> : SingleSelectComponent<TItem, MBIconBearingSelectElement<TItem>>
{
#nullable enable annotations
    /// <summary>
    /// The foundry to use for both leading and trailing icons.
    /// <para><c>IconFoundry="IconHelper.MIIcon()"</c></para>
    /// <para><c>IconFoundry="IconHelper.FAIcon()"</c></para>
    /// <para><c>IconFoundry="IconHelper.OIIcon()"</c></para>
    /// <para>Overrides <see cref="MBCascadingDefaults.IconFoundryName"/></para>
    /// </summary>
    [Parameter] public IMBIconFoundry? IconFoundry { get; set; }
#nullable restore annotations


    private MBChipsSelectMulti<TItem> ChipsSelectMulti { get; set; }

    private IList<TItem> multiValues;
    private IList<TItem> MultiValues
    {
        get => multiValues;
        set
        {
            multiValues = value;
            ComponentValue = multiValues.FirstOrDefault();
        }
    }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor.MD2
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        var appliedItemValidation = CascadingDefaults.AppliedItemValidation(ItemValidation);

        ComponentValue = ValidateItemList(Items, appliedItemValidation).value;

        multiValues = new TItem[] { Value };
    }


    /// <inheritdoc/>
    private protected override Task SetComponentValueAsync()
    {
        ChipsSelectMulti.SetSingleSelectValue(Value);
        return Task.CompletedTask;
    }
}
