using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// A Material Theme segmented button orientated as a multi-select.
/// </summary>
public partial class MBSegmentedButtonMulti<TItem> : MultiSelectComponent<TItem, MBIconBearingSelectElement<TItem>>
{
    /// <summary>
    /// If this component is rendered inside a single-select segmented button, add the "" class.
    /// </summary>
    [CascadingParameter] private MBSegmentedButtonSingle<TItem> SegmentedButtonSingle { get; set; }

    /// <summary>
    /// Inclusion of touch target
    /// </summary>
    [Parameter] public bool? TouchTarget { get; set; }


    /// <summary>
    /// Determines whether the button has a badge - defaults to false.
    /// </summary>
    [Parameter] public bool HasBadge { get; set; }


    /// <summary>
    /// The badge's style - see <see cref="MBBadgeStyle"/>, defaults to <see cref="MBBadgeStyle.ValueBearing"/>.
    /// </summary>
    [Parameter] public MBBadgeStyle BadgeStyle { get; set; } = MBBadgeStyle.ValueBearing;


    private string badgeValue;
    /// <summary>
    /// The badge's value.
    /// </summary>
    [Parameter]
    public string BadgeValue
    {
        get => badgeValue;
        set
        {
            if (value != badgeValue)
            {
                badgeValue = value;

                if (Badge != null)
                {
                    Badge.SetValueAndExited(badgeValue, badgeExited);
                }
            }
        }
    }


    private bool badgeExited;
    /// <summary>
    /// When true collapses the badge.
    /// </summary>
    [Parameter]
    public bool BadgeExited
    {
        get => badgeExited;
        set
        {
            if (value != badgeExited)
            {
                badgeExited = value;

                if (Badge != null)
                {
                    Badge.SetValueAndExited(badgeValue, badgeExited);
                }
            }
        }
    }


    /// <summary>
    /// The badge for use by <see cref="MBSegmentedButtonSingle{TItem}"/>.
    /// </summary>
    internal MBBadge Badge { get; set; }
    
    
    private bool AppliedTouchTarget => CascadingDefaults.AppliedTouchTarget(TouchTarget);
    private MBIconBearingSelectElement<TItem>[] ItemsArray { get; set; }
    private bool IsSingleSelect { get; set; }
    private IDisposable ObjectReference { get; set; }
    private string GroupRole => (SegmentedButtonSingle == null) ? "group" : "radiogroup";
    private Dictionary<string, object>[] SegmentAttributes { get; set; }
    private ElementReference SegmentedButtonReference { get; set; }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        IsSingleSelect = SegmentedButtonSingle != null;

        ConditionalCssClasses
            .AddIf("mdc-segmented-button--single-select", () => IsSingleSelect);

        ItemsArray = Items.ToArray();

        SegmentAttributes = new Dictionary<string, object>[ItemsArray.Length];

        for (int i = 0; i < ItemsArray.Length; i++)
        {
            SegmentAttributes[i] = new();

            var selected = Value.Contains(ItemsArray[i].SelectedValue);

            SegmentAttributes[i].Add("class", "mdc-segmented-button__segment mdc-segmented-button--touch" + (selected ? " mdc-segmented-button__segment--selected" : ""));

            if (IsSingleSelect)
            {
                SegmentAttributes[i].Add("role", "radio");
                SegmentAttributes[i].Add("aria-checked", selected.ToString().ToLower());
            }
            else
            {
                SegmentAttributes[i].Add("aria-pressed", selected.ToString().ToLower());
            }
        }

        ObjectReference = DotNetObjectReference.Create(this);
    }


    private bool _disposed = false;
    protected override void Dispose(bool disposing)
    {
        if (_disposed)
        {
            return;
        }

        if (disposing)
        {
            ObjectReference?.Dispose();
        }

        _disposed = true;

        base.Dispose(disposing);
    }


    /// <summary>
    /// For Material Theme to notify of menu item selection via JS Interop.
    /// </summary>
    [JSInvokable]
    public void NotifyMultiSelected(bool[] selected)
    {
        var selectedIndexes = Enumerable.Range(0, selected.Length).Where(i => selected[i]);
        ComponentValue = ItemsArray.Where((item, index) => selectedIndexes.Contains(index)).Select(x => x.SelectedValue).ToArray();
    }


    /// <summary>
    /// For Material Theme to notify of menu item selection via JS Interop.
    /// </summary>
    [JSInvokable]
    public void NotifySingleSelected(int index)
    {
        ComponentValue = new TItem[] { ItemsArray[index].SelectedValue };
    }


    /// <inheritdoc/>
    private protected override Task SetComponentValueAsync()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBSegmentedButtonMulti.setSelected", SegmentedButtonReference, Items.Select(x => Value.Contains(x.SelectedValue)).ToArray());
    }


    /// <inheritdoc/>
    private protected override Task OnDisabledSetAsync()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBSegmentedButtonMulti.setDisabled", SegmentedButtonReference, AppliedDisabled);
    }


    /// <inheritdoc/>
    internal override Task InstantiateMcwComponent()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBSegmentedButtonMulti.init", SegmentedButtonReference, IsSingleSelect, ObjectReference);
    }


    /// <summary>
    /// Used by <see cref="MBSegmentedButtonSingle{TItem}"/> to set the value.
    /// </summary>
    /// <param name="value"></param>
    internal Task SetSingleSelectValue(TItem value)
    {
        Value = new TItem[] { value };
        return SetComponentValueAsync();
    }
}
