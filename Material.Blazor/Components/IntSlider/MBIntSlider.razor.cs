using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// A Material Theme single-thumb slider.
/// </summary>
public partial class MBIntSlider : InputComponent<int>
{
    /// <summary>
    /// Shows tickmarks if true.
    /// </summary>
    [Parameter] public bool ShowTickmarks { get; set; } = false;


    /// <summary>
    /// The minimum slider value.
    /// </summary>
    [Parameter] public int ValueMin { get; set; } = 0;


    /// <summary>
    /// The maximum slider value.
    /// </summary>
    [Parameter] public int ValueMax { get; set; } = 100;


    /// <summary>
    /// Specifies how slider events are emitted, see <see cref="MBInputEventType"/>.
    /// </summary>
    [Parameter] public MBInputEventType EventType { get; set; } = MBInputEventType.OnChange;


    /// <summary>
    /// For continuous input sets the debounce/throttle delay.
    /// </summary>
    [Parameter] public uint ContinuousInputDelay { get; set; } = 300;


    /// <summary>
    /// Value for the "aria-label" tag.
    /// </summary>
    [Parameter] public string AriaLabel { get; set; } = "Slider";


    private decimal DecimalValue
    {
        get => ComponentValue;
        set => ComponentValue = Convert.ToInt32(Math.Round(value, 0));
    }


    private int NumSteps => ValueMax - ValueMin;
    private MBSliderType SliderType => ShowTickmarks ? MBSliderType.DiscreteWithTickmarks : MBSliderType.Discrete;


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        ForceShouldRenderToTrue = true;
    }
}
