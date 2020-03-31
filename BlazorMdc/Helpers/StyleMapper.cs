//
//  2020-03-31  Mark Stega
//              Created - See MatBlazor for the original implementation by @SamProf
//

using System.Linq;

namespace BlazorMdc
{
    public class StyleMapper : BaseMapper
    {
        public string AsString()
        {
            return string.Join("; ", Items.Select(i => i()).Where(i => i != null));
        }


        public override string ToString()
        {
            return AsString();
        }
    }
}