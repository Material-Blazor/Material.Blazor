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
        
        builder.OpenElement(0, "div");
        {
            builder.OpenElement(1, "div");
            {
                builder.AddAttribute(2, "class", @class);
                builder.AddAttribute(3, "style", checkboxStyle + style);
                builder.AddAttribute(4, "id", id);
                if (attributesToSplat.Any())
                {
                    builder.AddMultipleAttributes(5, attributesToSplat);
                }

                if (!string.IsNullOrWhiteSpace(LeadingLabelPLUS))
                {
                    var labelSpan =
                        "<span class=\"mdc-typography--body1\" style=\"margin-right: 1em;\">"
                        + LeadingLabelPLUS
                        + "</Span>";
                    builder.AddMarkupContent(6, "\r\n");
                    builder.AddMarkupContent(7, labelSpan);
                }

                builder.OpenElement(8, "md-checkbox");
                {
                    if (AppliedDisabled || IsDisabled)
                    {
                        builder.AddAttribute(9, "disabled");
                    }

                    if (Value)
                    {
                        builder.AddAttribute(10, "checked");
                    }

                    if (IsIndeterminate)
                    {
                        builder.AddAttribute(11, "indeterminate");
                    }

                    builder.AddAttribute(12, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, OnClickInternal));
                }
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
            }
            builder.CloseElement();
        }
        builder.CloseElement();
    }

    #endregion

    #region OnClickInternal

    private async Task OnClickInternal()
    {
        await Task.CompletedTask;
        ComponentValue = !Value;
    }

    #endregion

}
