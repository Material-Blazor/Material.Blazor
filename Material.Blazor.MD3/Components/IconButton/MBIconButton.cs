using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;

using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// This is a general purpose Material Theme icon button.
/// </summary>
public sealed class MBIconButton : ComponentFoundation
{
    #region members

    /// <summary>
    /// The density attribute.
    /// </summary>
    [Parameter] public MBDensity Density { get; set; }

    /// <summary>
    /// The primary icon attributes.
    /// </summary>
    [Parameter] public MBIconDescriptor IconDescriptor { get; set; }

    /// <summary>
    /// The icon style (outlined, filled, etc).
    /// </summary>
    [Parameter] public MBIconButtonStyle? IconButtonStyle { get; set; }

    /// <summary>
    /// The icon link (url, valid only with the style of Icon).
    /// </summary>
    [Parameter] public string IconLink { get; set; }

    /// <summary>
    /// The target for a link.
    /// </summary>
    [Parameter] public string IconLinkTarget { get; set; }

    /// <summary>
    /// A secondary icon used in the setting of a toggle
    /// </summary>
    [Parameter] public MBIconDescriptor ToggleIconDescriptor { get; set; }

    /// <summary>
    /// A secondary icon used in the setting of a toggle
    /// </summary>
    [Parameter] public bool ToggleIconSelected { get; set; }

    #endregion

    #region BuildRenderTree
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToArray();
        var rendSeq = 0;

        var componentName = CascadingDefaults.AppliedIconButtonStyle(IconButtonStyle) switch
        {
            MBIconButtonStyle.Filled => "md-filled-icon-button",
            MBIconButtonStyle.FilledTonal => "md-filled-tonal-icon-button",
            MBIconButtonStyle.Icon => "md-icon-button",
            MBIconButtonStyle.Outlined => "md-outlined-icon-button",
            _ => throw new System.Exception("Unknown IconButtonStyle")
        };

        builder.OpenElement(rendSeq++, componentName);
        {
            if (AppliedDisabled)
            {
                builder.AddAttribute(rendSeq++, "disabled");
            }

            if ((componentName.StartsWith("md-icon-button")) && (!string.IsNullOrEmpty(IconLink)))
            {
                builder.AddAttribute(rendSeq++, "href", IconLink);

                if (!string.IsNullOrEmpty(IconLinkTarget))
                {
                    builder.AddAttribute(rendSeq++, "target", IconLinkTarget);
                }
            }

            if (ToggleIconDescriptor is not null)
            {
                builder.AddAttribute(rendSeq++, "toggle");
                if (ToggleIconSelected)
                {
                    builder.AddAttribute(rendSeq++, "selected");
                }
            }

            builder.AddAttribute(rendSeq++, "class", @class);
            builder.AddAttribute(rendSeq++, "style", style);
            builder.AddAttribute(rendSeq++, "id", id);
            if (attributesToSplat.Any())
            {
                builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
            }

            if (IconDescriptor is not null)
            {
                MBIcon.BuildRenderTreeWorker(
                    builder,
                    ref rendSeq,
                    CascadingDefaults,
                    IconDescriptor,
                    "");
            }

            if (ToggleIconDescriptor is not null)
            {
                MBIcon.BuildRenderTreeWorker(
                    builder,
                    ref rendSeq,
                    CascadingDefaults,
                    ToggleIconDescriptor,
                    "selected");
            }
        }
        builder.CloseElement();

        // Consider throttle

        //    builder.AddAttribute(rendSeq++, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, OnClickInternal));
    }

    #endregion

    #region OnClickInternal

    private async Task OnClickInternal()
    {
        //Value = !Value;
        //await ValueChanged.InvokeAsync(Value);
    }

    #endregion

}
