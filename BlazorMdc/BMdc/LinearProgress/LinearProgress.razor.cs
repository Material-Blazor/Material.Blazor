using BMdcBase;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BMdc
{
    /// <summary>
    /// This is a general purpose Material Theme linear progress bar. Can be determinant or
    /// indeterminant. If determinant the value needs to be between 0 and 1.
    /// </summary>
    public partial class LinearProgress : BMdcBase.InputComponentBase<double>
    {
        /// <summary>
        /// Makes the progress bar indeterminant if True.
        /// </summary>
        [Parameter] public BMdcModel.LinearProgressType LinearProgressType { get; set; } = BMdcModel.LinearProgressType.Indeterminate;


        /// <summary>
        /// Sets aria-label.
        /// </summary>
        [Parameter] public string AriaLabel { get; set; } = "";


        private double? _bufferValue = null;
        /// <summary>
        /// Sets the buffer value (no buffer if not set).
        /// </summary>
        [Parameter] public double? BufferValue
        {
            get => _bufferValue;
            set
            {
                if (value != _bufferValue)
                {
                    _bufferValue = value;
                    OnValueSet();
                }    
            }
        }


        private ElementReference ElementReference { get; set; }
        /// <summary>
        /// Set aria-valuenow to an immutable value because MT doesn't want us to re-render,
        /// however we need to allow ShouldRender to return true for class changes.
        /// </summary>
        private double IntialValue { get; set; }
        private double MyBufferValue => (BufferValue is null) ? 1 : (double)BufferValue;


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ForceShouldRenderToTrue = true;
            IntialValue = Value;

            ClassMapper
                .Add("mdc-linear-progress")
                .AddIf("mdc-linear-progress--indeterminate", () => LinearProgressType == BMdcModel.LinearProgressType.Indeterminate)
                .AddIf("mdc-linear-progress--reversed", () => LinearProgressType == BMdcModel.LinearProgressType.ReversedDeterminate)
                .AddIf("mdc-linear-progress--closed", () => LinearProgressType == BMdcModel.LinearProgressType.Closed);
        }


        /// <inheritdoc/>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();
        }


        /// <inheritdoc/>
        protected override void OnValueSet() => InvokeAsync(async () => await JsRuntime.InvokeAsync<object>("BlazorMdc.linearProgress.setProgress", ElementReference, Value, MyBufferValue));


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.linearProgress.init", ElementReference, Value, MyBufferValue);
    }
}
