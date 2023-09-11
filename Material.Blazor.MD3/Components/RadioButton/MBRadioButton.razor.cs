using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// This is a general purpose Material Theme radio button. Accepts a generic class TItem
/// and displays as checked if <see cref="InputComponent{T}.Value"/> equals <see cref="TargetCheckedValue"/>.
/// </summary>
public partial class MBRadioButton<TItem> : InputComponent<TItem>
{
    #region members

    /// <summary>
    /// The radio button's density.
    /// </summary>
    [Parameter] public MBDensity? Density { get; set; }

    /// <summary>
    /// Determines if the radiobutton is disabled.
    /// </summary>
    [Parameter] public bool IsDisabled { get; set; } = false;

    /// <summary>
    /// Provides a leading label for the radiobutton.
    /// </summary>
    [Parameter] public string LeadingLabelPLUS { get; set; }

    /// <summary>
    /// <see cref="InputComponent{T}.Value"/> is set to this when the 
    /// radio button is clicked. If the consumer sets <see cref="InputComponent{T}.Value"/>
    /// to this the radio state will change to checked, or cleared for any other value.
    /// </summary>
    [Parameter] public TItem TargetCheckedValue { get; set; }

    /// <summary>
    /// Provides a trailing label for the radiobutton.
    /// </summary>
    [Parameter] public string TrailingLabelPLUS { get; set; }

    /// <summary>
    /// The radio button group name. This is applied to a group of radio buttons
    /// so Material Theme can identify them as representing different values of the
    /// same property.
    /// </summary>
    [Parameter] public string RadioGroupName { get; set; }



    private string radioStyle { get; } = "display: flex; flex-direction: row; flex-grow: 0; align-items: flex-start;";

    #endregion

    #region BuildRenderTree

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToArray();
        var rendSeq = 0;

        builder.OpenElement(rendSeq++, "div");
        {
            builder.AddAttribute(rendSeq++, "class", @class);
            builder.AddAttribute(rendSeq++, "style", radioStyle + style);
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

            builder.OpenElement(rendSeq++, "md-radio");
            {
                if (AppliedDisabled || IsDisabled)
                {
                    builder.AddAttribute(rendSeq++, "disabled");
                }

                if (Value.Equals(TargetCheckedValue))
                {
                    builder.AddAttribute(rendSeq++, "checked");
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

    #endregion

    #region OnClickInternal

    private async Task OnClickInternal()
    {
        Value = TargetCheckedValue;
        await ValueChanged.InvokeAsync(Value);
    }

    #endregion

}
