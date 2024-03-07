using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// A Material Theme single-thumb slider.
/// </summary>
public partial class MBSlider : InputComponent<decimal>
{
    /// <summary>
    /// The type of slider - defaults to <see cref="MBSliderType.Continuous"/>.
    /// </summary>
    [Parameter] public MBSliderType SliderType { get; set; } = MBSliderType.Continuous;


    /// <summary>
    /// The minimum slider value.
    /// </summary>
    [Parameter] public decimal ValueMin { get; set; } = 0;


    /// <summary>
    /// The maximum slider value.
    /// </summary>
    [Parameter] public decimal ValueMax { get; set; } = 100;


    /// <summary>
    /// The number of steps for a discrete slider. Note that ten steps will yield eleven thumb positions/tickmarks.
    /// </summary>
    [Parameter] public int NumSteps { get; set; } = 10;


    /// <summary>
    /// Specifies how slider events are emitted, see <see cref="MBInputEventType"/>.
    /// </summary>
    [Parameter] public MBInputEventType EventType { get; set; } = MBInputEventType.OnChange;


    /// <summary>
    /// For continuous input sets the debounce/throttle delay.
    /// </summary>
    [Parameter] public uint ContinuousInputDelay { get; set; } = 300;


    /// <summary>
    /// Number of decimal places for rounding and displaying values.
    /// </summary>
    [Parameter] public uint DecimalPlaces { get; set; } = 0;


    /// <summary>
    /// Value for the "aria-label" tag.
    /// </summary>
    [Parameter] public string AriaLabel { get; set; } = "Slider";


    private ElementReference MainReference { get; set; }
    private ElementReference ThumbReference { get; set; }
    private string Format { get; set; }
    private MarkupString InputMarkup { get; set; }
    private DotNetObjectReference<MBSlider> ObjectReference { get; set; }
    private decimal RangePercentDecimal { get; set; }
    private string ThumbOffset => $"calc({100 * RangePercentDecimal}% - 24px);";
    private int TabIndex { get; set; }
    private decimal ThumbEndPercent => 100 * RangePercentDecimal;
    private decimal ValueStepIncrement { get; set; }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        if (ValueMax <= ValueMin)
        {
            throw new ArgumentException($"{GetType()} must have ValueMax ({ValueMax}) greater than ValueMin ({ValueMin})");
        }

        if (Value < ValueMin || Value > ValueMax)
        {
            throw new ArgumentException($"{GetType()} must have Value ({Value}) between ValueMin ({ValueMin}) and ValueMax ({ValueMax})");
        }

        Value = Math.Round(Value, (int)DecimalPlaces);
        ValueMin = Math.Round(ValueMin, (int)DecimalPlaces);
        ValueMax = Math.Round(ValueMax, (int)DecimalPlaces);
        Format = $"F{DecimalPlaces}";

        TabIndex = AppliedDisabled ? -1 : 0;
        RangePercentDecimal = (Value - ValueMin) / (ValueMax - ValueMin);

        ValueStepIncrement = SliderType == MBSliderType.Continuous ? Convert.ToDecimal(Math.Pow(10, -DecimalPlaces)) : (ValueMax - ValueMin) / NumSteps;

        _ = ConditionalCssClasses
            .AddIf("mdc-slider--discrete", () => SliderType != MBSliderType.Continuous)
            .AddIf("mdc-slider--tick-marks", () => SliderType == MBSliderType.DiscreteWithTickmarks)
            .AddIf("mdc-slider--disabled", () => AppliedDisabled);

        var disabledClassMarkup = AppliedDisabled ? " mdc-slider--disabled" : "";
        var disabledAttributeMarkup = AppliedDisabled ? "disabled " : "";

        InputMarkup = new($"<input class=\"mdc-slider__input{disabledClassMarkup}\" type=\"range\" value=\"{Value.ToString(Format)}\" {disabledAttributeMarkup}step=\"{ValueStepIncrement}\" min=\"{ValueMin.ToString(Format)}\" max=\"{ValueMax.ToString(Format)}\" name=\"volume\" aria-label=\"{AriaLabel}\">");

        ObjectReference = DotNetObjectReference.Create(this);
    }


    private bool _disposed = false;
    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);

        if (_disposed)
        {
            return;
        }

        if (disposing)
        {
            ObjectReference?.Dispose();
        }

        _disposed = true;
    }


    /// <summary>
    /// For Material Theme to notify of slider value changes via JS Interop.
    /// </summary>
    [JSInvokable]
    public void NotifyChanged(decimal value)
    {
        ComponentValue = value;
    }


    /// <inheritdoc/>
    private protected override Task SetComponentValueAsync()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBSlider.setValue", MainReference, Value);
    }


    /// <inheritdoc/>
    private protected override Task OnDisabledSetAsync()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBSlider.setDisabled", MainReference, AppliedDisabled);
    }


    /// <inheritdoc/>
    internal override Task InstantiateMcwComponent()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBSlider.init", MainReference, ThumbReference, ThumbOffset, ObjectReference, EventType, ContinuousInputDelay, AppliedDisabled);
    }
}
