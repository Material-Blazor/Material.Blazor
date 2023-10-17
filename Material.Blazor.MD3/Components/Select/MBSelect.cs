using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;

using System;
using System.Linq;
using System.Linq.Expressions;
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
    /// The select's <see cref="MBSelectInputStyleMD2"/>.
    /// <para>Overrides <see cref="MBCascadingDefaults.SelectInputStyle"/></para>
    /// </summary>
    [Parameter] public MBSelectInputStyle? SelectInputStyle { get; set; }

    #endregion

    #region BuildRenderTree
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
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
            builder.AddAttribute(rendSeq++, "class", @class);
            builder.AddAttribute(rendSeq++, "style", style);
            builder.AddAttribute(rendSeq++, "id", id);

            if (!string.IsNullOrWhiteSpace(Label))
            {
                builder.AddAttribute(rendSeq++, "label", Label);
            }

            if (AppliedDisabled)
            {
                builder.AddAttribute(rendSeq++, "disabled");
            }

            if (attributesToSplat.Any())
            {
                builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
            }

            if (Required)
            {
                builder.AddAttribute(rendSeq++, "required");
            }


            foreach (var sse in Items)
            {
                builder.OpenElement(rendSeq++, "md-select-option");
                {
                    builder.AddAttribute(rendSeq++, "value", sse.SelectedValue);
                    builder.OpenElement(rendSeq++, "div");
                    {
                        builder.AddAttribute(rendSeq++, "slot", "headline");
                        builder.AddContent(rendSeq++, sse.TrailingLabel);
                    }
                    builder.CloseElement();
                }
                builder.CloseElement();
            }

        }
        builder.CloseElement();

    }

    #endregion

    #region OnClickInternal

    private async Task OnClickInternal()
    {
        //       Value = !Value;
        await ValueChanged.InvokeAsync(Value);
    }

    #endregion

}
