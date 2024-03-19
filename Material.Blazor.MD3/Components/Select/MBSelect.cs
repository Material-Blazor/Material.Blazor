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

    #region OnInitializedAsync

    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        ComponentValue = ValidateItemList(Items, CascadingDefaults.AppliedItemValidation(ItemValidation));

        StringValue = Value is null ? "" : Value.ToString();
    }

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

            var componentName = CascadingDefaults.AppliedStyle(SelectInputStyle) switch
            {
                MBSelectInputStyle.Filled => "md-filled-select",
                MBSelectInputStyle.Outlined => "md-outlined-select",
                _ => throw new System.Exception("Unknown SelectInputStyle")
            };

            builder.OpenElement(0, componentName);
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

                if (!string.IsNullOrWhiteSpace(Label))
                {
                    builder.AddAttribute(6, "label", Label);
                }

                if (Required)
                {
                    builder.AddAttribute(7, "required");
                }

                builder.AddAttribute(8, "value", StringValue);
                builder.AddAttribute(9, "onchange", EventCallback.Factory.Create<ChangeEventArgs>(this, HandleChange));
                //builder.SetUpdatesAttributeName("StringValue");

                var baseRendSeq = 100;
                foreach (var sse in Items)
                {
                    if (sse is not null)
                    {
                        builder.OpenElement(baseRendSeq + 1, "md-select-option");
                        {
                            if (sse.SelectedValue is not null)
                            {
                                builder.AddAttribute(baseRendSeq + 2, "value", sse.SelectedValue.ToString());
                                if (sse.SelectedValue.ToString().ToLower().Equals(StringValue.ToLower()))
                                {
                                    builder.AddAttribute(baseRendSeq + 3, "selected");
                                }
                            }

                            if (sse.TrailingLabel is not null)
                            {
                                builder.OpenElement(baseRendSeq + 4, "div");
                                {
                                    builder.AddAttribute(baseRendSeq + 5, "slot", "headline");
                                    builder.AddContent(baseRendSeq + 6, sse.TrailingLabel);
                                }
                                builder.CloseElement();
                            }
                        }
                        builder.CloseElement();
                    }
                    baseRendSeq += 100;
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
            ConsoleLog("   HC - Current ComponentValue: " + ComponentValue?.ToString() ?? "null");
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

        ConsoleLog("OnParametersSetAsync");
        ConsoleLog("   OPSA - Label: " + Label);
        ConsoleLog("   OPSA - Current ComponentValue: " + ComponentValue?.ToString() ?? "null");
        ConsoleLog("   OPSA - Current Value: " + Value?.ToString() ?? "null");

        StringValue = Value is null ? "" : Value.ToString();
    }

    #endregion

    #region ZZZ - debug logging

    public void ConsoleLog(string message)
    {
#if LOGGING
        LoggingService.LogInformation("SELECT: " + message);
#endif
    }

    #endregion

}
