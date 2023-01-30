using Material.Blazor.Internal.MD2;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Material.Blazor.MD2;

/// <summary>
/// A Material Theme card with three elements: primary, primary action buttons and action icons.
/// </summary>
public partial class MBCard : ComponentFoundationMD2
{
    /// <summary>
    /// The card style - see <see cref="MBCardStyle"/>
    /// <para>Overrides <see cref="MBCascadingDefaults.CardStyle"/></para>
    /// </summary>
    [Parameter] public MBCardStyle? CardStyle { get; set; }


    /// <summary>
    /// Styles the primary and primary action sections with padding if set to True. This is optional
    /// and you can individually style the HTML in the primary and primary action render fragments if you prefer.
    /// </summary>
    [Parameter] public bool AutoStyled { get; set; }


    /// <summary>
    /// A render fragment for the primary section
    /// </summary>
    [Parameter] public RenderFragment Primary { get; set; }


    /// <summary>
    /// A render fragment for the primary action section, which responds to Blazor events such as @onclick.
    /// </summary>
    [Parameter] public RenderFragment PrimaryAction { get; set; }


    /// <summary>
    /// Non-semantic content that falls outside the <code>mdc-card__content</code> block. See https://github.com/material-components/material-components-web/tree/master/packages/mdc-card#non-semantic-content
    /// </summary>
    [Parameter] public RenderFragment NonSemanticContent { get; set; }


    /// <summary>
    /// The primary action's tabindex attribute - defaults to 0.
    /// </summary>
    [Parameter] public int PrimaryActionTabIndex { get; set; } = 0;


    /// <summary>
    /// The primary action's aria-selected attribute - defaults to false.
    /// </summary>
    [Parameter] public bool PrimaryActionAriaSelected { get; set; } = false;


    /// <summary>
    /// The primary action's aria-controls attribute - defaults to "".
    /// </summary>
    [Parameter] public string PrimaryActionAriaControls { get; set; } = "";


    /// <summary>
    /// The primary action's role attribute - defaults to "".
    /// </summary>
    [Parameter] public string PrimaryActionRole { get; set; } = "";


    /// <summary>
    /// A render fragment where you place <see cref="MBButton"/>s as action buttons.
    /// </summary>
    [Parameter] public RenderFragment ActionButtons { get; set; }


    /// <summary>
    /// A render fragment where you place <see cref="MBIconButton"/>s as action icons.
    /// </summary>
    [Parameter] public RenderFragment ActionIcons { get; set; }


    private string PrimaryClass => AutoStyled ? "mb-card__autostyled" : "";
    private string PrimaryActionClass => AutoStyled ? "mb-card__autostyled-action" : "";
    private ElementReference PrimaryActionReference { get; set; }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
    }


    /// <inheritdoc/>
    internal override Task InstantiateMcwComponent()
    {
        return PrimaryAction != null ? InvokeJsVoidAsync("MaterialBlazor.MBCard.init", PrimaryActionReference) : Task.CompletedTask;
    }
}
