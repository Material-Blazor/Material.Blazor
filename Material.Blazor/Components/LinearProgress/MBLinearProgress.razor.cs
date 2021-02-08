using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System;
using System.Threading.Tasks;

namespace Material.Blazor
{
    /// <summary>
    /// This is a general purpose Material Theme linear progress bar. Can be determinant or
    /// indeterminant. If determinant the value needs to be between 0 and 1.
    /// </summary>
    public partial class MBLinearProgress : InputComponent<double>
    {
        /// <summary>
        /// Makes the progress bar indeterminant if True.
        /// </summary>
        [Parameter] public MBLinearProgressType LinearProgressType { get; set; } = MBLinearProgressType.Indeterminate;


        /// <summary>
        /// Sets aria-label.
        /// </summary>
        [Parameter] public string AriaLabel { get; set; } = "";


        private double? _bufferValue = null;
        /// <summary>
        /// Sets the buffer value (no buffer if not set).
        /// </summary>
        [Parameter]
        public double? BufferValue
        {
            get => _bufferValue;
            set
            {
                if (value != _bufferValue)
                {
                    _bufferValue = value;
                    OnValueSetCallback(null, null);
                }
            }
        }


        private ElementReference ElementReference { get; set; }
        /// <summary>
        /// Set aria-valuenow to an immutable value because MB doesn't want us to re-render,
        /// however we need to allow ShouldRender to return true for class changes.
        /// </summary>
        private double IntialValue { get; set; }
        private double MyBufferValue => (BufferValue is null) ? 1 : (double)BufferValue;


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ForceShouldRenderToTrue = true;
            IntialValue = Value;

            ClassMapperInstance
                .Add("mdc-linear-progress")
                .AddIf("mdc-linear-progress--indeterminate", () => LinearProgressType == MBLinearProgressType.Indeterminate)
                .AddIf("mdc-linear-progress--reversed", () => LinearProgressType == MBLinearProgressType.ReversedDeterminate)
                .AddIf("mdc-linear-progress--closed", () => LinearProgressType == MBLinearProgressType.Closed);

            SetComponentValue += OnValueSetCallback;
        }


        /// <summary>
        /// Callback for value the value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnValueSetCallback(object sender, EventArgs e) => InvokeAsync(async () => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBLinearProgress.setProgress", ElementReference, Value, MyBufferValue));


        /// <inheritdoc/>
        private protected override async Task InstantiateMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBLinearProgress.init", ElementReference, Value, MyBufferValue);


        /// <inheritdoc/>
        private protected override async Task DestroyMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBLinearProgress.destroy", ElementReference);
    }
}
