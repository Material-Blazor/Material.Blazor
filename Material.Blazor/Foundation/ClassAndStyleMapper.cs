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
    /// The definition of ClassAndStyleMapper and ClassAndStyleMapperExtensions
    /// ultimately define a list of parameterless functions that conditionally return a string
    /// if true, a null if false.
    /// <para>
    /// The Func&lt;string&gt; items are enumerated and evaluated when either <see cref="ToClassString"/> or <see cref="ToStyleString"/> are called.
    /// </para>
    /// </summary>
    public class ClassAndStyleMapper
    {
        internal List<Func<string>> Items = new List<Func<string>>();

        /// <summary>
        /// Executes the defined functions, returning a concatenation of the results
        /// separated by a space
        /// </summary>
        /// <returns>string</returns>
        protected string ToClassString()
        {
            return ToString(" ");
        }

        /// <summary>
        /// Executes the defined functions, returning a concatenation of the results
        /// separated by a semicolon and a space
        /// </summary>
        /// <returns>string</returns>
        protected string ToStyleString()
        {
            return ToString("; ");
        }

        private string ToString(string separator)
        {
            return string.Join(separator,
                Items.Select(i => i())   // evaluate each item
                .Where(v => v != null)); // consider only non-null values
        }
    }


    public class ClassMapper : ClassAndStyleMapper
    {
        public override string ToString() => ToClassString();
    }


    public class StyleMapper : ClassAndStyleMapper
    {
        public override string ToString() => ToStyleString();
    }


    public static class ClassAndStyleMapperExtensions
    {
        /// <summary>
        /// Adds a function that always returns the string specified by 'name'
        /// </summary>
        /// <param name="m">The instance of the class</param>
        /// <param name="name"></param>The string to be unconditionally returned
        /// <returns>The instance of the class</returns>
        public static ClassAndStyleMapper Add(this ClassAndStyleMapper m, string name)
        {
            m.Items.Add(() => name);
            return m;
        }

        /// <summary>
        /// Adds a function that conditionally returns the string specified by 'name'
        /// </summary>
        /// <param name="m">The instance of the class</param>
        /// <param name="name">The string to be conditionally returned</param>
        /// <param name="func">The function to be executed to determine if the string is included</param>
        /// <returns>The instance of the class</returns>
        public static ClassAndStyleMapper AddIf(this ClassAndStyleMapper m, string name, Func<bool> func)
        {
            m.Items.Add(() => func() ? name : null);
            return m;
        }

        /// <summary>
        /// Removes all defined items from the list
        /// </summary>
        /// <param name="m">The instance of the class</param>
        /// <returns>The instance of the class</returns>
        public static ClassAndStyleMapper Clear(this ClassAndStyleMapper m)
        {
            m.Items.Clear();
            return m;
        }
    }
}
