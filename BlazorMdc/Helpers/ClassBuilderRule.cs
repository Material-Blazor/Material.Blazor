//
//  2020-03-31  Mark Stega
//              Created - See MatBlazor for the original implementation by @SamProf
//

namespace BMdcBase
{
    public abstract class ClassBuilderRule<T>
    {
        public abstract string GetClass(T data);
    }
}