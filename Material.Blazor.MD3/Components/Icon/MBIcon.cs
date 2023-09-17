using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// Renders icons from the Material Icon Collection. Material Icons are essential for
/// Material.Blazor and are included by the library's CSS.
/// </summary>
public class MBIcon : ComponentFoundation
{
    #region members

    [CascadingParameter(Name = "IsInsideMBTabBar")] private bool IsInsideMBTabBar { get; set; }


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
    /// The icon name.
    /// </summary>
    [Parameter] public string IconName { get; set; }



    private MBBadge BadgeRef { get; set; }

    #endregion

    #region BuildRenderTree

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToArray();
        var rendSeq = 0;

        builder.OpenElement(rendSeq++, "md-icon");
        {
            if (attributesToSplat.Any())
            {
                builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
            }

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

            builder.AddAttribute(rendSeq++, "class", @class);
            builder.AddAttribute(rendSeq++, "style", style);
            builder.AddAttribute(rendSeq++, "id", id);
            builder.AddContent(rendSeq++, IconName);
        }
        builder.CloseElement();
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
