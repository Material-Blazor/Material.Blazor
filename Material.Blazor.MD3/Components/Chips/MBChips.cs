using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;

using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// This is a general purpose Material Theme chipset.
/// </summary>
public sealed class MBChips : ComponentFoundation
{
    #region members

    /// <summary>
    /// The list of menu items.
    /// </summary>
    [Parameter] public MBChipsetItem[] ChipsetItems { get; set; }

    #endregion

    #region BuildRenderTree
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToArray();
        var rendSeq = 0;

        //var componentName = CascadingDefaults.AppliedButtonStyle(ButtonStyle) switch
        //{
        //    MBButtonStyle.Elevated => "md-elevated-button",
        //    MBButtonStyle.Filled => "md-filled-button",
        //    MBButtonStyle.FilledTonal => "md-filled-tonal-button",
        //    MBButtonStyle.Outlined => "md-outlined-button",
        //    MBButtonStyle.Text => "md-text-button",
        //    _ => throw new System.Exception("Unknown ButtonStyle")
        //};

        //builder.OpenElement(rendSeq++, componentName);
        //{
        //    builder.AddAttribute(rendSeq++, "class", @class);
        //    builder.AddAttribute(rendSeq++, "style", style);
        //    builder.AddAttribute(rendSeq++, "id", id);
        //    if (attributesToSplat.Any())
        //    {
        //        builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
        //    }

        //    if (AppliedDisabled)
        //    {
        //        builder.AddAttribute(rendSeq++, "disabled");
        //    }

            //if (IconIsTrailing)
            //{
            //    builder.AddAttribute(rendSeq++, "trailing-icon");
            //}

            //if (!string.IsNullOrWhiteSpace(Label))
            //{
            //    builder.AddContent(rendSeq++, Label);
            //}

            //if (IconDescriptor is not null)
            //{
            //    MBIcon.BuildRenderTreeWorker(
            //        builder,
            //        ref rendSeq,
            //        CascadingDefaults,
            //        null,
            //        "",
            //        "",
            //        "",
            //        IconDescriptor,
            //        "icon");
            //}
        //}
        //builder.CloseElement();
    }

    #endregion

}
