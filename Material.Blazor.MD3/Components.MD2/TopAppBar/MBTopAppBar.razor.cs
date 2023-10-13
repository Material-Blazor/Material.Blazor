using Material.Blazor;
using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;

using System.Threading.Tasks;

namespace Material.Blazor.MD2;

/// <summary>
/// A Material Theme top app bar
/// </summary>
public partial class MBTopAppBar : ComponentFoundation
{
    /// <summary>
    /// App bar title.
    /// </summary>
    [Parameter] public string Title { get; set; }


    /// <summary>
    /// Navigation button icon.
    /// </summary>
    [Parameter] public string NavIcon { get; set; }


    /// <summary>
    /// Navigation button icon color.
    /// </summary>
    [Parameter] public string NavIconColor { get; set; }


    /// <summary>
    /// Render fragment where @Body is referenced.
    /// </summary>
    [Parameter] public RenderFragment ChildContent { get; set; }


    /// <summary>
    /// Page scroll target 
    /// </summary>
    [Parameter] public string ScrollTarget { get; set; }


    /// <summary>
    /// Top app bar type. See <see cref="MBTopAppBarTypeMD2"/>
    /// </summary>
    [Parameter] public MBTopAppBarTypeMD2 TopAppBarType { get; set; } = MBTopAppBarTypeMD2.Standard;


    private ElementReference HeaderElem { get; set; }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        ConditionalCssClasses
            .AddIf("mdc-top-app-bar--fixed", () => (TopAppBarType & MBTopAppBarTypeMD2.Fixed) == MBTopAppBarTypeMD2.Fixed)
            .AddIf("mdc-top-app-bar--dense", () => (TopAppBarType & MBTopAppBarTypeMD2.Dense) == MBTopAppBarTypeMD2.Dense)
            .AddIf("mdc-top-app-bar--prominent", () => (TopAppBarType & MBTopAppBarTypeMD2.Prominent) == MBTopAppBarTypeMD2.Prominent)
            .AddIf("mdc-top-app-bar--short", () => (TopAppBarType & MBTopAppBarTypeMD2.Short) == MBTopAppBarTypeMD2.Short)
            .AddIf("mdc-top-app-bar--short mdc-top-app-bar--short-collapsed", () => (TopAppBarType & MBTopAppBarTypeMD2.ShortCollapsed) == MBTopAppBarTypeMD2.ShortCollapsed);
    }


    /// <inheritdoc/>
    internal override Task InstantiateMcwComponent()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBTopAppBar.init", HeaderElem, ScrollTarget);
    }
}
