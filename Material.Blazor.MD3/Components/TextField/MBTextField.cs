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
using System.Threading.Tasks;

namespace Material.Blazor;

///// <summary>
///// Base component for Filled and Outlined Text Fields.
///// Required for NumericFields otherwise could have been implemented directly in
///// MBTextField.cs
///// </summary>

/// <summary>
/// A Material.Blazor text field.
/// </summary>
public sealed class MBTextField : InputComponent<string>
{
    #region members

#nullable enable annotations

    #region cascading parameters

    [CascadingParameter] private MBDateTimeField DateTimeField { get; set; }

    #endregion

    #region non-cascading parameters

    /// <summary>
    /// The text field's density.
    /// </summary>
    [Parameter] public MBDensity? Density { get; set; }

    /// <summary>
    /// Field label.
    /// </summary>
    [Parameter] public string? Label { get; set; }

    /// <summary>
    /// The leading icon's descriptor. No leading icon is shown if not set.
    /// </summary>
    [Parameter] public MBIconDescriptor? LeadingIcon { get; set; }

    /// <summary>
    /// Adding a toggleicon turns the leading icon into a toggleiconbutton.
    /// </summary>
    [Parameter] public MBIconDescriptor? LeadingToggleIcon { get; set; }

    /// <summary>
    /// The link for the iconbutton
    /// </summary>
    [Parameter] public string LeadingToggleIconButtonLink { get; set; }

    /// <summary>
    /// The link target for the iconbutton
    /// </summary>
    [Parameter] public string LeadingToggleIconButtonLinkTarget { get; set; }

    /// <summary>
    /// The toggle state of the icon button
    /// </summary>
    [Parameter] public bool LeadingToggleIconSelected { get; set; }

    /// <summary>
    /// Prefix text.
    /// </summary>
    [Parameter] public string? Prefix { get; set; }

    /// <summary>
    /// Suffix text.
    /// </summary>
    [Parameter] public string? Suffix { get; set; }

    /// <summary>
    /// Supporting text that is displayed either with focus or persistently with <see cref="SupportingTextPersistent"/>.
    /// </summary>
    [Parameter] public string SupportingText { get; set; } = "";

    /// <summary>
    /// Makes the <see cref="SupportingText"/> persistent if true.
    /// </summary>
    [Parameter] public bool SupportingTextPersistent { get; set; } = false;

    /// <summary>
    /// The text alignment style.
    /// <para>Overrides <see cref="MBCascadingDefaults.TextAlignStyle"/></para>
    /// </summary>
    [Parameter] public MBTextAlignStyle? TextAlignStyle { get; set; }

    /// <summary>
    /// The text input style.
    /// <para>Overrides <see cref="MBCascadingDefaults.TextInputStyle"/></para>
    /// </summary>
    [Parameter] public MBTextInputStyle TextInputStyle { get; set; } = MBTextInputStyle.Outlined;

    /// <summary>
    /// The trailing icon's descriptor. No trailing icon is shown if not set.
    /// </summary>
    [Parameter] public MBIconDescriptor? TrailingIcon { get; set; }

    /// <summary>
    /// Adding a toggleicon turns the trailing icon into a toggleiconbutton.
    /// </summary>
    [Parameter] public MBIconDescriptor? TrailingToggleIcon { get; set; }

    /// <summary>
    /// The link for the iconbutton
    /// </summary>
    [Parameter] public string TrailingToggleIconButtonLink { get; set; }

    /// <summary>
    /// The link target for the iconbutton
    /// </summary>
    [Parameter] public string TrailingToggleIconButtonLinkTarget { get; set; }

    /// <summary>
    /// The toggle state of the icon button
    /// </summary>
    [Parameter] public bool TrailingToggleIconSelected { get; set; }

    /// <summary>
    /// Delivers Material Theme validation methods from native Blazor validation. Either use this or
    /// the Blazor <code>ValidationMessage</code> component, but not both. This parameter takes the same input as
    /// <code>ValidationMessage</code>'s <code>For</code> parameter.
    /// </summary>
    [Parameter] public Expression<Func<object>> ValidationMessageFor { get; set; }

    #endregion

#nullable restore annotations

    #region injected members

    [Inject] private IJSRuntime JsRuntime { get; set; }

    #endregion

    #region local members

    private MBDensity AppliedDensity => CascadingDefaults.AppliedTextFieldDensity(Density);

