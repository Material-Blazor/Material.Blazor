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
            var rendSeq = 0;

            builder.OpenElement(rendSeq++, "md-slider");
            {
                if (attributesToSplat.Any())
                {
                    builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
                }

                builder.AddAttribute(rendSeq++, "class", @class);
                builder.AddAttribute(rendSeq++, "style", style);
                builder.AddAttribute(rendSeq++, "id", id);

                if (AppliedDisabled)
                {
                    builder.AddAttribute(rendSeq++, "disabled");
                }

                builder.AddAttribute(rendSeq++, "value", Value.ToString());
                if (SliderMax is not null)
                {
                    builder.AddAttribute(rendSeq++, "max", SliderMax.ToString());
                }
                if (SliderMin is not null)
                {
                    builder.AddAttribute(rendSeq++, "min", SliderMin.ToString());
                }
                if (SliderStep is not null)
                {
                    builder.AddAttribute(rendSeq++, "step", SliderStep.ToString());
                    if (SliderTicks)
                    {
                        builder.AddAttribute(rendSeq++, "ticks");
                    }
                }
                if (SliderIsLabeled)
                {
                    builder.AddAttribute(rendSeq++, "labeled");
                }
                builder.AddAttribute(rendSeq++, "onchange", EventCallback.Factory.Create<ChangeEventArgs>(this, HandleChange));
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
