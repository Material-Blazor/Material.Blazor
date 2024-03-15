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
public sealed class MBChipSet : ComponentFoundation
{
    #region members

    /// <summary>
    /// The list of menu items.
    /// </summary>
    [Parameter] public MBChip[] ChipsetItems { get; set; }

    #endregion

    #region BuildRenderTree
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToArray();
        var rendSeq = 0;

        builder.OpenElement(rendSeq++, "md-chip-set");
        {
            builder.AddAttribute(rendSeq++, "class", @class);
            builder.AddAttribute(rendSeq++, "style", style);
            builder.AddAttribute(rendSeq++, "id", id);
            if (attributesToSplat.Any())
            {
                rendSeq = 100;
                builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
            }

            rendSeq = 200;
            if (ChipsetItems is not null)
            {
                foreach (var chip in ChipsetItems)
                {
                    rendSeq += 1000;
                    var rendSeqBase = rendSeq;
                    var componentName = CascadingDefaults.AppliedChipType(chip.ChipType) switch
                    {
                        MBChipType.Assist => "md-assist-chip",
                        MBChipType.Filter => "md-filter-chip",
                        MBChipType.Input => "md-input-chip",
                        MBChipType.Suggestion => "md-suggestion-chip",
                        _ => throw new System.Exception("Unknown ChipType")
                    };

                    builder.OpenElement(rendSeq++, componentName);
                    {
                        if (!string.IsNullOrWhiteSpace(chip.Label))
                        {
                            builder.AddAttribute(rendSeq+10, "label", chip.Label);
                        }

                        if (AppliedDisabled || chip.IsDisabled)
                        {
                            builder.AddAttribute(rendSeq+20, "disabled");
                        }

                        if (chip.IsElevated)
                        {
                            builder.AddAttribute(rendSeq+30, "elevated");
                        }

                        if (!string.IsNullOrWhiteSpace(chip.Link))
                        {
                            builder.AddAttribute(rendSeq++, "href", chip.Link);

                            if (!string.IsNullOrWhiteSpace(chip.LinkTarget))
                            {
                                builder.AddAttribute(rendSeq+40, "target", chip.LinkTarget);
                            }
                        }

                        if (chip.IsRemovable)
                        {
                            // Only for filter & input chips
                            if (componentName.Equals("md-filter-chip"))
                            {
                                builder.AddAttribute(rendSeq+50, "removable");
                            }
                            else if (componentName.Equals("md-input-chip"))
                            {
                                builder.AddAttribute(rendSeq+60, "remove-only");
                            }
                        }

                        rendSeq = rendSeqBase + 100;
                        if (chip.Icon is not null)
                        {
                            MBIcon.BuildRenderTreeWorker(
                                builder,
                                ref rendSeq,
                                CascadingDefaults,
                                null,
                                null,
                                null,
                                null,
                                chip.Icon,
                                "icon");
                        }
                    }
                    builder.CloseElement();
                }
            }
        }
        builder.CloseElement();
    }

    #endregion

}
