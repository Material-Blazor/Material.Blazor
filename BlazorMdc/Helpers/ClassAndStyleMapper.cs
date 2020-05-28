//
//  2020-03-31  Mark Stega
//              Created - See MatBlazor for the original implementation by @SamProf
//

using System;
using System.Collections.Generic;

namespace BMdcBase
{
    /// <summary>
    /// The definition of ClassAndStyleMapper and ClassAndStyleMapperExtensions ultimately
    /// define a list ofparameterless functions that return a string.
    /// The Func<string> items are enumerated and evaluated when 
    /// one of the ToXXXXString functions is called 
    /// </summary>
    public class ClassAndStyleMapper
    {
        public List<Func<string>> Items = new List<Func<string>>();
        public string ToClassString()
        {
            //
            // The following easy to read code can be replaced by the
            // single obfuscated line that is commented
            //
            var retval = "";
            foreach (Func<string> f in Items)
            {
                var eval = f();
                if (eval != null)
                {
                    retval += " " + eval;
                }
            }
            return retval;

            // return string.Join(" ", Items.Select(i => i()).Where(i => i != null));
        }
        public string ToStyleString()
        {
            //
            // The following easy to read code can be replaced by the
            // single obfuscated line that is commented
            //
            var retval = "";
            foreach (Func<string> f in Items)
            {
                var eval = f();
                if (eval != null)
                {
                    retval += "; " + eval;
                }
            }
            return retval;

            // return string.Join("; ", Items.Select(i => i()).Where(i => i != null));
        }
    }


    public static class ClassAndStyleMapperExtensions
    {
        public static T Add<T>(this T m, string name) where T : ClassAndStyleMapper
        {
            m.Items.Add(() => name);
            return m;
        }

        public static T AddIf<T>(this T m, string name, Func<bool> func) where T : ClassAndStyleMapper
        {
            m.Items.Add(() => func() ? name : null);
            return m;
        }
    }

}