using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// This is a general purpose Material Theme checkbox.
/// </summary>
public sealed class MBCheckbox : InputComponent<bool>
{
    /// <summary>
    /// Determines if the checkbox is disabled.
    /// </summary>
    [Parameter] public bool IsDisabled { get; set; } = false;

    /// <summary>
    /// Determines if the checkbox is indeterminate.
    /// </summary>
    [Parameter] public bool IsIndeterminate { get; set; } = false;

    /// <summary>
    /// Provides a leading label for the checkbox.
    /// </summary>
    [Parameter] public string LeadingLabelPLUS { get; set; }

    /// <summary>
    /// Provides a trailing label for the checkbox.
    /// </summary>
    [Parameter] public string TrailingLabelPLUS { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToArray();

        if (!string.IsNullOrWhiteSpace(LeadingLabelPLUS) || !string.IsNullOrWhiteSpace(TrailingLabelPLUS))
        {
            builder.OpenElement(0, "p");
            builder.AddAttribute(1, "style", "display: flex; flex-flow: row nowrap; align-items: center;");

            if (!string.IsNullOrWhiteSpace(LeadingLabelPLUS))
            {
                var labelSpan =
                    "<span class=\"mdc-typography--body1\" style=\"margin-right: 1em;\">"
                    + LeadingLabelPLUS
                    + "</Span>";
                builder.AddMarkupContent(2, "\r\n");
                builder.AddMarkupContent(3, labelSpan);
            }
        }

        builder.OpenElement(4, "md-checkbox");

        if (attributesToSplat.Any())
        {
            builder.AddMultipleAttributes(5, attributesToSplat);
        }

        if (AppliedDisabled || IsDisabled)
        {
            builder.AddAttribute(6, "disabled");
        }

        if (Value)
        {
            builder.AddAttribute(7, "checked");
        }

        if (IsIndeterminate)
        {
            builder.AddAttribute(8, "indeterminate");
        }

        builder.AddAttribute(9, "class", @class);
        builder.AddAttribute(10, "style", style);
        builder.AddAttribute(11, "id", id);
        builder.AddAttribute(12, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, OnClick));
        builder.CloseElement();

        if (!string.IsNullOrWhiteSpace(TrailingLabelPLUS))
        {
            var labelSpan =
                "<span class=\"mdc-typography--body1\" style=\"margin-left: 1em;\">"
                + TrailingLabelPLUS
                + "</Span>";
            builder.AddMarkupContent(13, "\r\n");
            builder.AddMarkupContent(14, labelSpan);
        }

        if (!string.IsNullOrWhiteSpace(LeadingLabelPLUS) || !string.IsNullOrWhiteSpace(TrailingLabelPLUS))
        {
            builder.CloseElement();
        }
    }


    private async Task OnClick()
    {
        Value = !Value;
        await ValueChanged.InvokeAsync(Value);
    }
}
