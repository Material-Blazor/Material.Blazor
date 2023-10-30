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

        var rendSeq = 0;

        builder.OpenElement(rendSeq++, "div");
        {
            builder.AddAttribute(rendSeq++, "class", @ActiveConditionalClasses + @class);
            builder.AddAttribute(rendSeq++, "style", @style);
            builder.AddAttribute(rendSeq++, "id", id);
            if (attributesToSplat.Any())
            {
                builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
            }

            foreach (var sse in Items)
            {
                builder.OpenComponent(rendSeq++, typeof(MBRadioButton<TItem>));
                {
                    builder.AddAttribute(rendSeq++, "Density", Density);
                    builder.AddAttribute(rendSeq++, "Disabled", sse.Disabled);
                    builder.AddAttribute(rendSeq++, "LeadingLabelPLUS", sse.LeadingLabel);
                    builder.AddAttribute(rendSeq++, "RadioGroupName", RadioGroupName);
                    if (IsHorizontal)
                    {
                        builder.AddAttribute(rendSeq++, "style", "margin-right: 1em; ");
                    }
                    else
                    {
                        builder.AddAttribute(rendSeq++, "style", "margin-bottom: 1em; ");
                    }
                    builder.AddAttribute(rendSeq++, "TargetCheckedValue", sse.SelectedValue);
                    builder.AddAttribute(rendSeq++, "TrailingLabelPLUS", sse.TrailingLabel);
                    builder.AddAttribute(rendSeq++, "Value", ComponentValue);
                    builder.AddAttribute(rendSeq++, "ValueChanged", RuntimeHelpers.TypeCheck(EventCallback.Factory.Create<TItem>(this, RuntimeHelpers.CreateInferredEventCallback(this, __value => ComponentValue = __value, ComponentValue))));
                    builder.AddAttribute(rendSeq++, "ValueExpression", RuntimeHelpers.TypeCheck<Expression<Func<TItem>>>(() => ComponentValue));
                    builder.SetKey(KeyGenerator(sse.SelectedValue));
                }
                builder.CloseComponent();
            }
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

        AllowAllRenders();

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
