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
    #region members

    /// <summary>
    /// Determines whether the switch shows icons.
    /// </summary>
    [Parameter] public bool? Icons { get; set; }

    /// <summary>
    /// Provides a leading label for the checkbox.
    /// </summary>
    [Parameter] public string LeadingLabelPLUS { get; set; }

    /// <summary>
    /// Determines shows icons only in the selected state.
    /// </summary>
    [Parameter] public bool? ShowOnlySelectedIcon { get; set; }

    /// <summary>
    /// Provides a trailing label for the checkbox.
    /// </summary>
    [Parameter] public string TrailingLabelPLUS { get; set; }



    private string switchStyle { get; } = "display: flex; flex-direction: row; flex-grow: 0; align-items: center;";

    #endregion

    #region BuildRenderTree
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToArray();

        builder.OpenElement(0, "div");
        {
            builder.AddAttribute(1, "class", @class);
            builder.AddAttribute(2, "style", switchStyle + style);
            builder.AddAttribute(3, "id", id);

            if (!string.IsNullOrWhiteSpace(LeadingLabelPLUS))
            {
                var labelSpan =
                    "<span class=\"mdc-typography--body1\" style=\"margin-right: 1em;\">"
                    + LeadingLabelPLUS
                    + "</Span>";
                builder.AddMarkupContent(4, "\r\n");
                builder.AddMarkupContent(5, labelSpan);
            }

            builder.OpenElement(6, "md-switch");
            {
                if (attributesToSplat.Any())
                {
                    builder.AddMultipleAttributes(7, attributesToSplat);
                }

                if (AppliedDisabled)
                {
                    builder.AddAttribute(8, "disabled");
                }

                builder.AddAttribute(9, "selected", BindConverter.FormatValue(Value));
                builder.AddAttribute(10, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, OnClickInternal));
                builder.AddAttribute(11, "icons", CascadingDefaults.AppliedSwitchIcons(Icons));
                builder.AddAttribute(12, "show-only-selected-icon", CascadingDefaults.AppliedSwitchSwitchShowOnlySelectedIcon(ShowOnlySelectedIcon));
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

    #endregion

    #region OnClickInternal

    private async Task OnClickInternal()
    {
        await Task.CompletedTask;
        ComponentValue = !Value;
    }

    #endregion

}
