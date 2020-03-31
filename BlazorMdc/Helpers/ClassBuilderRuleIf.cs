//
//  2020-03-31  Mark Stega
//              Created - See MatBlazor for the original implementation by @SamProf
//

using System;

namespace BlazorMdc
{
    public class ClassBuilderRuleIf<T> : ClassBuilderRule<T>
    {
        public string ClassName { get; set; }
        public Func<T, bool> Func { get; set; }

        public ClassBuilderRuleIf(string className, Func<T, bool> func)
        {
            ClassName = className;
            Func = func;
        }

        public override string GetClass(T data)
        {
            if (Func(data))
            {
                return ClassName;
            }

            return null;
        }
    }
}