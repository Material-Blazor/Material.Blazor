using Material.Blazor;
using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor.MD2;

/// <summary>
/// A Material Theme select.
/// </summary>
public partial class MBSelect<TItem> : SingleSelectComponent<TItem, MBSelectElement<TItem>>
{
#nullable enable annotations
    /// <summary>
    /// The select's label.
    /// </summary>
    [Parameter] public string Label { get; set; }


    /// <summary>
    /// The select's <see cref="MBSelectInputStyleMD2"/>.
    /// <para>Overrides <see cref="MBCascadingDefaults.SelectInputStyle"/></para>
    /// </summary>
    [Parameter] public MBSelectInputStyleMD2? SelectInputStyle { get; set; }


    /// <summary>
    /// Regular, fullwidth or fixed positioning/width.
    /// </summary>
    [Parameter] public MBMenuSurfacePositioningMD2 MenuSurfacePositioning { get; set; } = MBMenuSurfacePositioningMD2.Regular;


    /// <summary>
    /// The select's <see cref="MBTextAlignStyle"/>.
    /// <para>Overrides <see cref="MBCascadingDefaults.TextAlignStyle"/></para>
    /// </summary>
    [Parameter] public MBTextAlignStyle? TextAlignStyle { get; set; }


    /// <summary>
    /// The leading icon's descriptor. No leading icon shown if not set.
    /// </summary>
    [Parameter] public MBIconDescriptor? LeadingIconDescriptor { get; set; }


    /// <summary>
    /// The select's density.
    /// </summary>
    [Parameter] public MBDensity? Density { get; set; }


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


    private readonly string labelId = Utilities.GenerateUniqueElementName();
    private readonly string listboxId = Utilities.GenerateUniqueElementName();
    private readonly string selectedTextId = Utilities.GenerateUniqueElementName();


    private string AlignClass => Utilities.GetTextAlignClass(Material.Blazor.MBTextAlignStyle.Left);
    private MBDensity AppliedDensity => MBDensity.Default;
    private MBSelectInputStyleMD2 AppliedInputStyle => MBSelectInputStyleMD2.Outlined;
    private string FloatingLabelClass { get; set; } = "";
    private string MenuClass => MBMenu.GetMenuSurfacePositioningClass(MenuSurfacePositioning);
    private DotNetObjectReference<MBSelect<TItem>> ObjectReference { get; set; }
    private ElementReference SelectReference { get; set; }
    private string SelectedText { get; set; } = "";
    private bool ShowLabel => !string.IsNullOrWhiteSpace(Label);
    private MBBadge Badge { get; set; }


    internal class DensityInfoClass
    {
        public bool ApplyCssClass { get; set; }
        public string CssClassName { get; set; }
    }
    private DensityInfoClass DensityInfo
    {
        get
        {
            var d = new DensityInfoClass
            {
                ApplyCssClass = false,
                CssClassName = "\"dense-default\""
            };

            var suffix = AppliedInputStyle == MBSelectInputStyleMD2.Filled ? "--filled" : "--outlined";
            suffix += (LeadingIconDescriptor is null) ? "" : "-with-leading-icon";

            d.CssClassName += suffix;

            return d;
        }
    }



    /// <summary>
    /// Compares two values and returns true if both values are null, or if both values are not null and <paramref name="value1"/>.Equals(<paramref name="value2"/>)
    /// </summary>
    /// <param name="value1"></param>
    /// <param name="value2"></param>
    /// <returns></returns>
    private static bool NullAllowingEquals(TItem value1, TItem value2)
    {
        if (value1 == null)
        {
            return value2 == null;
        }
        else
        {
            return value1.Equals(value2);
        }
    }

    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        bool hasValue;
        TItem potentialComponentValue;

        (hasValue, potentialComponentValue) = ValidateItemList(Items, Material.Blazor.MBItemValidation.DefaultToFirst);

        if (hasValue)
        {
            ComponentValue = potentialComponentValue;
        }
        SelectedText = hasValue ? (Items.FirstOrDefault(i => NullAllowingEquals(i.SelectedValue, ComponentValue))?.LeadingLabel) : "";
        FloatingLabelClass = string.IsNullOrWhiteSpace(SelectedText) ? "" : "mdc-floating-label--float-above";

        _ = ConditionalCssClasses
            .AddIf(DensityInfo.CssClassName, () => DensityInfo.ApplyCssClass)
            .AddIf("mdc-select--filled", () => AppliedInputStyle == MBSelectInputStyleMD2.Filled)
            .AddIf("mdc-select--outlined", () => AppliedInputStyle == MBSelectInputStyleMD2.Outlined)
            .AddIf("mdc-select--no-label", () => !ShowLabel)
            .AddIf("mdc-select--with-leading-icon", () => !(LeadingIconDescriptor is null))
            .AddIf("mdc-select--disabled", () => AppliedDisabled);

        ObjectReference = DotNetObjectReference.Create(this);
    }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
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

        KeyGenerator = GetKeysFunc ?? delegate (TItem item) { return item; };
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
    public void NotifySelected(int index)
    {
        ComponentValue = Items.ElementAt(index).SelectedValue;
    }


    /// <<inheritdoc/>
    private protected override Task SetComponentValueAsync()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBSelect.setIndex", SelectReference, Items.Select(x => x.SelectedValue).ToList().IndexOf(Value));
    }


    /// <inheritdoc/>
    private protected override Task OnDisabledSetAsync()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBSelect.setDisabled", SelectReference, AppliedDisabled);
    }


    /// <inheritdoc/>
    internal override Task InstantiateMcwComponent()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBSelect.init", SelectReference, ObjectReference);
    }
}
