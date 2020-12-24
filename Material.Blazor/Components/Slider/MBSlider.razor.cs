using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor
{
    /// <summary>
    /// A Material Theme single-thumb slider.
    /// </summary>
    public partial class MBSlider : InputComponent<double>
    {
        /// <summary>
        /// The type of slider - defaults to <see cref="MBSliderType.Continuous"/>.
        /// </summary>
        [Parameter] public MBSliderType SliderType { get; set; } = MBSliderType.Continuous;


        /// <summary>
        /// The minimum slider value.
        /// </summary>
        [Parameter] public double ValueMin { get; set; } = 0;


        /// <summary>
        /// The maximum slider value.
        /// </summary>
        [Parameter] public double ValueMax { get; set; } = 100;


        /// <summary>
        /// The number of steps for a discrete slider. Note that ten steps will yield eleven thumb positions/tickmarks.
        /// </summary>
        [Parameter] public int NumSteps { get; set; } = 10;


        /// <summary>
        /// Specifies how slider events are emitted, see <see cref="MBSliderEventType"/>.
        /// </summary>
        [Parameter] public MBSliderEventType EventType { get; set; } = MBSliderEventType.ThumbUp;


        /// <summary>
        /// For continuous input sets the throttle delay.
        /// </summary>
        [Parameter] public uint ContinuousInputDebounceDelay { get; set; } = 300;


        /// <summary>
        /// Number of decimal places for rounding and displaying values.
        /// </summary>
        [Parameter] public uint DecimalPlaces { get; set; } = 0;


        /// <summary>
        /// Value for the "aria-label" tag.
        /// </summary>
        [Parameter] public string AriaLabel { get; set; } = "Slider";


        private double DataStep { get; set; }
        private ElementReference ElementReference { get; set; }
        private string Format { get; set; }
        private Dictionary<string, object> MyAttributes { get; set; }
        private IDisposable ObjectReference { get; set; }
        private int TabIndex { get; set; }
        private double ThumbEndPercent { get; set; }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            Value = Math.Round(Value, (int)DecimalPlaces);
            ValueMin = Math.Round(ValueMin, (int)DecimalPlaces);
            ValueMax = Math.Round(ValueMax, (int)DecimalPlaces);
            Format = $"N{DecimalPlaces}";
            TabIndex = AppliedDisabled ? -1 : 0;
            ThumbEndPercent = 100 * (Value - ValueMin) / (ValueMax - ValueMin);

            if (ValueMax <= ValueMin)
            {
                throw new ArgumentException($"{GetType()} must have ValueMax ({ValueMax}) greater than ValueMin ({ValueMin})");
            }

            if (Value < ValueMin || Value > ValueMax)
            {
                throw new ArgumentException($"{GetType()} must have Value ({Value}) between ValueMin ({ValueMin}) and ValueMax ({ValueMax})");
            }

            DataStep = (ValueMax - ValueMin) / NumSteps;

            ClassMapperInstance
                .Add("mdc-slider")
                .AddIf("mdc-slider--discrete", () => SliderType != MBSliderType.Continuous)
                .AddIf("mdc-slider--tick-marks", () => SliderType == MBSliderType.DiscreteWithTickmarks)
                .AddIf("mdc-slider--disabled", () => AppliedDisabled);

            MyAttributes =
                (from a in AttributesToSplat()
                 select new KeyValuePair<string, object>(a.Key, a.Value))
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            if (SliderType != MBSliderType.Continuous)
            {
                MyAttributes.Add("data-step", DataStep.ToString(Format));
            }

            SetComponentValue += OnValueSetCallback;
            OnDisabledSet += OnDisabledSetCallback;

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
        /// For Material Theme to notify of slider value changes via JS Interop.
        /// </summary>
        [JSInvokable("NotifyChangedAsync")]
        public async Task NotifyChangedAsync(double value)
        {
            ComponentValue = value;
            await Task.CompletedTask;
        }


        /// <summary>
        /// Callback for value the value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnValueSetCallback(object sender, EventArgs e) => InvokeAsync(async () => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSlider.setValue", ElementReference, Value));


        /// <summary>
        /// Callback for value the Disabled value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnDisabledSetCallback(object sender, EventArgs e) => InvokeAsync(async () => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSlider.setDisabled", ElementReference, AppliedDisabled));


        /// <inheritdoc/>
        private protected override async Task InstantiateMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSlider.init", ElementReference, ObjectReference, EventType, ContinuousInputDebounceDelay);


        /// <inheritdoc/>
        private protected override async Task DestroyMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSlider.destroy", ElementReference);
    }
}