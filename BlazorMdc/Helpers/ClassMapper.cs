//
//  2020-03-31  Mark Stega
//              Created - See MatBlazor for the original implementation by @SamProf
//

using System.Linq;

namespace BBase
{
    public class ClassMapper : BaseMapper
    {
        public override string ToString()
        {
            return string.Join(" ", Items.Select(i => i()).Where(i => i != null));
        }
    }
}