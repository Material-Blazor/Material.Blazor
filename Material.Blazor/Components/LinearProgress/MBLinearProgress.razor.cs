using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Material.Blazor;

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
    private MBLinearProgressType cachedLinearProgressType = MBLinearProgressType.Indeterminate;


    /// <summary>
    /// Sets aria-label.
    /// </summary>
    [Parameter] public string AriaLabel { get; set; } = "";


    /// <summary>
    /// Sets the buffer value (no buffer if not set).
    /// </summary>
    [Parameter] public double? BufferValue { get; set; }
    private double? _cachedBufferValue = null;


    private ElementReference ElementReference { get; set; }
    /// <summary>
    /// Set aria-valuenow to an immutable value because MB doesn't want us to re-render,
    /// however we need to allow ShouldRender to return true for class changes.
    /// </summary>
    private double InitialValue { get; set; }
    private double MyBufferValue => (BufferValue is null) ? 1 : (double)BufferValue;


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        cachedLinearProgressType = LinearProgressType;

        ForceShouldRenderToTrue = true;
        InitialValue = Value;

        _ = ConditionalCssClasses
            .AddIf("mdc-linear-progress--indeterminate", () => LinearProgressType == MBLinearProgressType.Indeterminate)
            .AddIf("mdc-linear-progress--closed", () => LinearProgressType == MBLinearProgressType.Closed);
    }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync().ConfigureAwait(false);

        if (_cachedBufferValue != BufferValue)
        {
            _cachedBufferValue = BufferValue;
            EnqueueJSInteropAction(SetComponentValueAsync);
        }
    }


    /// <inheritdoc/>
    private protected override Task SetComponentValueAsync()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBLinearProgress.setProgress", ElementReference, Value, MyBufferValue);
    }


    /// <inheritdoc/>
    internal override Task InstantiateMcwComponent()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBLinearProgress.init", ElementReference, Value, MyBufferValue);
    }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
        
        if (cachedLinearProgressType != LinearProgressType)
        {
            cachedLinearProgressType = LinearProgressType;
            await InvokeJsVoidAsync("MaterialBlazor.MBLinearProgress.restartAnimation", ElementReference);
        }
    }
}
