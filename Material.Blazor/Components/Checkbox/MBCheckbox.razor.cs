using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// This is a general purpose Material Theme check box accepting a boolean as a bound value. This
/// check box does not implement indeteriminate state.
/// </summary>
public partial class MBCheckbox : InputComponent<bool>
{
    /// <summary>
    /// The checkbox's density.
    /// </summary>
    [Parameter] public MBDensity? Density { get; set; }


    /// <summary>
    /// Set to True if the checkbox is indeterminate.
    /// </summary>
    [Parameter]
    public bool IsIndeterminate { get; set; }
    private bool _cachedIsIndeterminate;


    /// <summary>
    /// The check box label.
    /// </summary>
    [Parameter] public string Label { get; set; }
    private string _cachedLabel;


    /// <summary>
    /// Inclusion of touch target
    /// </summary>
    [Parameter] public bool? TouchTarget { get; set; }

    private bool AppliedTouchTarget => CascadingDefaults.AppliedTouchTarget(TouchTarget);


    /// <summary>
    /// Gets or sets a callback that updates the bound value.
    /// </summary>
    [Parameter] public EventCallback<bool> IsIndeterminateChanged { get; set; }


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


    private bool CheckedValue
    {
        get => ComponentValue;
        set
        {
            _ = IsIndeterminateChanged.InvokeAsync(false);
            ComponentValue = value;
        }
    }

    private ElementReference ElementReference { get; set; }
    private ElementReference FormReference { get; set; }
    private MBBadge Badge { get; set; }

    private MBCascadingDefaults.DensityInfo DensityInfo => CascadingDefaults.GetDensityCssClass(CascadingDefaults.AppliedCheckboxDensity(Density));


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        _ = ConditionalCssClasses
            .AddIf(DensityInfo.CssClassName, () => DensityInfo.ApplyCssClass)
            .AddIf("mdc-checkbox--selected", () => Value)
            .AddIf("mdc-checkbox--disabled", () => AppliedDisabled);

        _cachedLabel = Label;
    }


    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync().ConfigureAwait(false);

        if (_cachedBadgeValue != BadgeValue || _cachedBadgeExited != BadgeExited)
        {
            _cachedBadgeValue = BadgeValue;
            _cachedBadgeExited = BadgeExited;

            if (Badge is not null)
            {
                EnqueueJSInteropAction(() => Badge.SetValueAndExited(BadgeValue, BadgeExited));
            }
        }

        if (_cachedIsIndeterminate != IsIndeterminate)
        {
            _cachedIsIndeterminate = IsIndeterminate;
            EnqueueJSInteropAction(UpdateIndeterminateStateAsync);
        }

        if (_cachedLabel != Label)
        {
            _cachedLabel = Label;
            AllowNextRender(true);
        }
    }


    /// <inheritdoc/>
    private protected override Task SetComponentValueAsync()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBCheckbox.setChecked", ElementReference, Value);
    }


    /// <inheritdoc/>
    private protected override Task OnDisabledSetAsync()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBCheckbox.setDisabled", ElementReference, AppliedDisabled);
    }


    /// <inheritdoc/>
    internal override Task InstantiateMcwComponent()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBCheckbox.init", ElementReference, FormReference, ComponentValue, IsIndeterminate);
    }


    private Task UpdateIndeterminateStateAsync()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBCheckbox.setIndeterminate", ElementReference, IsIndeterminate);
    }
}
