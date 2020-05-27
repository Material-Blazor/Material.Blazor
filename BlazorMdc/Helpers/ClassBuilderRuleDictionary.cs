//
//  2020-03-31  Mark Stega
//              Created - See MatBlazor for the original implementation by @SamProf
//

using System;
using System.Collections.Generic;

namespace BBase
{
    public class ClassBuilderRuleDictionary<T, TK> : ClassBuilderRule<T>
    {
        public IDictionary<TK, string> Dictionary { get; set; }

        public Func<T, TK> Func { get; set; }

        public ClassBuilderRuleDictionary(Func<T, TK> func, IDictionary<TK, string> dictionary)
        {
            Func = func;
            Dictionary = dictionary;
        }

        public override string GetClass(T data)
        {
            var key = Func(data);

            string value;
            if (Dictionary.TryGetValue(key, out value))
            {
                return value;
            }

            return null;
        }
    }
}