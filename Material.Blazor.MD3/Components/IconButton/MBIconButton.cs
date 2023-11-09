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

        builder.OpenElement(rendSeq++, componentName);
        {
            if (appliedDisabled)
            {
                builder.AddAttribute(rendSeq++, "disabled");
            }

            if ((componentName.StartsWith("md-icon-button")) && (!string.IsNullOrEmpty(iconLink)))
            {
                builder.AddAttribute(rendSeq++, "href", iconLink);

                if (!string.IsNullOrEmpty(iconLinkTarget))
                {
                    builder.AddAttribute(rendSeq++, "target", iconLinkTarget);
                }
            }

            if (toggleIconDescriptor is not null)
            {
                builder.AddAttribute(rendSeq++, "toggle");
                if (toggleIconSelected)
                {
                    builder.AddAttribute(rendSeq++, "selected");
                }
            }

            builder.AddAttribute(rendSeq++, "class", classString);
            builder.AddAttribute(rendSeq++, "style", styleString);
            builder.AddAttribute(rendSeq++, "id", idString);
            if ((attributesToSplat is not null) && attributesToSplat.Any())
            {
                builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
            }

            if (!string.IsNullOrEmpty(slot))
            {
                builder.AddAttribute(rendSeq++, "slot", slot);
            }

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
