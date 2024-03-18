using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.CompilerServices;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// A group of <see cref="MBRadioButton{TItem}"/>s displayed horizontally or vertically.
/// </summary>
public partial class MBRadioButtonGroup<TItem> : SingleSelectComponent<TItem, MBSingleSelectElement<TItem>>
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


    private string RadioGroupName { get; set; } = Utilities.GenerateUniqueElementName();

    #endregion

    #region BuildRenderTree

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToArray();

        builder.OpenElement(0, "div");
        {
            builder.AddAttribute(1, "class", @ActiveConditionalClasses + @class);
            var additionalStyle = IsHorizontal switch
            {
                true => "display: flex; flex-direction: row; flex-grow: 0; align-items: flex-start; ",
                false => "display: flex; flex-direction: column; flex-grow: 0; align-items: flex-start;"
            };
            builder.AddAttribute(2, "style", additionalStyle + @style);
            builder.AddAttribute(3, "id", id);
            if (attributesToSplat.Any())
            {
                builder.AddMultipleAttributes(4, attributesToSplat);
            }

            var baseRendSeq = 100;
            foreach (var sse in Items)
            {
                builder.OpenComponent(baseRendSeq, typeof(MBRadioButton<TItem>));
                {
                    builder.AddComponentParameter(baseRendSeq + 1, "Density", Density);
                    builder.AddComponentParameter(baseRendSeq + 2, "Disabled", sse.Disabled);
                    builder.AddComponentParameter(baseRendSeq + 3, "LeadingLabelPLUS", sse.LeadingLabel);
                    builder.AddComponentParameter(baseRendSeq + 4, "RadioGroupName", RadioGroupName);
                    if (IsHorizontal)
                    {
                        builder.AddAttribute(baseRendSeq + 5, "style", "margin-right: 1em; ");
                    }
                    else
                    {
                        builder.AddAttribute(baseRendSeq + 5, "style", "margin-bottom: 1em; ");
                    }
                    builder.AddComponentParameter(baseRendSeq + 6, "TargetCheckedValue", sse.SelectedValue);
                    builder.AddComponentParameter(baseRendSeq + 7, "TrailingLabelPLUS", sse.TrailingLabel);
                    builder.AddComponentParameter(baseRendSeq + 8, "Value", ComponentValue);
                    builder.AddComponentParameter(baseRendSeq + 9, "ValueChanged", RuntimeHelpers.TypeCheck(EventCallback.Factory.Create<TItem>(this, RuntimeHelpers.CreateInferredEventCallback(this, __value => ComponentValue = __value, ComponentValue))));
                    builder.AddComponentParameter(baseRendSeq + 10, "ValueExpression", RuntimeHelpers.TypeCheck<Expression<Func<TItem>>>(() => ComponentValue));
                    builder.SetKey(KeyGenerator(sse.SelectedValue));
                }
                builder.CloseComponent();
            }
            baseRendSeq += 100;
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

        ComponentValue = ValidateItemList(Items, appliedItemValidation);

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
