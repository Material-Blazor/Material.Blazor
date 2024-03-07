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
        var rendSeq = 0;

        builder.OpenElement(rendSeq++, "div");
        {
            builder.AddAttribute(rendSeq++, "class", @class);
            builder.AddAttribute(rendSeq++, "style", style);
            builder.AddMultipleAttributes(rendSeq++, attributes);

            builder.OpenElement(rendSeq++, "span");
            {
                builder.AddAttribute(rendSeq++, "class", iconDerivedClass);
                builder.AddAttribute(rendSeq++, "style", iconDerivedStyle);
                builder.AddContent(rendSeq++, IconName.ToLower());
            }
            builder.CloseElement();
        }
        builder.CloseElement();
    };


    private string msColor { get; }
    private bool msFill { get; }
    private MBIconMSGradient? msGradient { get; }
    private MBIconMSSize? msSize { get; }
    private MBIconMSStyle msStyle { get; }
    private MBIconMSWeight? msWeight { get; }

    private string iconDerivedClass { get; set; }
    private string iconDerivedStyle { get; set; }



#nullable enable annotations
    public Icon_MS(MBCascadingDefaults cascadingDefaults, string iconName, IconFoundryMS? foundry = null)
    {
        IconName = iconName;
        msColor = cascadingDefaults.AppliedIconMSColor(foundry?.Color);
        msFill = cascadingDefaults.AppliedIconMSFill(foundry?.Fill);
        msGradient = cascadingDefaults.AppliedIconMSGradient(foundry?.Gradient);
        msSize = cascadingDefaults.AppliedIconMSSize(foundry?.Size);
        msStyle = cascadingDefaults.AppliedIconMSStyle(foundry?.Style);
        msWeight = cascadingDefaults.AppliedIconMSWeight(foundry?.Weight);

        // Set the icon class

        iconDerivedClass = "";
        iconDerivedClass = msStyle switch
        {
            MBIconMSStyle.Outlined => "material-symbols-outlined ",
            MBIconMSStyle.Rounded => "material-symbols-rounded ",
            MBIconMSStyle.Sharp => "material-symbols-sharp ",
            _ => throw new System.Exception("Unknown Icon Style")
        };

        // Set the icon style

        iconDerivedStyle = "";
        var fontStyle = "";
        var fontVariation = " font-variation-settings:";

        // Icon color
        fontStyle += string.IsNullOrWhiteSpace(msColor) ? "" : " color: " + msColor + ";";

        // Icon fill
        var fillValue = msFill ? "1" : "0";
        fontVariation += " 'FILL' " + fillValue + ",";

        // Icon gradient
        _ = msGradient switch
        {
            MBIconMSGradient.LowEmphasis => fontVariation += " 'GRAD' -25,",
            MBIconMSGradient.NormalEmphasis => fontVariation += " 'GRAD' 0,",
            MBIconMSGradient.HighEmphasis => fontVariation += " 'GRAD' 200,",
            _ => throw new System.Exception("Unknown Icon Gradient")
        };

        // Icon  size
        switch (msSize)
        {
            case MBIconMSSize.Size20:
                fontStyle += " font-size: 20px;";
                fontVariation += " 'opsz' 20,";
                break;

            case MBIconMSSize.Size24:
                fontStyle += " font-size: 24px;";
                fontVariation += " 'opsz' 24,";
                break;

            case MBIconMSSize.Size40:
                fontStyle += " font-size: 40px;";
                fontVariation += " 'opsz' 40,";
                break;

            case MBIconMSSize.Size48:
                fontStyle += " font-size: 48px;";
                fontVariation += " 'opsz' 48,";
                break;

            default:
                throw new System.Exception("Unknown Icon Size");
        };

        // Icon weight
        _ = msWeight switch
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

        iconDerivedStyle = fontStyle + fontVariation;
    }

#nullable restore annotations

    public bool RequiresColorFilter => false;

}
