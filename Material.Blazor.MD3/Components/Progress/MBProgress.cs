﻿using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

using System.Linq;

namespace Material.Blazor;

/// <summary>
/// A Material.Blazor progress indicator that can be linear or circular.
/// </summary>
public sealed class MBProgress : ComponentFoundation
{
    #region members

    /// <summary>
    /// The progress indicator buffer level for linear determinate progress.
    /// </summary>
    [Parameter] public double? ProgressBufferLevel { get; set; } = null;

    /// <summary>
    /// The progress indicator 4 color option for indeterminate progress.
    /// </summary>
    [Parameter] public bool ProgressIsFourColor { get; set; } = false;


    /// <summary>
    /// The progress indicator level for determinate progress.
    /// </summary>
    [Parameter] public double ProgressLevel { get; set; } = 0;

    /// <summary>
    /// The progress indicator style.
    /// </summary>
    [Parameter] public MBProgressStyle ProgressStyle { get; set; } = MBProgressStyle.Circular;

    /// <summary>
    /// The progress indicator type.
    /// </summary>
    [Parameter] public MBProgressType ProgressType { get; set; } = MBProgressType.Determinate;


    #endregion

    #region BuildRenderTree

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToArray();

        if (ProgressStyle == MBProgressStyle.Circular)
        {
            builder.OpenElement(1, "md-circular-progress");
        }
        else
        {
            builder.OpenElement(1, "md-linear-progress");
        }

        if (attributesToSplat.Any())
        {
            builder.AddMultipleAttributes(2, attributesToSplat);
        }

        if (ProgressType == MBProgressType.Indeterminate)
        {
            builder.AddAttribute(3, "indeterminate");

            if (ProgressIsFourColor)
            {
                builder.AddAttribute(4, "four-color");
            }
        }

        if (ProgressType == MBProgressType.Determinate)
        {
            builder.AddAttribute(5, "value", ProgressLevel.ToString());

            if ((ProgressStyle == MBProgressStyle.Linear) && ProgressBufferLevel is not null)
            {
                builder.AddAttribute(6, "buffer", ProgressBufferLevel.ToString());
            }
        }

        if (AppliedDisabled)
        {
            builder.AddAttribute(7, "disabled");
        }

        builder.AddAttribute(8, "class", @class);
        builder.AddAttribute(9, "style", style);
        builder.AddAttribute(10, "id", id);

        builder.CloseElement();
    }

    #endregion

}
