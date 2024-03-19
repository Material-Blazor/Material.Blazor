using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;

using System.Collections.Generic;
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

        BuildRenderTreeWorker(
            builder,
            ref rendSeq,
            CascadingDefaults,
            attributesToSplat,
            @class,
            style,
            id,
            AppliedDisabled,
            IconButtonStyle,
            IconDescriptor,
            ToggleIconDescriptor,
            IconLink,
            IconLinkTarget,
            ToggleIconSelected,
            "");
    }

    #endregion

    #region BuildRenderTreeWorker

    public static void BuildRenderTreeWorker(
        RenderTreeBuilder builder,
        ref int rendSeq,
        MBCascadingDefaults cascadingDefaults,
        KeyValuePair<string, object>[] attributesToSplat,
        string classString,
        string styleString,
        string idString,
        bool appliedDisabled,
        MBIconButtonStyle? iconButtonStyle,
        MBIconDescriptor iconDescriptor,
        MBIconDescriptor toggleIconDescriptor,
        string iconLink,
        string iconLinkTarget,
        bool toggleIconSelected,
        string slot)
    {
        var componentName = cascadingDefaults.AppliedIconButtonStyle(iconButtonStyle) switch
        {
            MBIconButtonStyle.Filled => "md-filled-icon-button",
            MBIconButtonStyle.FilledTonal => "md-filled-tonal-icon-button",
            MBIconButtonStyle.Icon => "md-icon-button",
            MBIconButtonStyle.Outlined => "md-outlined-icon-button",
            _ => throw new System.Exception("Unknown IconButtonStyle")
        };

        builder.OpenElement(rendSeq, componentName);
        {
            if (appliedDisabled)
            {
                builder.AddAttribute(rendSeq + 1, "disabled");
            }

            if ((componentName.StartsWith("md-icon-button")) && (!string.IsNullOrEmpty(iconLink)))
            {
                builder.AddAttribute(rendSeq + 2, "href", iconLink);

                if (!string.IsNullOrEmpty(iconLinkTarget))
                {
                    builder.AddAttribute(rendSeq + 3, "target", iconLinkTarget);
                }
            }

            if (toggleIconDescriptor is not null)
            {
                builder.AddAttribute(rendSeq + 4, "toggle");
                if (toggleIconSelected)
                {
                    builder.AddAttribute(rendSeq + 5, "selected");
                }
            }

            builder.AddAttribute(rendSeq + 6, "class", classString);
            builder.AddAttribute(rendSeq + 7, "style", styleString);
            builder.AddAttribute(rendSeq + 8, "id", idString);
            if ((attributesToSplat is not null) && attributesToSplat.Any())
            {
                builder.AddMultipleAttributes(rendSeq + 9, attributesToSplat);
            }

            if (!string.IsNullOrEmpty(slot))
            {
                builder.AddAttribute(rendSeq + 10, "slot", slot);
            }

            rendSeq += 15;
            if (iconDescriptor is not null)
            {
                MBIcon.BuildRenderTreeWorker(
                    builder,
                    ref rendSeq,
                    cascadingDefaults,
                    null,
                    "",
                    "",
                    "",
                    iconDescriptor,
                    "");
            }

            rendSeq += 15;
            if (toggleIconDescriptor is not null)
            {
                MBIcon.BuildRenderTreeWorker(
                    builder,
                    ref rendSeq,
                    cascadingDefaults,
                    null,
                    "",
                    "",
                    "",
                    toggleIconDescriptor,
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
        await Task.CompletedTask;
        //Value = !Value;
        //await ValueChanged.InvokeAsync(Value);
    }

    #endregion

}