    private string DateFieldErrorMessage { get; set; }

    private string DisplayLabel => Label + LabelSuffix;

    private string LabelSuffix { get; set; } = "";

    private bool PerformsValidation => EditContext != null && ValidationMessageFor != null;

    /// <summary>
    /// Used by <see cref="MBNumericDoubleField"/> to force the text field to select
    /// all text in the <code>&lt;input&gt;</code> code block.
    /// </summary>
    internal bool SelectAllText { get; set; } = false;

    private bool ShowLabel => !string.IsNullOrWhiteSpace(Label);

    private string TextFieldId { get; set; }



    //private readonly string labelId = Utilities.GenerateUniqueElementName();
    //private readonly string SupportingTextId = Utilities.GenerateUniqueElementName();
    //private MBCascadingDefaults.DensityInfo DensityInfo
    //{
    //    get
    //    {
    //        var d = CascadingDefaults.GetDensityCssClass(AppliedDensity);
    //        //var suffix = AppliedInputStyle == MBTextInputStyle.Filled ? "--tf--filled" : "--tf--outlined";
    //        //suffix += string.IsNullOrWhiteSpace(LeadingIcon) ? "" : "-with-leading-icon";
    //        //d.CssClassName += suffix;
    //        return d;
    //    }
    //}

    #endregion

    #endregion

    #region BuildRenderTree

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        TextFieldId = "textfield-id-" + Guid.NewGuid().ToString().ToLower();

        var attributesToSplat = AttributesToSplat().ToArray();

        var rendSeq = 0;
        var valueChanged = EventCallback.Factory.CreateBinder(this, ValueChanged.InvokeAsync, Value);

