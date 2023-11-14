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
                builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
            }

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

                    builder.OpenElement(rendSeq++, componentName);
                    {
                        if (!string.IsNullOrWhiteSpace(chip.Label))
                        {
                            builder.AddAttribute(rendSeq++, "label", chip.Label);
                        }

                        if (AppliedDisabled || chip.IsDisabled)
                        {
                            builder.AddAttribute(rendSeq++, "disabled");
                        }

                        if (chip.IsElevated)
                        {
                            builder.AddAttribute(rendSeq++, "elevated");
                        }

                        if (!string.IsNullOrWhiteSpace(chip.Link))
                        {
                            builder.AddAttribute(rendSeq++, "href", chip.Link);

                            if (!string.IsNullOrWhiteSpace(chip.LinkTarget))
                            {
                                builder.AddAttribute(rendSeq++, "target", chip.LinkTarget);
                            }
                        }

                        if (chip.IsRemovable)
                        {
                            // Only for filter & input chips
                            if (componentName.Equals("md-filter-chip"))
                            {
                                builder.AddAttribute(rendSeq++, "removable");
                            }
                            else if (componentName.Equals("md-input-chip"))
                            {
                                builder.AddAttribute(rendSeq++, "remove-only");
                            }
                        }

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
