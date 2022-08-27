using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;


namespace Material.Blazor;

/// <summary>
/// A material styled wrapper for the <see cref="InputFile"/> component.
/// </summary>
public partial class MBFileUpload : ComponentFoundation
{
#nullable enable annotations
    /// <summary>
    /// The button's Material Theme style - see <see cref="MBButtonStyle"/>.
    /// <para>Overrides <see cref="MBCascadingDefaults.ButtonStyle"/>, <see cref="MBCascadingDefaults.CardActionButtonStyle"/> or <see cref="MBCascadingDefaults.DialogActionButtonStyle"/> as relevant.</para>
    /// </summary>
    [Parameter] public MBButtonStyle? ButtonStyle { get; set; }


    /// <summary>
    /// The button's density.
    /// </summary>
    [Parameter] public MBDensity? Density { get; set; }


    /// <summary>
    /// The button's label.
    /// </summary>
    [Parameter] public string Label { get; set; } = "Choose File";


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
    /// The foundry to use for both leading and trailing icons.
    /// <para><c>IconFoundry="IconHelper.MIIcon()"</c></para>
    /// <para><c>IconFoundry="IconHelper.FAIcon()"</c></para>
    /// <para><c>IconFoundry="IconHelper.OIIcon()"</c></para>
    /// <para>Overrides <see cref="MBCascadingDefaults.IconFoundryName"/></para>
    /// </summary>
    [Parameter] public IMBIconFoundry? IconFoundry { get; set; }


    /// <summary>
    /// Enabled the component to load multiple files.
    /// </summary>
    [Parameter] public bool Multiple { get; set; } = false;


    /// <summary>
    /// Renders the component as a drag and drop area.
    /// </summary>
    [Parameter] public bool DragAndDropArea { get; set; } = false;


    /// <summary>
    /// REQUIRED function called when files are loaded.
    /// </summary>
    [Parameter] public Func<InputFileChangeEventArgs, Task> OnLoadFiles { get; set; }

#nullable restore annotations

    private ElementReference ElementReference { get; set; }


    private async Task OnClick()
    {
        await InvokeJsVoidAsync("MaterialBlazor.MBFileUpload.click", ElementReference).ConfigureAwait(false);
    }
}
