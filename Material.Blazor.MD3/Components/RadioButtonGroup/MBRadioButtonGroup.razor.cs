using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// A group of <see cref="MBRadioButton{TItem}"/>s displayed horizontally or vertically.
/// </summary>
public partial class MBRadioButtonGroup<TItem> : SingleSelectComponent<TItem, MBSelectElement<TItem>>
{
    #region members

    /// <summary>
    /// The radio button's density.
    /// </summary>
    [Parameter] public MBDensity? Density { get; set; }

    /// <summary>
    /// Stack the radio buttons horizontally if true, otherwise vertical placement.
    /// </summary>
    [Parameter] public bool IsHorizontal { get; set; } = true;

    /// <summary>
    /// Use LeadingLabel if true, otherwise use trailing label.
    /// </summary>
    [Parameter] public bool UseLeadingLabel { get; set; } = false;


    private string RadioGroupName { get; set; } = Utilities.GenerateUniqueElementName();

    #endregion

    #region BuildRenderTree

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToArray();

        var rendSeq = 0;

        builder.OpenElement(rendSeq++, "div");
        builder.AddAttribute(rendSeq++, "class", @ActiveConditionalClasses + @class);
        builder.AddAttribute(rendSeq++, "style", @style);
        builder.AddAttribute(rendSeq++, "id", id);
        if (attributesToSplat.Any())
        {
            builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
        }

        foreach(var rb in Items)
        {
            builder.OpenElement(rendSeq++, "div");
            {
                builder.AddAttribute(rendSeq++, "style", "margin-right: 2em; ");

                builder.OpenComponent(rendSeq++, typeof(MBRadioButton<TItem>));
                {
                    builder.AddAttribute(rendSeq++, "Density", Density);
                    builder.AddAttribute(rendSeq++, "Disabled", rb.Disabled);
                    //builder.AddAttribute(rendSeq++, "@key", KeyGenerator(rb.SelectedValue));
                    if (UseLeadingLabel)
                    {
                        builder.AddAttribute(rendSeq++, "LeadingLabelPLUS", rb.Label);
                    }
                    else
                    {
                        builder.AddAttribute(rendSeq++, "TrailingLabelPLUS", rb.Label);
                    }
                    builder.AddAttribute(rendSeq++, "RadioGroupName", RadioGroupName);
                    builder.AddAttribute(rendSeq++, "TargetCheckedValue", rb.SelectedValue);
                }
                builder.CloseComponent();
            }
            builder.CloseElement();
        }

        builder.CloseElement();

    }

    #endregion

    #region OnInitializedAsync

    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        MBItemValidation appliedItemValidation = MBItemValidation.DefaultToFirst;

        //ForceShouldRenderToTrue = true;

        bool hasValue;

        (hasValue, ComponentValue) = ValidateItemList(Items, appliedItemValidation);

        ConditionalCssClasses.AddIf("mb-radiobuttongroup__horizontal", () => IsHorizontal);
        ConditionalCssClasses.AddIf("mb-radiobuttongroup__vertical", () => !IsHorizontal);
    }

    #endregion

    #region OnParametersSetAsync

    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();

        KeyGenerator = GetKeysFunc ?? delegate (TItem item) { return item; };
    }

    #endregion

}
