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
        var rendSeq = 0;

        builder.OpenElement(rendSeq++, "div");
        {
            builder.AddAttribute(rendSeq++, "class", @class);
            builder.AddAttribute(rendSeq++, "style", switchStyle + style);
            builder.AddAttribute(rendSeq++, "id", id);

            if (!string.IsNullOrWhiteSpace(LeadingLabelPLUS))
            {
                var labelSpan =
                    "<span class=\"mdc-typography--body1\" style=\"margin-right: 1em;\">"
                    + LeadingLabelPLUS
                    + "</Span>";
                builder.AddMarkupContent(rendSeq++, "\r\n");
                builder.AddMarkupContent(rendSeq++, labelSpan);
            }

            builder.OpenElement(rendSeq++, "md-switch");
            {
                if (attributesToSplat.Any())
                {
                    builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
                }

                if (AppliedDisabled)
                {
                    builder.AddAttribute(rendSeq++, "disabled");
                }

                builder.AddAttribute(rendSeq++, "selected", BindConverter.FormatValue(Value));
                builder.AddAttribute(rendSeq++, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, OnClickInternal));
                builder.AddAttribute(rendSeq++, "icons", CascadingDefaults.AppliedSwitchIcons(Icons));
                builder.AddAttribute(rendSeq++, "show-only-selected-icon", CascadingDefaults.AppliedSwitchSwitchShowOnlySelectedIcon(ShowOnlySelectedIcon));
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
        await Task.CompletedTask;
        ComponentValue = !Value;
    }

    #endregion

}
