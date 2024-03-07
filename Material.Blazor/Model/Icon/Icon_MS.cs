using Microsoft.AspNetCore.Components.Rendering;

namespace Material.Blazor;

/// <summary>
/// Material Icons icon.
/// </summary>
internal class Icon_MS : IMBIcon
{
    private string IconName { get; }


    /// <inheritdoc />
    public IMBIcon.IconFragment Render => (@class, style, attributes) => (RenderTreeBuilder builder) =>
    {
        if (IconName == null)
        {
            return;
        }

        builder.OpenElement(0, "i");
        builder.AddAttribute(1, "class", string.Join(" ", @class, IconDerivedClass));
        if (style != null)
        {
            builder.AddAttribute(2, "style", string.Join(" ", style, IconDerivedStyle));
        }
        if (attributes != null)
        {
            builder.AddMultipleAttributes(3, attributes);
        }
        builder.AddContent(4, IconName.ToLower());
        builder.CloseElement();
        //var rendSeq = 0;

        //builder.OpenElement(rendSeq++, "div");
        //{
        //    builder.AddAttribute(rendSeq++, "class", @class);
        //    builder.AddAttribute(rendSeq++, "style", style);
        //    builder.AddMultipleAttributes(rendSeq++, attributes);

        //    builder.OpenElement(rendSeq++, "span");
        //    {
        //        builder.AddAttribute(rendSeq++, "class", iconDerivedClass);
        //        builder.AddAttribute(rendSeq++, "style", iconDerivedStyle);
        //        builder.AddContent(rendSeq++, IconName.ToLower());
        //    }
        //    builder.CloseElement();
        //}
        //builder.CloseElement();
    };


    private string MsColor { get; }
    private bool MsFill { get; }
    private MBIconMSGradient? MsGradient { get; }
    private MBIconMSSize? MsSize { get; }
    private MBIconMSStyle MsStyle { get; }
    private MBIconMSWeight? MsWeight { get; }

    private string IconDerivedClass { get; set; }
    private string IconDerivedStyle { get; set; }



#nullable enable annotations
    public Icon_MS(MBCascadingDefaults cascadingDefaults, string iconName, IconFoundryMS? foundry = null)
    {
        IconName = iconName;
        MsColor = cascadingDefaults.AppliedIconMSColor(foundry?.Color);
        MsFill = cascadingDefaults.AppliedIconMSFill(foundry?.Fill);
        MsGradient = cascadingDefaults.AppliedIconMSGradient(foundry?.Gradient);
        MsSize = cascadingDefaults.AppliedIconMSSize(foundry?.Size);
        MsStyle = cascadingDefaults.AppliedIconMSStyle(foundry?.Style);
        MsWeight = cascadingDefaults.AppliedIconMSWeight(foundry?.Weight);

        // Set the icon class

        IconDerivedClass = "";
        IconDerivedClass = MsStyle switch
        {
            MBIconMSStyle.Outlined => "material-symbols-outlined ",
            MBIconMSStyle.Rounded => "material-symbols-rounded ",
            MBIconMSStyle.Sharp => "material-symbols-sharp ",
            _ => throw new System.Exception("Unknown Icon Style")
        };

        // Set the icon style

        IconDerivedStyle = "";
        var fontStyle = "";
        var fontVariation = " font-variation-settings:";

        // Icon color
        fontStyle += string.IsNullOrWhiteSpace(MsColor) ? "" : " color: " + MsColor + ";";

        // Icon fill
        var fillValue = MsFill ? "1" : "0";
        fontVariation += " 'FILL' " + fillValue + ",";

        // Icon gradient
        _ = MsGradient switch
        {
            MBIconMSGradient.LowEmphasis => fontVariation += " 'GRAD' -25,",
            MBIconMSGradient.NormalEmphasis => fontVariation += " 'GRAD' 0,",
            MBIconMSGradient.HighEmphasis => fontVariation += " 'GRAD' 200,",
            _ => throw new System.Exception("Unknown Icon Gradient")
        };

        // Icon  size
        switch (MsSize)
        {
            case MBIconMSSize.Size20:
                fontVariation += " 'opsz' 20,";
                break;

            case MBIconMSSize.Size24:
                fontVariation += " 'opsz' 24,";
                break;

            case MBIconMSSize.Size40:
                fontVariation += " 'opsz' 40,";
                break;

            case MBIconMSSize.Size48:
                fontVariation += " 'opsz' 48,";
                break;

            default:
                throw new System.Exception("Unknown Icon Size");
        };

        // Icon weight
        _ = MsWeight switch
        {
            MBIconMSWeight.W100 => fontVariation += " 'wght' 100,",
            MBIconMSWeight.W200 => fontVariation += " 'wght' 200,",
            MBIconMSWeight.W300 => fontVariation += " 'wght' 300,",
            MBIconMSWeight.W400 => fontVariation += " 'wght' 400,",
            MBIconMSWeight.W500 => fontVariation += " 'wght' 500,",
            MBIconMSWeight.W600 => fontVariation += " 'wght' 600,",
            MBIconMSWeight.W700 => fontVariation += " 'wght' 700,",
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

        IconDerivedStyle = fontStyle + fontVariation;
    }

#nullable restore annotations

    public bool RequiresColorFilter => false;

}
