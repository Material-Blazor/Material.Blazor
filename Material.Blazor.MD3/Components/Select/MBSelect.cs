using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.JSInterop;

using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// This is a general purpose Material Theme select.
/// </summary>
public class MBSelect<TItem> : SingleSelectComponent<TItem, MBSingleSelectElement<TItem>>
{
    #region members

    /// <summary>
    /// The select's density.
    /// </summary>
    [Parameter] public MBDensity? Density { get; set; }

    /// <summary>
    /// The select's label.
    /// </summary>
    [Parameter] public string Label { get; set; }


    /// <summary>
    /// The select has a required value.
    /// </summary>
    [Parameter] public bool Required { get; set; }

    /// <summary>
    /// The select's <see cref="MBSelectInputStyle"/>.
    /// <para>Overrides <see cref="MBCascadingDefaults.SelectInputStyle"/></para>
    /// </summary>
    [Parameter] public MBSelectInputStyle? SelectInputStyle { get; set; }



    private static Object LifecycleGate = new object();
    private string StringValue { get; set; }

    #endregion

    #region BuildRenderTree
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        lock (LifecycleGate)
        {
            ConsoleLog("BuildRenderTree");
            ConsoleLog("   BRT - Label: " + Label);
            ConsoleLog("   BRT - StringValue: " + StringValue);

            var attributesToSplat = AttributesToSplat().ToArray();
            var rendSeq = 0;

            var componentName = CascadingDefaults.AppliedStyle(SelectInputStyle) switch
            {
                MBSelectInputStyle.Filled => "md-filled-select",
                MBSelectInputStyle.Outlined => "md-outlined-select",
                _ => throw new System.Exception("Unknown SelectInputStyle")
            };

            builder.OpenElement(rendSeq++, componentName);
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

                if (!string.IsNullOrWhiteSpace(Label))
                {
                    builder.AddAttribute(rendSeq++, "label", Label);
                }

                if (Required)
                {
                    builder.AddAttribute(rendSeq++, "required");
                }

                builder.AddAttribute(rendSeq++, "value", StringValue);
                builder.AddAttribute(rendSeq++, "onchange", EventCallback.Factory.Create<ChangeEventArgs>(this, HandleChange));
                builder.SetUpdatesAttributeName("StringValue");

                foreach (var sse in Items)
                {
                    if (sse is not null)
                    {
                        builder.OpenElement(rendSeq++, "md-select-option");
                        {
                            if (sse.SelectedValue is not null)
                            {
                                builder.AddAttribute(rendSeq++, "value", sse.SelectedValue.ToString());
                                if (sse.SelectedValue.ToString().ToLower().Equals(StringValue.ToLower()))
                                {
                                    builder.AddAttribute(rendSeq++, "selected");
                                }
                            }

                            if (sse.TrailingLabel is not null)
                            {
                                builder.OpenElement(rendSeq++, "div");
                                {
                                    builder.AddAttribute(rendSeq++, "slot", "headline");
                                    builder.AddContent(rendSeq++, sse.TrailingLabel);
                                }
                                builder.CloseElement();
                            }
                        }
                        builder.CloseElement();
                    }
                }

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
            ConsoleLog("   HC - Label: " + Label);
            ConsoleLog("   HC - Args.Value: " + (string)args.Value);
            ConsoleLog("   HC - Current ComponentValue: " + ComponentValue.ToString());
            ConsoleLog("   HC - Setting ComponentValue to Args.Value");
            StringValue = (string)args.Value;
            TypeConverter typeConverter = TypeDescriptor.GetConverter(typeof(TItem));
            ComponentValue = (TItem)typeConverter.ConvertFromString(StringValue);
        }
    }

    #endregion

    #region OnParametersSetAsync

    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();

        ComponentValue = ValidateItemList(Items, CascadingDefaults.AppliedItemValidation(ItemValidation));

        StringValue = Value is null ? "" : Value.ToString();

        ConsoleLog("OnParametersSetAsync");
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
