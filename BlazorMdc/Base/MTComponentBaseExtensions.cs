//
//  2020-03-31  Mark Stega
//              Created - See MatBlazor for the original implementation by @SamProf
//

using Microsoft.AspNetCore.Components;

using System.Collections.Generic;

namespace BlazorMdc.Internal
{
    public static class MTComponentBaseExtensions
    {
        public static bool ParameterIsChanged<T>(this Microsoft.AspNetCore.Components.ComponentBase cmp, ParameterView parameters,
            string parameterName, T value)
        {
            T newValue;
            if (parameters.TryGetValue(parameterName, out newValue))
            {
                if (!EqualityComparer<T>.Default.Equals(value, newValue))
                {
                    return true;
                }
            }

            return false;
        }
    }
}