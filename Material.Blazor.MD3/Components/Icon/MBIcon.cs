using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// Renders icons from the Material Symbol Font. Material Symbols are essential for
/// Material.Blazor and are included in the library's CSS.
/// </summary>
public class MBIcon : ComponentFoundation
{
    #region members

    /// <summary>
    /// The icon attributes and a constructor for same.
    /// </summary>
    [Parameter] public MBIconDescriptor Descriptor { get; set; }
    public static MBIconDescriptor IconDescriptorConstructor(
        string color = null,
        decimal? fill = null,
        MBIconGradient? gradient = null,
        string name = null,
        MBIconSize? size = null,
        MBIconStyle? style = null,
        MBIconWeight? weight = null)
        =>
        new MBIconDescriptor(
            color: color,
            fill: fill,
            gradient: gradient,
            name: name,
            size: size,
            style: style,
            weight: weight);



    #endregion

    #region BuildRenderTree

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToArray();
        var rendSeq = 0;

        builder.OpenElement(rendSeq++, "div");
        {
            if (attributesToSplat.Any())
            {
                builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
            }

            builder.AddAttribute(rendSeq++, "class", @class);
            builder.AddAttribute(rendSeq++, "style", style);
            builder.AddAttribute(rendSeq++, "id", id);


            BuildRenderTreeWorker(
                builder,
                ref rendSeq,
                CascadingDefaults,
                Descriptor,
                null);
        }
        builder.CloseElement();
    }

    public static void BuildRenderTreeWorker(
        RenderTreeBuilder builder,
        ref int rendSeq,
        MBCascadingDefaults cascadingDefaults,
        MBIconDescriptor descriptor,
        string slot)
    {
        var iconColor = cascadingDefaults.AppliedIconColor(descriptor.Color);
        var iconFill = cascadingDefaults.AppliedIconFill(descriptor.Fill);
        var iconGradient = cascadingDefaults.AppliedIconGradient(descriptor.Gradient);
        var iconName = cascadingDefaults.AppliedIconName(descriptor.Name);
        var iconSize = cascadingDefaults.AppliedIconSize(descriptor.Size);
        var iconSlot = slot;
        var iconStyle = cascadingDefaults.AppliedIconStyle(descriptor.Style);
        var iconWeight = cascadingDefaults.AppliedIconWeight(descriptor.Weight);

        // Set the icon style

        var fontStyle = "";
        var fontVariation = " font-variation-settings:";

        // Icon font
        fontStyle += "--md-icon-font: " + iconStyle switch
        {
            MBIconStyle.Outlined => "'Material Symbols Outlined'; ",
            MBIconStyle.Rounded => "'Material Symbols Rounded'; ",
            MBIconStyle.Sharp => "'Material Symbols Sharp'; ",
            _ => throw new System.Exception("Unknown Icon Style")
        };

        // Icon color
        fontStyle += " color: " + iconColor + ";";

        // Icon fill
        fontVariation += " 'FILL' " + iconFill.ToString() + ",";

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
                fontStyle += " height: 20px;";
                fontStyle += " width: 20px;";
                fontVariation += " 'opsz' 20,";
                break;

            case MBIconSize.Size24:
                fontStyle += " font-size: 24px;";
                fontStyle += " height: 24px;";
                fontStyle += " width: 24px;";
                fontVariation += " 'opsz' 24,";
                break;

            case MBIconSize.Size40:
                fontStyle += " font-size: 40px;";
                fontStyle += " height: 40px;";
                fontStyle += " width: 40px;";
                fontVariation += " 'opsz' 40,";
                break;

            case MBIconSize.Size48:
                fontStyle += " font-size: 48px;";
                fontStyle += " height: 48px;";
                fontStyle += " width: 48px;";
                fontVariation += " 'opsz' 48,";
                break;

            default:
                throw new System.Exception("Unknown Icon Size");
        };

        // Icon weight
        //_ = iconWeight switch
        //{
        //    MBIconWeight.W100 => fontStyle += " font-weight: 100;",
        //    MBIconWeight.W200 => fontStyle += " font-weight: 200;",
        //    MBIconWeight.W300 => fontStyle += " font-weight: 300,",
        //    MBIconWeight.W400 => fontStyle += " font-weight: 400,",
        //    MBIconWeight.W500 => fontStyle += " font-weight: 500,",
        //    MBIconWeight.W600 => fontStyle += " font-weight: 600,",
        //    MBIconWeight.W700 => fontStyle += " font-weight: 700,",
        //    _ => throw new System.Exception("Unknown Icon Weight")
        //};
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

        var iconDerivedStyle = fontStyle + fontVariation;

        builder.OpenElement(rendSeq++, "md-icon");
        {
            if (!string.IsNullOrWhiteSpace(iconSlot))
            {
                builder.AddAttribute(rendSeq++, "slot", iconSlot);
            }
            builder.AddAttribute(rendSeq++, "style", iconDerivedStyle);
            builder.AddContent(rendSeq++, iconName.ToLower());
        }
        builder.CloseElement();
    }

    #endregion

}
