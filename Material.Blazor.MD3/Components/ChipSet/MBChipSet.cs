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

        builder.OpenElement(0, "md-chip-set");
        {
            builder.AddAttribute(1, "class", @class);
            builder.AddAttribute(2, "style", style);
            builder.AddAttribute(3, "id", id);
            if (attributesToSplat.Any())
            {
                builder.AddMultipleAttributes(4, attributesToSplat);
            }

            var rendSeq = 10;
            if (ChipsetItems is not null)
            {
                foreach (var chip in ChipsetItems)
                {
                    var componentName = CascadingDefaults.AppliedChipType(chip.ChipType) switch
                    {
                        MBChipType.Assist => "md-assist-chip",
                        MBChipType.Filter => "md-filter-chip",
                        MBChipType.Input => "md-input-chip",
                        MBChipType.Suggestion => "md-suggestion-chip",
                        _ => throw new System.Exception("Unknown ChipType")
                    };

                    builder.OpenElement(rendSeq, componentName);
                    {
                        if (!string.IsNullOrWhiteSpace(chip.Label))
                        {
                            builder.AddAttribute(rendSeq + 1, "label", chip.Label);
                        }

                        if (AppliedDisabled || chip.IsDisabled)
                        {
                            builder.AddAttribute(rendSeq + 2, "disabled");
                        }

                        if (chip.IsElevated)
                        {
                            builder.AddAttribute(rendSeq + 3, "elevated");
                        }

                        if (!string.IsNullOrWhiteSpace(chip.Link))
                        {
                            builder.AddAttribute(rendSeq + 4, "href", chip.Link);

                            if (!string.IsNullOrWhiteSpace(chip.LinkTarget))
                            {
                                builder.AddAttribute(rendSeq + 5, "target", chip.LinkTarget);
                            }
                        }

                        if (chip.IsRemovable)
                        {
                            // Only for filter & input chips
                            if (componentName.Equals("md-filter-chip"))
                            {
                                builder.AddAttribute(rendSeq + 6, "removable");
                            }
                            else if (componentName.Equals("md-input-chip"))
                            {
                                builder.AddAttribute(rendSeq + 7, "remove-only");
                            }
                        }

                        rendSeq += 10;
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
                    rendSeq += 100;
                }
            }
        }
        builder.CloseElement();
    }

    #endregion

}
