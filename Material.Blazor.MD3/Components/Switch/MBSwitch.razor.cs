using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// This is a general purpose Material Theme switch.
/// </summary>
public sealed class MBSwitch : InputComponent<bool>
{
    /// <summary>
    /// Determines whether the switch shows icons.
    /// </summary>
    [Parameter] public bool? Icons { get; set; }


    /// <summary>
    /// Determines shows icons only in the selected state.
    /// </summary>
    [Parameter] public bool? ShowOnlySelectedIcon { get; set; }

    
    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        //ConditionalCssClasses
        //    .AddIf("mdc-switch--unselected", () => !ComponentValue)
        //    .AddIf("mdc-switch--selected", () => ComponentValue);
    }


    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToArray();

        builder.OpenElement(0, "md-switch");
        {
            if (attributesToSplat.Any())
            {
                builder.AddMultipleAttributes(1, attributesToSplat);
            }

            if (AppliedDisabled)
            {
                builder.AddAttribute(2, "disabled");
            }

            builder.AddAttribute(3, "class", @class);
            builder.AddAttribute(4, "style", style);
            builder.AddAttribute(5, "id", id);
            builder.AddAttribute(6, "selected", BindConverter.FormatValue(Value));
            builder.AddAttribute(7, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, OnClick));
            builder.AddAttribute(8, "icons", CascadingDefaults.AppliedSwitchIcons(Icons));
            builder.AddAttribute(9, "showOnlySelectedIcon", CascadingDefaults.AppliedSwitchSwitchShowOnlySelectedIcon(ShowOnlySelectedIcon));
        }
        builder.CloseElement();
    }


    private async Task OnClick()
    {
        Value = !Value;
        await ValueChanged.InvokeAsync(Value);
    }
}
