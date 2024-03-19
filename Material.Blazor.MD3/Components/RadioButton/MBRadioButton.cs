using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;

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

    #region OnInitializedAsync

    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        //AllowAllRenders();
    }

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
                builder.AddAttribute(3, "style", radioStyle + style);
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

                builder.OpenElement(8, "md-radio");
                {
                    if (AppliedDisabled || IsDisabled)
                    {
                        builder.AddAttribute(9, "disabled");
                    }

                    if (Value != null)
                    {
                        if (Value.Equals(TargetCheckedValue))
                        {
                            builder.AddAttribute(10, "checked");
                        }
                    }

                    builder.AddAttribute(11, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, OnClickInternal));
                }
                builder.CloseElement();

                if (!string.IsNullOrWhiteSpace(TrailingLabelPLUS))
                {
                    var labelSpan =
                        "<span class=\"mdc-typography--body1\" style=\"margin-left: 1em;\">"
                        + TrailingLabelPLUS
                        + "</Span>";
                    builder.AddMarkupContent(12, "\r\n");
                    builder.AddMarkupContent(13, labelSpan);
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
        //await Task.CompletedTask;
        //ComponentValue = TargetCheckedValue;
        Value = TargetCheckedValue;
        await ValueChanged.InvokeAsync(Value);
    }

    #endregion

}
