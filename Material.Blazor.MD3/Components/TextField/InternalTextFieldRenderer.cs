using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

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
/// A class that implements a single method that renders an MBTextField (for a component that 'has a'
/// component MBTextField such as MBDateTimeField and MBDDecimalField).
/// Also used by a component that 'has a' component MBDecimalField such as MBDoubleField and MBIntField.
/// </summary>
public sealed class InternalTextFieldRenderer
{
    #region BuildTextFieldRenderTree

    public static void BuildTextFieldRenderTree(
        RenderTreeBuilder builder,
        ref int rendSeq,
        MBCascadingDefaults cascadingDefaults,
        Type componentName,
        string classString,
        string styleString,
        bool appliedDisabled,
        MBDensity? density,
        KeyValuePair<string, object>[] attributesToSplat,
        string value,
        EventCallback<string> valueChanged,
        Expression<Func<string>> valueExpression,
        EventCallback<FocusEventArgs>? focusIn,
        EventCallback<FocusEventArgs>? focusOut,
        string displayLabel,
        string prefix,
        string suffix,
        string supportingText,
        MBTextAlignStyle? textAlignStyle,
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
        Expression<Func<object>> ValidationMessageFor
        )
    {
        builder.OpenComponent(rendSeq++, componentName);
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

            builder.AddAttribute(rendSeq++, "type", type);
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

            builder.AddAttribute(rendSeq++, "label", displayLabel);

            if (!string.IsNullOrWhiteSpace(prefix))
            {
                builder.AddAttribute(rendSeq++, "prefixText", prefix);
            }

            if (!string.IsNullOrWhiteSpace(suffix))
            {
                builder.AddAttribute(rendSeq++, "suffixText", suffix);
            }

            if (!string.IsNullOrWhiteSpace(supportingText))
            {
                builder.AddAttribute(rendSeq++, "supportingText", supportingText);
            }

            builder.AddAttribute(rendSeq++, "TextAlignStyle", textAlignStyle);


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

            builder.AddAttribute(rendSeq++, "ValidationMessageFor", ValidationMessageFor);


            //if (Min is not null)
            //{
            //    builder.AddAttribute(21, "min", Min);
            //}

            //if (Max is not null)
            //{
            //    builder.AddAttribute(22, "max", Max);
            //}

            //var step = BuildStep();

            //if (!string.IsNullOrWhiteSpace(step))
            //{
            //    builder.AddAttribute(23, "step", BuildStep());
            //}

        }
        builder.CloseComponent();
    }

    #endregion

}
