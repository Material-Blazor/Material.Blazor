using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;

using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// This is a general purpose Material Theme checkbox.
/// </summary>
public sealed class MBCheckbox : InputComponent<bool>
{
    #region members

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



    private string checkboxStyle { get; } = "display: flex; flex-direction: row; flex-grow: 1; align-items: center;";

    #endregion

    #region BuildRenderTree

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToArray();
        var rendSeq = 0;
        builder.OpenElement(rendSeq++, "div");
        {
            builder.OpenElement(rendSeq++, "div");
            {
                builder.AddAttribute(rendSeq++, "class", @class);
                builder.AddAttribute(rendSeq++, "style", checkboxStyle + style);
                builder.AddAttribute(rendSeq++, "id", id);
                if (attributesToSplat.Any())
                {
                    builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
                }

                if (!string.IsNullOrWhiteSpace(LeadingLabelPLUS))
                {
                    var labelSpan =
                        "<span class=\"mdc-typography--body1\" style=\"margin-right: 1em;\">"
                        + LeadingLabelPLUS
                        + "</Span>";
                    builder.AddMarkupContent(rendSeq++, "\r\n");
                    builder.AddMarkupContent(rendSeq++, labelSpan);
                }

                builder.OpenElement(rendSeq++, "md-checkbox");
                {
                    if (AppliedDisabled || IsDisabled)
                    {
                        builder.AddAttribute(rendSeq++, "disabled");
                    }

                    if (Value)
                    {
                        builder.AddAttribute(rendSeq++, "checked");
                    }

                    if (IsIndeterminate)
                    {
                        builder.AddAttribute(rendSeq++, "indeterminate");
                    }

                    builder.AddAttribute(rendSeq++, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, OnClickInternal));
                }
                builder.CloseElement();

                if (!string.IsNullOrWhiteSpace(TrailingLabelPLUS))
                {
                    var labelSpan =
                        "<span class=\"mdc-typography--body1\" style=\"margin-left: 1em;\">"
                        + TrailingLabelPLUS
                        + "</Span>";
                    builder.AddMarkupContent(rendSeq++, "\r\n");
                    builder.AddMarkupContent(rendSeq++, labelSpan);
                }
            }
            builder.CloseElement();
        }
        builder.CloseElement();
    }

    #endregion

    #region OnClickInternal

    private async Task OnClickInternal()
    {
        Value = !Value;
        await ValueChanged.InvokeAsync(Value);
    }

    #endregion

}
