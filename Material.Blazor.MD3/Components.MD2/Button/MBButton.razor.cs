﻿using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;

using System.Threading.Tasks;

namespace Material.Blazor.MD2;

/// <summary>
/// This is a general purpose Material Theme button, with provision for standard MB styling, leading 
/// and trailing icons and all standard Blazor events. Adds the "mdc-card__action--button" class when 
/// placed inside an <see cref="MBCard"/>.
/// </summary>
public partial class MBButton : ComponentFoundation
{
    [CascadingParameter] private MBCard Card { get; set; }

    //[CascadingParameter] private MBDialog Dialog { get; set; }


#nullable enable annotations
    /// <summary>
    /// The button's Material Theme style - see <see cref="MBButtonStyleMD2"/>.
    /// <para>Overrides <see cref="MBCascadingDefaults.ButtonStyle"/>, <see cref="MBCascadingDefaults.CardActionButtonStyle"/> or <see cref="MBCascadingDefaults.DialogActionButtonStyle"/> as relevant.</para>
    /// </summary>
    [Parameter] public MBButtonStyleMD2 ButtonStyle { get; set; } = MBButtonStyleMD2.Outlined;


    /// <summary>
    /// The button's density.
    /// </summary>
    [Parameter] public MBDensity? Density { get; set; }


    /// <summary>
    /// The button's label.
    /// </summary>
    [Parameter] public string Label { get; set; }


    /// <summary>
    /// The leading icon's name. No leading icon shown if not set.
    /// </summary>
    [Parameter] public string? LeadingIcon { get; set; }


    /// <summary>
    /// The trailing icon's name. No leading icon shown if not set.
    /// </summary>
    [Parameter] public string? TrailingIcon { get; set; }


    /// <summary>
    /// Inclusion of touch target
    /// </summary>
    [Parameter] public bool? TouchTarget { get; set; }


    /// <summary>
    /// A string value to return from an <see cref="MBDialog"/> when this button is pressed.
    /// </summary>
    [Parameter] public string DialogAction { get; set; }


#nullable restore annotations

    private ElementReference ElementReference { get; set; }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        ConditionalCssClasses
            .AddIf("mdc-button--raised", () => ButtonStyle == MBButtonStyleMD2.ContainedRaised)
            .AddIf("mdc-button--unelevated", () => ButtonStyle == MBButtonStyleMD2.ContainedUnelevated)
            .AddIf("mdc-button--outlined", () => ButtonStyle == MBButtonStyleMD2.Outlined)
            .AddIf("mdc-button--icon-leading", () => !string.IsNullOrWhiteSpace(LeadingIcon))
            .AddIf("mdc-button--icon-trailing", () => !string.IsNullOrWhiteSpace(TrailingIcon))
            .AddIf("mdc-card__action mdc-card__action--button", () => Card != null);
    }


    /// <inheritdoc/>
    internal override Task InstantiateMcwComponent()
    {
        return InvokeJsVoidAsync("MaterialBlazor.MBButton.init", ElementReference);
    }
}