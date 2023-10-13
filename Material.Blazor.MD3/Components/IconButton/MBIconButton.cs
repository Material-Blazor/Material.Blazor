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

    [Parameter] public MBDensity Density { get; set; }
    [Parameter] public MBIconDescriptor IconDescriptor { get; set; }
    [Parameter] public MBIconButtonStyle? IconButtonStyle { get; set; }

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
