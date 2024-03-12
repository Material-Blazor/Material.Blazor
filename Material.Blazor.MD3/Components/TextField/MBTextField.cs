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
///// Used by NumericFields
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
    /// The unique id for the text field; Used to locate the text field
    /// from JS interop methods.
    /// 
    /// In normal use there is no need to set this parameter in the calling component
    /// </summary>
    [Parameter] public string TextFieldId { get; set; } = "textfield-id-" + Guid.NewGuid().ToString().ToLower();

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

 //   private MBDensity AppliedDensity => CascadingDefaults.AppliedTextFieldDensity(Density);

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
        var attributesToSplat = AttributesToSplat().ToArray();

        var rendSeq = 0;
        var valueChanged = EventCallback.Factory.CreateBinder(this, ValueChanged.InvokeAsync, Value);

        var componentName = CascadingDefaults.AppliedStyle(TextInputStyle) switch
        {
            MBTextInputStyle.Outlined => "md-outlined-text-field",
            MBTextInputStyle.Filled => "md-filled-text-field",
            _ => throw new System.Exception("Unknown TextInputStyle")
        };

        builder.OpenElement(rendSeq++, componentName);
        {
            builder.AddAttribute(rendSeq++, "class", @class);
            builder.AddAttribute(rendSeq++, "style", style + Utilities.GetTextAlignStyle(CascadingDefaults.AppliedStyle(TextAlignStyle)));
            builder.AddAttribute(rendSeq++, "id", TextFieldId);

            if (attributesToSplat.Any())
            {
                builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
            }

            if (AppliedDisabled)
            {
                builder.AddAttribute(rendSeq++, "disabled");
            }

            builder.AddAttribute(rendSeq++, "id", TextFieldId);

            builder.AddAttribute(rendSeq++, "value", BindConverter.FormatValue(Value));
            builder.AddAttribute(rendSeq++, "onchange", EventCallback.Factory.CreateBinder(this, ValueChanged.InvokeAsync, Value));
            builder.SetUpdatesAttributeName("value");

            builder.AddAttribute(rendSeq++, "label", DisplayLabel);

            if (!string.IsNullOrWhiteSpace(Prefix))
            {
                builder.AddAttribute(rendSeq++, "prefix-text", Prefix);
            }

            if (!string.IsNullOrWhiteSpace(Suffix))
            {
                builder.AddAttribute(rendSeq++, "suffix-text", Suffix);
            }

            if (!string.IsNullOrWhiteSpace(SupportingText))
            {
                builder.AddAttribute(rendSeq++, "supporting-text", SupportingText);
            }

            if (LeadingIcon is not null)
            {
                if (LeadingToggleIcon is null)
                {
                    MBIcon.BuildRenderTreeWorker(
                        builder,
                        ref rendSeq,
                        CascadingDefaults,
                        null,
                        "",
                        "",
                        "",
                        LeadingIcon,
                        "leading-icon");
                }
                else
                {
                    MBIconButton.BuildRenderTreeWorker(
                        builder,
                        ref rendSeq,
                        CascadingDefaults,
                        null,
                        "",
                        "",
                        "",
                        AppliedDisabled,
                        MBIconButtonStyle.Icon,
                        LeadingIcon,
                        LeadingToggleIcon,
                        LeadingToggleIconButtonLink,
                        LeadingToggleIconButtonLinkTarget,
                        LeadingToggleIconSelected,
                        "leading-icon");
                }
            }

            if (TrailingIcon is not null)
            {
                if (TrailingToggleIcon is null)
                {
                    MBIcon.BuildRenderTreeWorker(
                        builder,
                        ref rendSeq,
                        CascadingDefaults,
                        null,
                        "",
                        "",
                        "",
                        TrailingIcon,
                        "trailing-icon");
                }
                else
                {
                    MBIconButton.BuildRenderTreeWorker(
                        builder,
                        ref rendSeq,
                        CascadingDefaults,
                        null,
                        "",
                        "",
                        "",
                        AppliedDisabled,
                        MBIconButtonStyle.Icon,
                        TrailingIcon,
                        TrailingToggleIcon,
                        TrailingToggleIconButtonLink,
                        TrailingToggleIconButtonLinkTarget,
                        TrailingToggleIconSelected,
                        "trailing-icon");
                }
            }
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

    #region SetDateErrorMessage

    internal void SetDateErrorMessage()
    {
        DateFieldErrorMessage = "";
        if (DateTimeField != null)
        {
            DateFieldErrorMessage = MBDateTimeField.ErrorText;
        }
    }

    #endregion

}
