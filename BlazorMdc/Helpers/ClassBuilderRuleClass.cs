//
//  2020-03-31  Mark Stega
//              Created - See MatBlazor for the original implementation by @SamProf
//

namespace BBase
{
    public class ClassBuilderRuleClass<T> : ClassBuilderRule<T>
    {
        public string ClassName { get; set; }


        public ClassBuilderRuleClass(string className)
        {
            ClassName = className;
        }

        public override string GetClass(T data)
        {
            return ClassName;
        }
    }
}