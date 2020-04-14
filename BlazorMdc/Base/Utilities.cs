using System;

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
            switch (textaAlign)
            {
                case MdcTextAlignStyle.Left:
                    return " bmdc-align-left";

                case MdcTextAlignStyle.Center:
                    return " bmdc-align-center";

                case MdcTextAlignStyle.Right:
                    return " bmdc-align-right";
            }

            return "";
        }

        public static string DateToString(DateTime dateTime, string? format = null)
        {
            string myFormat = (format is null) ? "D" : format;

            return dateTime.ToString(myFormat);
        }
    }
}
