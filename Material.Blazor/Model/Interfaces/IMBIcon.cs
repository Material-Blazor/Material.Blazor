using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace Material.Blazor;

/// <summary>
/// Interface providing markup elements for an icon in a given foundry.
/// </summary>
public interface IMBIcon
{
    /// <summary>
    /// A delegate that applies user-defined class, style, and other attributes to the icon.
    /// </summary>
    /// <param name="class"></param>
    /// <param name="style"></param>
    /// <param name="attributes"></param>
    /// <returns></returns>
    delegate RenderFragment IconFragment(string @class, string style, IEnumerable<KeyValuePair<string, object>> attributes);



    /// <summary>
    /// The delegate that combines all the information of the icon into markup.
    /// </summary>
    IconFragment Render { get; }


    /// <summary>
    /// Determines whether color should be set via a filter in the case of Material Icons two-tone theme. Presently partly implemented in toasts only.
    /// </summary>
    bool RequiresColorFilter { get; }
}
