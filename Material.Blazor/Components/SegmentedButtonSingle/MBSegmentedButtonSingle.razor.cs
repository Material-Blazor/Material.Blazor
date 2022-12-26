using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// A Material Theme segmented button orientated as a single-select.
/// </summary>
public partial class MBSegmentedButtonSingle<TItem> : SingleSelectComponent<TItem, MBIconBearingSelectElement<TItem>>
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


    /// <summary>
    /// Determines whether the button has a badge - defaults to false.
    /// </summary>
    [Parameter] public bool HasBadge { get; set; }


    /// <summary>
    /// The badge's style - see <see cref="MBBadgeStyle"/>, defaults to <see cref="MBBadgeStyle.ValueBearing"/>.
    /// </summary>
    [Parameter] public MBBadgeStyle BadgeStyle { get; set; } = MBBadgeStyle.ValueBearing;


    /// <summary>
    /// When true collapses the badge.
    /// </summary>
    [Parameter]
    public bool BadgeExited { get; set; }
    private bool _cachedBadgeExited;


    /// <summary>
    /// The button's density.
    /// </summary>
    [Parameter]
    public string BadgeValue { get; set; }
    private string _cachedBadgeValue;
#nullable restore annotations


    private MBSegmentedButtonMulti<TItem> SegmentedButtonMulti { get; set; }

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


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        var appliedItemValidation = CascadingDefaults.AppliedItemValidation(ItemValidation);

        ComponentValue = ValidateItemList(Items, appliedItemValidation).value;

        multiValues = new TItem[] { Value };
    }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync().ConfigureAwait(false);

        if (_cachedBadgeValue != BadgeValue || _cachedBadgeExited != BadgeExited)
        {
            _cachedBadgeValue = BadgeValue;
            _cachedBadgeExited = BadgeExited;

            if (SegmentedButtonMulti?.Badge is not null)
            {
                EnqueueJSInteropAction(() => SegmentedButtonMulti.Badge.SetValueAndExited(BadgeValue, BadgeExited));
            }
        }
    }


    /// <inheritdoc/>
    private protected override Task SetComponentValueAsync()
    {
        SegmentedButtonMulti.SetSingleSelectValue(Value);
        return Task.CompletedTask;
    }
}
