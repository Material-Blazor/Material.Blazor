//
//  2020-03-31  Mark Stega
//              Created - See MatBlazor for the original implementation by @SamProf
//

using System;

namespace BMdcBase
{
    public class ClassBuilderRuleGet<T> : ClassBuilderRule<T>
    {
        public Func<T, string> Func { get; set; }

        public ClassBuilderRuleGet(Func<T, string> func)
        {
            Func = func;
        }

        public override string GetClass(T data)
        {
            return Func(data);
        }
    }
}