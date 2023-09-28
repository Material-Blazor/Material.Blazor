﻿using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// Renders icons from the Material Symbol Font. Material Symbols are essential for
/// Material.Blazor and are included by the library's CSS.
/// </summary>
public class MBIcon : ComponentFoundation
{
    #region members

    /// <summary>
    /// Determines whether the button has a badge - defaults to false.
    /// </summary>
    [Parameter] public bool HasBadgePLUS { get; set; } = false;

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



    [Parameter] public IconDescriptor Descriptor { get; set; }
    /// <summary>
    /// The icon attributes.
    /// </summary>
    public static IconDescriptor IconDescriptorConstructor(
        string color = null,
        bool? fill = null,
        MBIconGradient? gradient = null,
        string name = null,
        MBIconSize? size = null,
        MBIconStyle? style = null,
        MBIconWeight? weight = null)
        =>
        new IconDescriptor(
            color,
            fill,
            gradient,
            name,
            size,
            style,
            weight);



    private MBBadge badgeRef { get; set; }
    private string iconColor { get; set; }
    private string iconDerivedClass { get; set; }
    private string iconDerivedStyle { get; set; }
    private bool iconFill { get; set; }
    private MBIconGradient iconGradient { get; set; }
    private string iconName { get; set; }
    private MBIconSize iconSize { get; set; }
    private MBIconStyle iconStyle { get; set; }
    private MBIconWeight iconWeight { get; set; }
    private bool shouldNotRender { get; set; }

    #endregion

    #region BuildRenderTree

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        if (shouldNotRender)
        {
            return;
        }

        var attributesToSplat = AttributesToSplat().ToArray();
        var rendSeq = 0;

        builder.OpenElement(rendSeq++, "div");
        {
            if (HasBadgePLUS)
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
                            (__value) => { badgeRef = (Material.Blazor.MBBadge)__value; });
                    }
                    builder.CloseComponent();
                }
                builder.CloseElement();
            }

            builder.OpenElement(rendSeq++, "div");
            {
                if (attributesToSplat.Any())
                {
                    builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
                }

                builder.AddAttribute(rendSeq++, "class", @class);
                builder.AddAttribute(rendSeq++, "style", style);
                builder.AddAttribute(rendSeq++, "id", id);

                builder.OpenElement(rendSeq++, "span");
                {
                    builder.AddAttribute(rendSeq++, "class", iconDerivedClass);
                    builder.AddAttribute(rendSeq++, "style", iconDerivedStyle);
                    builder.AddContent(rendSeq++, iconName);
                }
                builder.CloseElement();
            }
            builder.CloseElement();
        }
        builder.CloseElement();
    }

    #endregion

    #region OnParametersSetAsync

    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();

        if (_cachedBadgeValue != BadgeValuePLUS || _cachedBadgeExited != BadgeExitedPLUS)
        {
            _cachedBadgeValue = BadgeValuePLUS;
            _cachedBadgeExited = BadgeExitedPLUS;

            if (badgeRef is not null)
            {
                EnqueueJSInteropAction(() => badgeRef.SetValueAndExited(BadgeValuePLUS, BadgeExitedPLUS));
            }
        }

        //if (Descriptor is null)
        //{
        //    shouldNotRender = true;
        //    return;
        //}

        shouldNotRender = string.IsNullOrWhiteSpace(Descriptor.Name);
        if (shouldNotRender) 
        {
            return;
        }

        iconColor = CascadingDefaults.AppliedIconColor(Descriptor.Color);
        iconFill = CascadingDefaults.AppliedIconFill(Descriptor.Fill);
        iconGradient = CascadingDefaults.AppliedIconGradient(Descriptor.Gradient);
        iconName = Descriptor.Name;
        iconSize = CascadingDefaults.AppliedIconSize(Descriptor.Size);
        iconStyle = CascadingDefaults.AppliedIconStyle(Descriptor.Style);
        iconWeight = CascadingDefaults.AppliedIconWeight(Descriptor.Weight);

        // Set the icon class

        iconDerivedClass = "";
        iconDerivedClass = iconStyle switch
        {
            MBIconStyle.Outlined => "material-symbols-outlined ",
            MBIconStyle.Rounded => "material-symbols-rounded ",
            MBIconStyle.Sharp => "material-symbols-sharp ",
            _ => throw new System.Exception("Unknown Icon Style")
        };

        // Set the icon style
        
        iconDerivedStyle = "";
        var fontStyle = "";
        var fontVariation = " font-variation-settings:";

        // Icon color
        fontStyle += " color: " + iconColor + ";";

        // Icon fill
        var fillValue = iconFill ? "1" : "0";
        fontVariation += " 'FILL' " + fillValue + ",";

        // Icon gradient
        _ = iconGradient switch
        {
            MBIconGradient.LowEmphasis => fontVariation += " 'GRAD' -25,",
            MBIconGradient.NormalEmphasis => fontVariation += " 'GRAD' 0,",
            MBIconGradient.HighEmphasis => fontVariation += " 'GRAD' 200,",
            _ => throw new System.Exception("Unknown Icon Gradient")
        };

        // Icon  size
        switch (iconSize)
        {
            case MBIconSize.Size20:
                fontStyle += " font-size: 20px;";
                fontVariation += " 'opsz' 20,";
                break;

            case MBIconSize.Size24:
                fontStyle += " font-size: 24px;";
                fontVariation += " 'opsz' 24,";
                break;

            case MBIconSize.Size40:
                fontStyle += " font-size: 40px;";
                fontVariation += " 'opsz' 40,";
                break;

            case MBIconSize.Size48:
                fontStyle += " font-size: 48px;";
                fontVariation += " 'opsz' 48,";
                break;

            default:
                throw new System.Exception("Unknown Icon Size");
        };

        // Icon weight
        _ = iconWeight switch
        {
            MBIconWeight.W100 => fontVariation += " 'wght' 100,",
            MBIconWeight.W200 => fontVariation += " 'wght' 200,",
            MBIconWeight.W300 => fontVariation += " 'wght' 300,",
            MBIconWeight.W400 => fontVariation += " 'wght' 400,",
            MBIconWeight.W500 => fontVariation += " 'wght' 500,",
            MBIconWeight.W600 => fontVariation += " 'wght' 600,",
            MBIconWeight.W700 => fontVariation += " 'wght' 700,",
            _ => throw new System.Exception("Unknown Icon Weight")
        };

        // Fix the trailing part of the variation string
        if (fontVariation.EndsWith(','))
        {
            fontVariation = fontVariation.TrimEnd(',');
            fontVariation += ';';
        }

        if (fontVariation.EndsWith(':'))
        {
            fontVariation = null;
        }

        iconDerivedStyle = fontStyle + fontVariation;
    }

    #endregion

}
