using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// This is a general purpose Material Theme switch.
/// </summary>
public sealed class MBSwitch : InputComponent<bool>
{
    /// <summary>
    /// Determines whether the switch shows icons.
    /// </summary>
    [Parameter] public bool? Icons { get; set; }

    /// <summary>
    /// Determines shows icons only in the selected state.
    /// </summary>
    [Parameter] public bool? ShowOnlySelectedIcon { get; set; }

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

        builder.OpenElement(4, "md-switch");

        if (attributesToSplat.Any())
        {
            builder.AddMultipleAttributes(5, attributesToSplat);
        }

        if (AppliedDisabled)
        {
            builder.AddAttribute(6, "disabled");
        }

        builder.AddAttribute(7, "class", @class);
        builder.AddAttribute(8, "style", style);
        builder.AddAttribute(9, "id", id);
        builder.AddAttribute(10, "selected", BindConverter.FormatValue(Value));
        builder.AddAttribute(11, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, OnClick));
        builder.AddAttribute(8, "icons", CascadingDefaults.AppliedSwitchIcons(Icons));
        builder.AddAttribute(9, "showOnlySelectedIcon", CascadingDefaults.AppliedSwitchSwitchShowOnlySelectedIcon(ShowOnlySelectedIcon));

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
