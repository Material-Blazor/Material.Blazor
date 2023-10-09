using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;

using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// This is a general purpose Material Theme button.
/// </summary>
public sealed class MBButton : ComponentFoundation
{
    #region members

    [Parameter] public MBButtonStyle? ButtonStyle { get; set; }
    [Parameter] public string Label { get; set; }

    #endregion

    #region BuildRenderTree
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToArray();
        var rendSeq = 0;

        builder.OpenElement(rendSeq++, "div");
        {
            builder.AddAttribute(rendSeq++, "class", @class);
            builder.AddAttribute(rendSeq++, "style", style);
            builder.AddAttribute(rendSeq++, "id", id);
            if (attributesToSplat.Any())
            {
                builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
            }

            if (AppliedDisabled)
            {
                builder.AddAttribute(rendSeq++, "disabled");
            }

            var componentName = CascadingDefaults.AppliedButtonStyle(ButtonStyle) switch
            {
                MBButtonStyle.Elevated => "md-elevated-button",
                MBButtonStyle.Filled => "md-filled-button",
                MBButtonStyle.FilledTonal => "md-filled-tonal-button",
                MBButtonStyle.Outlined => "md-outlined-button",
                MBButtonStyle.Text => "md-text-button",
                _ => throw new System.Exception("Unknown TextInputStyle")
            };

            builder.OpenElement(rendSeq++, componentName);
            {
                if (!string.IsNullOrWhiteSpace(Label))
                {
                    builder.AddContent(rendSeq++, Label);
                }
            }
            builder.CloseElement();

            // Need to handle icon, icon placement, onclick, disabled

            //    if (AppliedDisabled)
            //    {
            //        builder.AddAttribute(rendSeq++, "disabled");
            //    }

            //    builder.AddAttribute(rendSeq++, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, OnClickInternal));
        }
        builder.CloseElement();
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
