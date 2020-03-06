using System;

namespace BlazorMdc.Components
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

        public static string GetTextAlignClass(MdcTextAlign textaAlign)
        {
            switch (textaAlign)
            {
                case MdcTextAlign.Left:
                    return " bmdc-align-left";

                case MdcTextAlign.Center:
                    return " bmdc-align-center";

                case MdcTextAlign.Right:
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
