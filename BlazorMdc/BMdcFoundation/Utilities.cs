using BMdcModel;

using System;
using System.Text.RegularExpressions;

namespace BMdcFoundation
{
    internal static class Utilities
    {
        /// <summary>
        /// Compares two doubles to the tolerance of the specified number of decimal places.
        /// </summary>
        /// <param name="left">The first double for the comparison.</param>
        /// <param name="right">The second double for the comparison.</param>
        /// <param name="decimalPlaces">The number of decimal places to take into account.</param>
        /// <returns>True if the two numbers are equal within the specified tolerance, otherwise false.</returns>
        public static bool DoubleEqual(double left, double right, int decimalPlaces = 6)
        {
            double tolerance = Math.Pow(0.1, decimalPlaces);

            return Math.Abs(left - right) <= tolerance;
        }


        /// <summary>
        /// Generates a unique element name using a GUID to use as a CSS class name or tag element id.
        /// </summary>
        /// <returns>The unique name.</returns>
        public static string GenerateUniqueElementName()
        {
            return "bmdc_" + Guid.NewGuid().ToString();
        }


        /// <summary>
        /// Returns a BlazorMdc CSS class 
        /// </summary>
        /// <param name="textaAlign"></param>
        /// <returns><c>bmdc-align-left</c>, <c>...center</c> or <c>...right</c> unless the value is <see cref="eTextAlignStyle.Default"/> returning a blank string.</returns>
        public static string GetTextAlignClass(eTextAlignStyle textaAlign)
        {
            return textaAlign switch
            {
                eTextAlignStyle.Left => " bmdc-align-left",
                eTextAlignStyle.Center => " bmdc-align-center",
                eTextAlignStyle.Right => " bmdc-align-right",
                _ => "",
            };
        }


        /// <summary>
        /// Return a clean, unqualified class name.
        /// </summary>
        /// <param name="componentType"></param>
        /// <returns>The class name stripped of full qualification and trailing characters.</returns>
        public static string GetTypeName(Type componentType)
        {
            return (new Regex("^[a-z,A-Z]*")).Match(componentType.Name).ToString();
        }


#nullable enable annotations
        /// <summary>
        /// Formats <see cref="DateTime" to a string with an optional format string./>
        /// </summary>
        /// <param name="dateTime">The <see cref="DateTime"/> to format.</param>
        /// <param name="format">The format string.</param>
        /// <returns></returns>
        public static string DateToString(DateTime dateTime, string? format = null)
        {
            string myFormat = (format is null) ? "D" : format;

            return dateTime.ToString(myFormat);
        }
#nullable restore annotations
    }
}
