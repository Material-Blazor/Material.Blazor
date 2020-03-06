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
            return "dmdc_" + Guid.NewGuid().ToString();
        }

        public static string GetTextAlignClass(MdcTextAlign textaAlign)
        {
            switch (textaAlign)
            {
                case MdcTextAlign.Left:
                    return " dmdc-align-left";

                case MdcTextAlign.Center:
                    return " dmdc-align-center";

                case MdcTextAlign.Right:
                    return " dmdc-align-right";
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
