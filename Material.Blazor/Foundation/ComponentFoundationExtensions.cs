//
//  2020-03-31  Mark Stega
//              Created - See MatBlazor for the original implementation by @SamProf
//

using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace Material.Blazor.Internal
{
    /// <summary>
    /// Static utilities.
    /// </summary>
    public static class ComponentFoundationExtensions
    {
        /// <summary>
        /// Detects if a parameter has changed given the component's <see cref="ParameterView"/> and the parameter's name and value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cmp"></param>
        /// <param name="parameters"></param>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ParameterIsChanged<T>(this ComponentBase cmp, ParameterView parameters, string parameterName, T value)
        {
            if (parameters.TryGetValue(parameterName, out T newValue))
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
