using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.JSInterop;

using System;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// This is a general purpose Material Theme slider.
/// </summary>
public class MBSlider<TItem> : InputComponent<TItem> 
    where TItem : struct, INumber<TItem>
{
    #region members

#nullable enable annotations

    /// <summary>
    /// The slider's density.
    /// </summary>
    [Parameter] public MBDensity? Density { get; set; }

    /// <summary>
    /// The slider's label.
    /// </summary>
    [Parameter] public string Label { get; set; }

    /// <summary>
    /// The slide shows labels.
    /// </summary>
    [Parameter] public bool SliderIsLabeled { get; set; }

    /// <summary>
    /// The slider's <see cref="MBSlider"/> maximum value.
    /// </summary>
    [Parameter] public TItem? SliderMax { get; set; } = null!;

    /// <summary>
    /// The slider's <see cref="MBSlider"/> minimum value.
    /// </summary>
    [Parameter] public TItem? SliderMin { get; set; } = null!;

    /// <summary>
    /// The slider's <see cref="MBSlider"/> step interval.
    /// Setting a value turns the slider into a discrete slider
    /// </summary>
    [Parameter] public TItem? SliderStep { get; set; } = null!;

    /// <summary>
    /// The slider's <see cref="MBSlider"/> display of ticks.
    /// Only valid on discrete sliders.
    /// </summary>
    [Parameter] public bool SliderTicks { get; set; }

#nullable disable annotations



    private static Object LifecycleGate = new object();

    #endregion

    #region BuildRenderTree
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        lock (LifecycleGate)
        {
            var attributesToSplat = AttributesToSplat().ToArray();

            builder.OpenElement(0, "md-slider");
            {
                if (attributesToSplat.Any())
                {
                    builder.AddMultipleAttributes(1, attributesToSplat);
                }

                builder.AddAttribute(2, "class", @class);
                builder.AddAttribute(3, "style", style);
                builder.AddAttribute(4, "id", id);

                if (AppliedDisabled)
                {
                    builder.AddAttribute(5, "disabled");
                }

                builder.AddAttribute(6, "value", Value.ToString());
                if (SliderMax is not null)
                {
                    builder.AddAttribute(7, "max", SliderMax.ToString());
                }
                if (SliderMin is not null)
                {
                    builder.AddAttribute(8, "min", SliderMin.ToString());
                }
                if (SliderStep is not null)
                {
                    builder.AddAttribute(9, "step", SliderStep.ToString());
                    if (SliderTicks)
                    {
                        builder.AddAttribute(10, "ticks");
                    }
                }
                if (SliderIsLabeled)
                {
                    builder.AddAttribute(11, "labeled");
                }
                ///todo -- figure out how to notify of changed value
                builder.AddAttribute(12, "onchange", EventCallback.Factory.Create<ChangeEventArgs>(this, HandleChange));
                //builder.SetUpdatesAttributeName("StringValue");


            }
            builder.CloseElement();
        }
    }

    #endregion

    #region HandleChange

    private async Task HandleChange(ChangeEventArgs args)
    {
        await Task.CompletedTask;
        lock (LifecycleGate)
        {
            ConsoleLog("HandleChange");
            ConsoleLog("   HC - Args.Value: " + (string)args.Value);
            ConsoleLog("   HC - Setting ComponentValue");
            TypeConverter typeConverter = TypeDescriptor.GetConverter(typeof(TItem));
            ComponentValue = (TItem)typeConverter.ConvertFromString((string)args.Value);
        }
    }

    #endregion

    #region ZZZ - debug logging

    [Inject] public IJSRuntime JSRuntime { get; set; }

    public void ConsoleLog(string message)
    {
        JSRuntime.InvokeVoidAsync("console.log", message);
    }

    #endregion

}
