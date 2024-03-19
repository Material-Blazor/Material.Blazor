using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.VisualBasic;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// This is a general purpose Material Theme floating action button.
/// </summary>
public sealed class MBFloatingActionButton : ComponentFoundation
{
    #region members

    /// <summary>
    /// The density attribute.
    /// </summary>
    [Parameter] public MBDensity Density { get; set; }

    /// <summary>
    /// The icon size (small, medium, large).
    /// </summary>
    [Parameter] public MBFloatingActionButtonSize? FloatingActionButtonSize { get; set; }

    /// <summary>
    /// The icon style (surface, primary, etc).
    /// </summary>
    [Parameter] public MBFloatingActionButtonStyle? FloatingActionButtonStyle { get; set; }

    /// <summary>
    /// The primary icon attributes.
    /// </summary>
    [Parameter] public MBIconDescriptor IconDescriptor { get; set; }

    /// <summary>
    /// IsLowered attribute
    /// </summary>
    [Parameter] public bool IsLowered { get; set; }

    /// <summary>
    /// Label
    /// </summary>
    [Parameter] public string Label { get; set; }

    #endregion

    #region BuildRenderTree

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToArray();

        var componentName = CascadingDefaults.AppliedFloatingActionButtonStyle(FloatingActionButtonStyle) switch
        {
            MBFloatingActionButtonStyle.Branded => "md-branded-fab",
            MBFloatingActionButtonStyle.Primary => "md-fab",
            MBFloatingActionButtonStyle.Secondary => "md-fab",
            MBFloatingActionButtonStyle.Surface => "md-fab",
            MBFloatingActionButtonStyle.Tertiary => "md-fab",
            _ => throw new System.Exception("Unknown FloatingActionButtonStyle")
        };

        var variant = CascadingDefaults.AppliedFloatingActionButtonStyle(FloatingActionButtonStyle) switch
        {
            MBFloatingActionButtonStyle.Branded => "",
            MBFloatingActionButtonStyle.Primary => "primary",
            MBFloatingActionButtonStyle.Secondary => "secondary",
            MBFloatingActionButtonStyle.Surface => "surface",
            MBFloatingActionButtonStyle.Tertiary => "tertiary",
            _ => throw new System.Exception("Unknown FloatingActionButtonStyle")
        };

        builder.OpenElement(0, componentName);
        {
            if (AppliedDisabled)
            {
                builder.AddAttribute(1, "disabled");
            }

            if (IsLowered)
            {
                builder.AddAttribute(2, "lowered");
            }

            builder.AddAttribute(3, "class", @class);
            builder.AddAttribute(4, "style", style);
            builder.AddAttribute(5, "id", id);
            if ((attributesToSplat is not null) && attributesToSplat.Any())
            {
                builder.AddMultipleAttributes(6, attributesToSplat);
            }

            if (!string.IsNullOrWhiteSpace(variant))
            {
                builder.AddAttribute(7, "variant", variant);
            }

            if (!string.IsNullOrWhiteSpace(Label))
            {
                builder.AddAttribute(8, "label", Label);
            }

            var size = CascadingDefaults.AppliedFloatingActionButtonSize(FloatingActionButtonSize);
            if (size == MBFloatingActionButtonSize.Small)
            {
                builder.AddAttribute(9, "size", "small");
            }
            else if (size == MBFloatingActionButtonSize.Large)
            {
                builder.AddAttribute(9, "size", "large");
            }

            var rendSeq = 10;
            if (IconDescriptor is not null)
            {
                MBIcon.BuildRenderTreeWorker(
                    builder,
                    ref rendSeq,
                    CascadingDefaults,
                    null,
                    "",
                    "",
                    "",
                    IconDescriptor,
                    "icon");
            }
        }
        builder.CloseElement();

        #endregion

    }

}
