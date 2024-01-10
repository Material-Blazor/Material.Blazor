using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using Microsoft.VisualBasic.FileIO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Material.Blazor.Internal;

/// <summary>
/// A class that implements a single method that renders an MBDecimalField for a component that 'has a'
/// component MBDecimalField such as MBDoubleField and MBIntField.
/// </summary>
public sealed class InternalDecimalFieldRenderer
{
    #region BuildDecimalFieldRenderTree

    public static void BuildDecimalFieldRenderTree(
        RenderTreeBuilder builder,
        ref int rendSeq,
        MBCascadingDefaults cascadingDefaults,
        string classString,
        string styleString,
        bool appliedDisabled,
        MBDensity? density,
        IEnumerable<KeyValuePair<string, object>> attributesToSplat,
        decimal value,
        EventCallback<decimal> valueChanged,
        Expression<Func<decimal>> valueExpression,
        EventCallback? focusIn,
        EventCallback? focusOut,
        int? decimalPlaces,
        MBNumericInputMagnitude? focusedMagnitude,
        string label,
        decimal? min,
        decimal? max,
        string numericFormat,
        string numericSingularFormat,
        string prefix,
        string suffix,
        string supportingText,
        MBTextAlignStyle? textAlignStyle,
        string textFieldId,
        MBTextInputStyle? textInputStyle,
        string type,
        MBIconDescriptor leadingIcon,
        MBIconDescriptor leadingToggleIcon,
        string leadingToggleIconButtonLink,
        string leadingToggleIconButtonLinkTarget,
        bool leadingToggleIconSelected,
        MBIconDescriptor trailingIcon,
        MBIconDescriptor trailingToggleIcon,
        string trailingToggleIconButtonLink,
        string trailingToggleIconButtonLinkTarget,
        bool trailingToggleIconSelected,
        MBNumericInputMagnitude? unfocusedMagnitude,
        Expression<Func<object>> ValidationMessageFor)
    {
        builder.OpenComponent(rendSeq++, typeof(MBDecimalField));
        {
            builder.AddAttribute(rendSeq++, "class", classString);
            builder.AddAttribute(rendSeq++, "style", styleString + Utilities.GetTextAlignStyle(cascadingDefaults.AppliedStyle(textAlignStyle)));
            builder.AddAttribute(rendSeq++, "Disabled", appliedDisabled);

            if (density is not null)
            {
                builder.AddAttribute(rendSeq++, "Density", density);
            }

            if (attributesToSplat.Any())
            {
                builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
            }

            if (type is not null)
            {
                builder.AddAttribute(rendSeq++, "type", type);
            }
            builder.AddAttribute(rendSeq++, "Value", value);
            builder.AddAttribute(rendSeq++, "ValueChanged", valueChanged);
            builder.AddAttribute(rendSeq++, "ValueExpression", valueExpression);

            if (focusIn is not null)
            {
                builder.AddAttribute(rendSeq++, "onfocusin", focusIn);
            }

            if (focusOut is not null)
            {
                builder.AddAttribute(rendSeq++, "onfocusout", focusOut);
            }


            if (decimalPlaces is not null)
            {
                builder.AddAttribute(rendSeq++, "DecimalPlaces", decimalPlaces);
            }

            if (focusedMagnitude is not null)
            {
                builder.AddAttribute(rendSeq++, "FocusedMagnitude", focusedMagnitude);
            }

            builder.AddAttribute(rendSeq++, "label", label);

            if (min is not null)
            {
                builder.AddAttribute(rendSeq++, "Min", min);
            }

            if (max is not null)
            {
                builder.AddAttribute(rendSeq++, "Max", max);
            }

            if (numericFormat is not null)
            {
                builder.AddAttribute(rendSeq++, "NumericFormat", numericFormat);
            }

            if (numericSingularFormat is not null)
            {
                builder.AddAttribute(rendSeq++, "NumericSingularFormat", numericSingularFormat);
            }

            if (!string.IsNullOrWhiteSpace(prefix))
            {
                builder.AddAttribute(rendSeq++, "Prefix", prefix);
            }

            if (!string.IsNullOrWhiteSpace(suffix))
            {
                builder.AddAttribute(rendSeq++, "Suffix", suffix);
            }

            if (!string.IsNullOrWhiteSpace(supportingText))
            {
                builder.AddAttribute(rendSeq++, "SupportingText", supportingText);
            }

            builder.AddAttribute(rendSeq++, "TextAlignStyle", textAlignStyle);

            builder.AddAttribute(rendSeq++, "TextFieldId", textFieldId);

            builder.AddAttribute(rendSeq++, "TextInputStyle", textInputStyle);


            if (leadingIcon is not null)
            {
                builder.AddAttribute(rendSeq++, "LeadingIcon", leadingIcon);
            }

            if (leadingToggleIcon is not null)
            {
                builder.AddAttribute(rendSeq++, "LeadingToggleIcon", leadingToggleIcon);
            }

            if (leadingToggleIconButtonLink is not null)
            {
                builder.AddAttribute(rendSeq++, "LeadingToggleIconButtonLink", leadingToggleIconButtonLink);
            }

            if (leadingToggleIconButtonLinkTarget is not null)
            {
                builder.AddAttribute(rendSeq++, "LeadingToggleIconButtonLinkTarget", leadingToggleIconButtonLinkTarget);
            }

            builder.AddAttribute(rendSeq++, "LeadingToggleIconSelected", leadingToggleIconSelected);


            if (trailingIcon is not null)
            {
                builder.AddAttribute(rendSeq++, "TrailingIcon", trailingIcon);
            }

            if (trailingToggleIcon is not null)
            {
                builder.AddAttribute(rendSeq++, "TrailingToggleIcon", trailingToggleIcon);
            }

            if (trailingToggleIconButtonLink is not null)
            {
                builder.AddAttribute(rendSeq++, "TrailingToggleIconButtonLink", trailingToggleIconButtonLink);
            }

            if (trailingToggleIconButtonLinkTarget is not null)
            {
                builder.AddAttribute(rendSeq++, "TrailingToggleIconButtonLinkTarget", trailingToggleIconButtonLinkTarget);
            }

            builder.AddAttribute(rendSeq++, "TrailingToggleIconSelected", trailingToggleIconSelected);

            if (unfocusedMagnitude is not null)
            {
                builder.AddAttribute(rendSeq++, "UnfocusedMagnitude", unfocusedMagnitude);
            }

            builder.AddAttribute(rendSeq++, "ValidationMessageFor", ValidationMessageFor);

        }
        builder.CloseComponent();
    }

    #endregion

}
