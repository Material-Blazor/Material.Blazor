using System;
using System.Text.RegularExpressions;

namespace BlazorMdc
{
    internal static class Utilities
    {
        public static bool DoubleEqual(double left, double right, int decimalPlaces = 6)
        {
            double tolerance = Math.Pow(0.1, decimalPlaces);

            return Math.Abs(left - right) <= tolerance;
        }

        public static string GenerateCssElementSelector()
        {
            return "bmdc_" + Guid.NewGuid().ToString();
        }

        public static string GetTextAlignClass(MdcTextAlignStyle textaAlign)
        {
            return textaAlign switch
            {
                MdcTextAlignStyle.Left => " bmdc-align-left",
                MdcTextAlignStyle.Center => " bmdc-align-center",
                MdcTextAlignStyle.Right => " bmdc-align-right",
                _ => "",
            };
        }

        public static string GetTypeName(Type componentType)
        {
            return (new Regex("^[a-z,A-Z]*")).Match(componentType.Name).ToString();
        }

#nullable enable annotations
        public static string DateToString(DateTime dateTime, string? format = null)
        {
            string myFormat = (format is null) ? "D" : format;

            return dateTime.ToString(myFormat);
        }
#nullable restore annotations
    }
}
