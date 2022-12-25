using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
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


    private bool _isIndetermimate;
    /// <summary>
    /// Set to True if the checkbox is indeterminate.
    /// </summary>
    [Parameter]
    public bool IsIndeterminate
    {
        get => _isIndetermimate;
        set
        {
            if (value != _isIndetermimate)
            {
                _isIndetermimate = value;
                if (HasInstantiated)
                {
                    _ = UpdateIndeterminateStateAsync();
                }
            }
        }
    }


    /// <summary>
    /// The check box label.
    /// </summary>
    [Parameter] public string Label { get; set; }


    /// <summary>
    /// Inclusion of touch target
    /// </summary>
    [Parameter] public bool? TouchTarget { get; set; }

    private bool AppliedTouchTarget => CascadingDefaults.AppliedTouchTarget(TouchTarget);

    private Task UpdateIndeterminateStateAsync()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBCheckbox.setIndeterminate", ElementReference, IsIndeterminate);
    }

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


    private string badgeValue;
    /// <summary>
    /// The button's density.
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


    private bool CheckedValue
    {
        get => ComponentValue;
        set
        {
            _isIndetermimate = false;
            IsIndeterminateChanged.InvokeAsync(false);
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

        ConditionalCssClasses
            .AddIf(DensityInfo.CssClassName, () => DensityInfo.ApplyCssClass)
            .AddIf("mdc-checkbox--selected", () => Value)
            .AddIf("mdc-checkbox--disabled", () => AppliedDisabled);

        SetComponentValue += OnValueSetCallback;
        OnDisabledSet += OnDisabledSetCallback;
    }


    /// <summary>
    /// Callback for value the value setter.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected Task OnValueSetCallback() => InvokeJsVoidAsync("MaterialBlazor.MBCheckbox.setChecked", ElementReference, Value);


    /// <summary>
    /// Callback for value the Disabled value setter.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void OnDisabledSetCallback() => InvokeAsync(() => InvokeJsVoidAsync("MaterialBlazor.MBCheckbox.setDisabled", ElementReference, AppliedDisabled));


    /// <inheritdoc/>
    internal override Task InstantiateMcwComponent() => InvokeJsVoidAsync("MaterialBlazor.MBCheckbox.init", ElementReference, FormReference, ComponentValue, IsIndeterminate);
}
