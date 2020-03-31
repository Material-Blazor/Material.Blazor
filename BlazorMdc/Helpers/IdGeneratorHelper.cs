//
//  2020-03-31  Mark Stega
//              Created - See MatBlazor for the original implementation by @SamProf
//

using System;

namespace BlazorMdc
{
    public static class IdGeneratorHelper
    {
        public static string Generate(string prefix)
        {
            return prefix + Guid.NewGuid();
        }
    }
}