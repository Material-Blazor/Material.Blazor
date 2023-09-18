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



    private MBBadge BadgeRef { get; set; }
    private string checkboxStyle { get; } = "display: flex; flex-direction: row; flex-grow: 1; align-items: center;";

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
        Value = !Value;
        await ValueChanged.InvokeAsync(Value);
    }

    #endregion

    #region OnParametersSetAsync

    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();

        if (BadgeRef is not null)
        {
            if (_cachedBadgeValue != BadgeValuePLUS || _cachedBadgeExited != BadgeExitedPLUS)
            {
                _cachedBadgeValue = BadgeValuePLUS;
                _cachedBadgeExited = BadgeExitedPLUS;

                EnqueueJSInteropAction(() => BadgeRef.SetValueAndExited(BadgeValuePLUS, BadgeExitedPLUS));
            }
        }
    }

    #endregion

}
