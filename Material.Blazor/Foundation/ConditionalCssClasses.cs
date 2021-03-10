//
//  2020-03-31  Mark Stega
//              Created - See MatBlazor for the original implementation by @SamProf
//

using System;
using System.Collections.Generic;
using System.Linq;

namespace Material.Blazor.Internal
{
    /// <summary>
    /// This is a helper class to conditionally apply CSS classes to an HTML element.
    /// Classes are added with the <see cref="AddIf(string, Func{bool})"/> method.
    /// On <see cref="ToString()"/>, just the classes satisfying the condition are returned, joined into one string.
    /// </summary>
    public class ConditionalCssClasses
    {
        private readonly List<Func<string>> Items = new();

        /// <summary>
        /// Executes the defined functions, returning a concatenation of the results separated by a space
        /// </summary>
        /// <returns>string</returns>
        public override string ToString() => string.Join(" ", Items.Select(i => i()));

        /// <summary>
        /// Adds a CSS class, whenever the <param name="func"> method returns true.
        /// </summary>
        /// <param name="name">The string to be conditionally returned</param>
        /// <param name="func">The function to be executed to determine if the string is included</param>
        /// <returns>The instance of the class</returns>
        public ConditionalCssClasses AddIf(string name, Func<bool> func)
        {
            Items.Add(() => func() ? name : null);
            return this;
        }
    }
}
