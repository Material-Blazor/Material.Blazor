using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Material.Blazor.Internal;

public abstract class InternalProgressIndicator : ComponentFoundation
{
    #region members

    /// <summary>
    /// The progress indicator type.
    /// </summary>
    [Parameter] public bool ProgressIsFourColor { get; set; } = false;
    [Parameter] public double ProgressLevel { get; set; } = 0;
    [Parameter] public MBProgressType ProgressType { get; set; } = MBProgressType.Determinate;


    #endregion

    #region BuildRenderTree

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToArray();

        builder.OpenElement(1, WebComponentName());

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
        }

        if (AppliedDisabled)
        {
            builder.AddAttribute(6, "disabled");
        }

        builder.AddAttribute(7, "class", @class);
        builder.AddAttribute(8, "style", style);
        builder.AddAttribute(9, "id", id);

        builder.CloseElement();
    }

    #endregion

    #region WebComponentName

    /// <summary>
    /// Inherited classes must specify the material-web compoent name.
    /// </summary>
    /// <returns></returns>
    private protected abstract string WebComponentName();

    #endregion

}
