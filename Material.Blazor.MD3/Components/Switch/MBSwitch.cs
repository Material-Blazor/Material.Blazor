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
    /// Determines whether the button has a badge - defaults to false.
    /// </summary>
    [Parameter] public bool HasBadgePLUS { get; set; }

    /// <summary>
    /// The badge's style - see <see cref="MBBadgeStyle"/>, defaults to <see cref="MBBadgeStyle.ValueBearing"/>.
    /// </summary>
    [Parameter] public MBBadgeStyle BadgeStylePLUS { get; set; } = MBBadgeStyle.ValueBearing;

    /// <summary>
    /// When true collapses the badge.
    /// </summary>
    [Parameter] public bool BadgeExitedPLUS { get; set; }
    private bool _cachedBadgeExited;

    /// <summary>
    /// The badge's value.
    /// </summary>
    [Parameter] public string BadgeValuePLUS { get; set; }
    private string _cachedBadgeValue;

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



    private MBBadge BadgeRef { get; set; }
    private string switchStyle { get; } = "display: flex; flex-direction: row; flex-grow: 0; align-items: center;";

    #endregion

    #region BuildRenderTree
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToArray();
        var rendSeq = 0;

        builder.OpenElement(rendSeq++, "div");
        {
            if (HasBadgePLUS)
            {
                builder.OpenElement(rendSeq++, "div");
                {
                    builder.OpenElement(rendSeq++, "span");
                    {
                        builder.AddAttribute(rendSeq++, "class", "mb-badge-container");
                        builder.OpenComponent(rendSeq++, typeof(MBBadge));
                        {
                            builder.AddComponentParameter(rendSeq++, "BadgeStyle", BadgeStylePLUS);
                            builder.AddComponentParameter(rendSeq++, "Value", BadgeValuePLUS);
                            builder.AddComponentParameter(rendSeq++, "Exited", BadgeExitedPLUS);
                            builder.AddComponentReferenceCapture(rendSeq++,
                                (__value) => { BadgeRef = (Material.Blazor.MBBadge)__value; });
                        }
                        builder.CloseComponent();
                    }
                    builder.CloseElement();
                }
                builder.CloseElement();
            }

            builder.OpenElement(rendSeq++, "div");
            {
                builder.AddAttribute(rendSeq++, "class", @class);
                builder.AddAttribute(rendSeq++, "style", switchStyle + style);
                builder.AddAttribute(rendSeq++, "id", id);
                builder.AddAttribute(rendSeq++, "style", "display: flex; flex-flow: row nowrap; align-items: center;");

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

    #region OnParametersSetAsync

    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync().ConfigureAwait(false);

        if (_cachedBadgeValue != BadgeValuePLUS || _cachedBadgeExited != BadgeExitedPLUS)
        {
            _cachedBadgeValue = BadgeValuePLUS;
            _cachedBadgeExited = BadgeExitedPLUS;

            if (BadgeRef is not null)
            {
                EnqueueJSInteropAction(() => BadgeRef.SetValueAndExited(BadgeValuePLUS, BadgeExitedPLUS));
            }
        }
    }

    #endregion

}