        BuildRenderTreeWorker(
            builder,
            ref rendSeq,
            CascadingDefaults,
            TextInputStyle,
            TextAlignStyle,
            attributesToSplat,
            Density,
            @class,
            style,
            TextFieldId,
            AppliedDisabled,
            Value,
            valueChanged,
            ValueExpression,
            null,
            DisplayLabel,
            Prefix,
            Suffix,
            SupportingText,
            LeadingIcon,
            LeadingToggleIcon,
            LeadingToggleIconButtonLink,
            LeadingToggleIconButtonLinkTarget,
            LeadingToggleIconSelected,
            TrailingIcon,
            TrailingToggleIcon,
            TrailingToggleIconButtonLink,
            TrailingToggleIconButtonLinkTarget,
            TrailingToggleIconSelected
            );
    }


    public static void BuildRenderTreeWorker(
        RenderTreeBuilder builder,
        ref int rendSeq,
        MBCascadingDefaults cascadingDefaults,
        MBTextInputStyle? textInputStyle,
        MBTextAlignStyle? textAlignStyle,
        KeyValuePair<string, object>[] attributesToSplat,
        MBDensity? density,
        string classString,
        string styleString,
        string idString, 
        bool appliedDisabled,
        string value,
        EventCallback<ChangeEventArgs> valueChanged,
        Expression<Func<string>> valueExpression,
        EventCallback<FocusEventArgs>? focusOut,
        string displayLabel,
        string prefix,
        string suffix,
        string supportingText,
        MBIconDescriptor leadingIcon,
        MBIconDescriptor leadingToggleIcon,
        string leadingToggleIconButtonLink,
        string leadingToggleIconButtonLinkTarget,
        bool leadingToggleIconSelected,
        MBIconDescriptor trailingIcon,
        MBIconDescriptor trailingToggleIcon,
        string trailingToggleIconButtonLink,
        string trailingToggleIconButtonLinkTarget,
        bool trailingToggleIconSelected
        )
    {
        var componentName = cascadingDefaults.AppliedStyle(textInputStyle) switch
        {
            MBTextInputStyle.Outlined => "md-outlined-text-field",
            MBTextInputStyle.Filled => "md-filled-text-field",
            _ => throw new System.Exception("Unknown TextInputStyle")
        };

        builder.OpenElement(rendSeq++, "div");
        {
            builder.AddAttribute(rendSeq++, "class", classString);
            builder.AddAttribute(rendSeq++, "style", styleString + Utilities.GetTextAlignStyle(cascadingDefaults.AppliedStyle(textAlignStyle)));
            builder.AddAttribute(rendSeq++, "id", idString);

            builder.OpenElement(rendSeq++, componentName);
            {
                if (attributesToSplat.Any())
                {
                    builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
                }

                if (appliedDisabled)
                {
                    builder.AddAttribute(rendSeq++, "disabled");
                }

                builder.AddAttribute(rendSeq++, "id", idString);

                builder.AddAttribute(rendSeq++, "value", BindConverter.FormatValue(value));
                builder.AddAttribute(rendSeq++, "onchange", valueChanged);
                builder.SetUpdatesAttributeName("value");


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

                if (focusOut is not null)
                {
                    builder.AddAttribute(rendSeq++, "onfocusout", focusOut);
                }

                if (leadingIcon is not null)
                {
                    if (leadingToggleIcon is null)
                    {
                        MBIcon.BuildRenderTreeWorker(
                            builder,
                            ref rendSeq,
                            cascadingDefaults,
                            null,
                            "",
                            "",
                            "",
                            leadingIcon,
                            "leading-icon");
                    }
                    else
                    {
                        MBIconButton.BuildRenderTreeWorker(
                            builder,
                            ref rendSeq,
                            cascadingDefaults,
                            null,
                            "",
                            "",
                            "",
                            appliedDisabled,
                            MBIconButtonStyle.Icon,
                            leadingIcon,
                            leadingToggleIcon,
                            leadingToggleIconButtonLink,
                            leadingToggleIconButtonLinkTarget,
                            leadingToggleIconSelected,
                            "leading-icon");
                    }
                }

                if (trailingIcon is not null)
                {
                    if (trailingToggleIcon is null)
                    {
                        MBIcon.BuildRenderTreeWorker(
                            builder,
                            ref rendSeq,
                            cascadingDefaults,
                            null,
                            "",
                            "",
                            "",
                            trailingIcon,
                            "trailing-icon");
                    }
                    else
                    {
                        MBIconButton.BuildRenderTreeWorker(
                            builder,
                            ref rendSeq,
                            cascadingDefaults,
                            null,
                            "",
                            "",
                            "",
                            appliedDisabled,
                            MBIconButtonStyle.Icon,
                            trailingIcon,
                            trailingToggleIcon,
                            trailingToggleIconButtonLink,
                            trailingToggleIconButtonLinkTarget,
                            trailingToggleIconSelected,
                            "trailing-icon");
                    }
                }
            }
            builder.CloseElement();
        }
        builder.CloseElement();
    }

    #endregion

    #region Dispose

    private bool _disposed = false;
    protected override void Dispose(bool disposing)
    {
        if (_disposed)
        {
            return;
        }

        if (disposing && EditContext != null)
        {
            EditContext.OnValidationStateChanged -= OnValidationStateChangedCallback;
        }

        _disposed = true;

        base.Dispose(disposing);
    }

    #endregion

    #region OnInitializedAsync

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        SetDateErrorMessage();

        if (EditContext != null)
        {
            EditContext.OnValidationStateChanged += OnValidationStateChangedCallback;

            if (HasRequiredAttribute(ValidationMessageFor))
            {
                LabelSuffix = " *";
            }
        }
    }

    #endregion

    #region OnValidationStateChangedCallback

    private void OnValidationStateChangedCallback(object sender, EventArgs e)
    {
        if (ValidationMessageFor != null)
        {
            var fieldIdentifier = FieldIdentifier.Create(ValidationMessageFor);
            var validationMessage = string.Join("<br />", EditContext.GetValidationMessages(fieldIdentifier));

            //_ = InvokeAsync(() => InvokeJsVoidAsync("MaterialBlazor.MBTextField.setSupportingText", ElementReference, SupportingTextReference, SupportingText.Trim(), SupportingTextPersistent, PerformsValidation, !string.IsNullOrEmpty(Value), validationMessage));
        }
    }

    #endregion

    #region SelectFieldContent

    /// <summary>
    /// Selects the text field content. Used by numeric fields when type is changed to "number".
    /// </summary>
    /// <returns></returns>
    internal async Task SelectFieldContent()
    {
        await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBTextField.selectFieldContent", TextFieldId).ConfigureAwait(false);
    }

    #endregion

    #region SetDateErrorMessage

    protected void SetDateErrorMessage()
    {
        DateFieldErrorMessage = "";
        if (DateTimeField != null)
        {
            DateFieldErrorMessage = MBDateTimeField.ErrorText;
        }
    }

    #endregion

}
