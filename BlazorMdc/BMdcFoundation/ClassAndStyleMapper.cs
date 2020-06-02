//
//  2020-03-31  Mark Stega
//              Created - See MatBlazor for the original implementation by @SamProf
//

using System;
using System.Collections.Generic;

namespace BMdcFoundation
{
    /// <summary>
    /// The definition of ClassAndStyleMapper and ClassAndStyleMapperExtensions
    /// ultimately define a list ofparameterless functions that return a string.
    /// The Func<string> items are enumerated and evaluated when 
    /// one of the ToXXXXString functions is called 
    /// </summary>
    public class ClassAndStyleMapper
    {
        public List<Func<string>> Items = new List<Func<string>>();
        public string ToClassString()
        {
            return ToString(" ");
        }

        public string ToStyleString()
        {
            return ToString("; ");
        }

        public string ToString(string prefix)
        {
            var returnValue = "";
            var prefixInUse = "";
            foreach (Func<string> f in Items)
            {
                var eval = f();
                if (eval != null)
                {
                    returnValue += prefixInUse + eval;
                    prefixInUse = prefix;
                }
            }
            return returnValue;
        }
    }


    public static class ClassAndStyleMapperExtensions
    {
        public static ClassAndStyleMapper Add(this ClassAndStyleMapper m, string name)
        {
            m.Items.Add(() => name);
            return m;
        }

        public static ClassAndStyleMapper AddIf(this ClassAndStyleMapper m, string name, Func<bool> func)
        {
            m.Items.Add(() => func() ? name : null);
            return m;
        }

        public static ClassAndStyleMapper Clear(this ClassAndStyleMapper m)
        {
            m.Items.Clear();
            return m;
        }
    }

}