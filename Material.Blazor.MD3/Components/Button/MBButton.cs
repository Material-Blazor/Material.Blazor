using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// This is a general purpose Material Theme button.
/// </summary>
public sealed class MBButton : ComponentFoundation
{
    #region members

    [Parameter] public MBDensity Density { get; set; }
    [Parameter] public MBIconDescriptor IconDescriptor { get; set; }
    [Parameter] public bool IconIsTrailing { get; set; }
    [Parameter] public MBButtonStyle? ButtonStyle { get; set; }
    [Parameter] public string Label { get; set; }

    #endregion

    #region BuildRenderTree
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToArray();
        var rendSeq = 0;

        BuildRenderTreeWorker(
            builder,
            ref rendSeq,
            CascadingDefaults,
            attributesToSplat,
            @class,
            style,
            id,
            AppliedDisabled,
            ButtonStyle,
            IconDescriptor,
            IconIsTrailing,
            Label,
            null,
            null);
    }

    #endregion

    #region BuildRenderTreeWorker

    public static void BuildRenderTreeWorker(
        RenderTreeBuilder builder,
        ref int rendSeq,
        MBCascadingDefaults cascadingDefaults,
        KeyValuePair<string, object>[] attributesToSplat,
        string classString,
        string styleString,
        string idString,
        bool appliedDisabled,
        MBButtonStyle? buttonStyle,
        MBIconDescriptor iconDescriptor,
        bool iconIsTrailing,
        string label,
        string formId,
        string buttonValue)
    {
        var componentName = cascadingDefaults.AppliedButtonStyle(buttonStyle) switch
        {
            MBButtonStyle.Elevated => "md-elevated-button",
            MBButtonStyle.Filled => "md-filled-button",
            MBButtonStyle.FilledTonal => "md-filled-tonal-button",
            MBButtonStyle.Outlined => "md-outlined-button",
            MBButtonStyle.Text => "md-text-button",
            _ => throw new System.Exception("Unknown ButtonStyle")
        };

        builder.OpenElement(rendSeq, componentName);
        {
            builder.AddAttribute(rendSeq + 1, "class", classString);
            builder.AddAttribute(rendSeq + 2, "style", styleString);
            builder.AddAttribute(rendSeq + 3, "id", idString);
            if (attributesToSplat.Any())
            {
                builder.AddMultipleAttributes(rendSeq + 4, attributesToSplat);
            }

            if (appliedDisabled)
            {
                rendSeq = 100;
                builder.AddAttribute(rendSeq + 5, "disabled");
            }

            if (iconIsTrailing)
            {
                builder.AddAttribute(rendSeq + 6, "trailing-icon");
            }

            rendSeq += 10;
            if (iconDescriptor is not null)
            {
                MBIcon.BuildRenderTreeWorker(
                    builder,
                    ref rendSeq,
                    cascadingDefaults,
                    null,
                    "",
                    "",
                    "",
                    iconDescriptor,
                    "icon");
            }

            rendSeq += 10;
            if (!string.IsNullOrWhiteSpace(formId))
            {
                builder.AddAttribute(rendSeq, "form", formId);
            }

            rendSeq += 10;
            if (!string.IsNullOrWhiteSpace(buttonValue))
            {
                builder.AddAttribute(rendSeq, "value", buttonValue);
            }

            rendSeq += 10;
            if (!string.IsNullOrWhiteSpace(label))
            {
                builder.AddContent(rendSeq++, label);
            }
            rendSeq += 10;
        }
        builder.CloseElement();

        // Consider throttle

        //    builder.AddAttribute(rendSeq++, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, OnClickInternal));
        return;
    }

    #endregion

    #region OnClickInternal

    private async Task OnClickInternal(MouseEventArgs args)
    {
        await Task.CompletedTask;
        //Value = !Value;
        //await ValueChanged.InvokeAsync(Value);
    }

    #endregion

}
