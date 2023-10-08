﻿using Material.Blazor;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.JSInterop;

using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Material.Blazor.Internal;

/// <summary>
/// Base component for Filled and Outlined Text Fields.
/// Required for NumericFields otherwise could have been implemented directly in
/// MBTextField.cs
/// </summary>
public abstract class InternalTextFieldBase : InputComponent<string>
{
    #region members

#nullable enable annotations

    #region cascading parameters

    //[CascadingParameter] private MBDateTimeField DateTimeField { get; set; }

    #endregion

    #region parameters

    /// <summary>
    /// When true collapses the badge.
    /// </summary>
    [Parameter] public bool BadgeExited { get; set; }
    private bool _cachedBadgeExited;

    /// <summary>
    /// The badge's style - see <see cref="MBBadgeStyle"/>, defaults to <see cref="MBBadgeStyle.ValueBearing"/>.
    /// </summary>
    [Parameter] public MBBadgeStyle BadgeStyle { get; set; } = MBBadgeStyle.ValueBearing;

    /// <summary>
    /// The badge value.
    /// </summary>
    [Parameter]
    public string BadgeValue { get; set; }
    private string _cachedBadgeValue;

    /// <summary>
    /// The text field's density.
    /// </summary>
    [Parameter] public MBDensity? Density { get; set; }

    /// <summary>
    /// Determines whether the button has a badge - defaults to false.
    /// </summary>
    [Parameter] public bool HasBadge { get; set; }

    /// <summary>
    /// Field label.
    /// </summary>
    [Parameter] public string? Label { get; set; }

    /// <summary>
    /// The leading icon's name. No leading icon shown if not set.
    /// </summary>
    [Parameter] public MBIconDescriptor? LeadingIcon { get; set; }

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
    /// The trailing icon's name. No leading icon shown if not set.
    /// </summary>
    [Parameter] public MBIconDescriptor? TrailingIcon { get; set; }

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

    /// <summary>
    /// The <code>@ref</code> reference for the top level <code>&lt;label&gt;</code> code block with
    /// class <code>mdc-text-field</code>
    /// </summary>
    internal ElementReference ElementReference { get; set; }

    private string LabelSuffix { get; set; } = "";

    private bool PerformsValidation => EditContext != null && ValidationMessageFor != null;

    /// <summary>
    /// Used by <see cref="MBNumericDoubleField"/> to force the text field to select
    /// all text in the <code>&lt;input&gt;</code> code block.
    /// </summary>
    internal bool SelectAllText { get; set; } = false;

    private bool ShowLabel => !string.IsNullOrWhiteSpace(Label);




    //private MBBadge Badge { get; set; }
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
        var cssClass = (@class + " " + Utilities.GetTextAlignClass(CascadingDefaults.AppliedStyle(TextAlignStyle))).Trim();

        var rendSeq = 0;
        var componentName = "";
        if (TextInputStyle == MBTextInputStyle.Outlined)
        {
            componentName = "md-outlined-text-field";
        }
        else
        {
            componentName = "md-filled-text-field";
        }

        builder.OpenElement(rendSeq++, componentName);
        {
            if (attributesToSplat.Any())
            {
                builder.AddMultipleAttributes(rendSeq++, attributesToSplat);
            }

            if (AppliedDisabled)
            {
                builder.AddAttribute(rendSeq++, "disabled");
            }

            builder.AddAttribute(rendSeq++, "class", cssClass);
            builder.AddAttribute(rendSeq++, "style", style);
            builder.AddAttribute(rendSeq++, "id", id);

            builder.AddAttribute(rendSeq++, "value", BindConverter.FormatValue(Value));
            builder.AddAttribute(rendSeq++, "onchange", EventCallback.Factory.CreateBinder(this, ValueChanged.InvokeAsync, Value));
            builder.SetUpdatesAttributeName("value");


            builder.AddAttribute(rendSeq++, "label", DisplayLabel);

            if (!string.IsNullOrWhiteSpace(Prefix))
            {
                builder.AddAttribute(rendSeq++, "prefixText", Prefix);
            }

            if (!string.IsNullOrWhiteSpace(Suffix))
            {
                builder.AddAttribute(rendSeq++, "suffixText", Suffix);
            }

            if (!string.IsNullOrWhiteSpace(SupportingText))
            {
                builder.AddAttribute(rendSeq++, "supportingText", SupportingText);
            }

            if (LeadingIcon is not null)
            {
                MBIcon.BuildRenderTreeWorker(
                    builder,
                    ref rendSeq,
                    CascadingDefaults,
                    LeadingIcon,
                    "leading-icon");
            }

            if (TrailingIcon is not null)
            {
                MBIcon.BuildRenderTreeWorker(
                    builder,
                    ref rendSeq,
                    CascadingDefaults,
                    TrailingIcon,
                    "trailing-icon");
            }

            builder.AddElementReferenceCapture(rendSeq++, __value => ElementReference = __value);
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

    #region OnParametersSetAsync

    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync().ConfigureAwait(false);

        if (_cachedBadgeValue != BadgeValue || _cachedBadgeExited != BadgeExited)
        {
            _cachedBadgeValue = BadgeValue;
            _cachedBadgeExited = BadgeExited;

            //if (Badge is not null)
            //{
            //    EnqueueJSInteropAction(() => Badge.SetValueAndExited(BadgeValue, BadgeExited));
            //}
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
        await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBTextField2.selectFieldContent", ElementReference).ConfigureAwait(false);
    }

    #endregion

    #region SetDateErrorMessage

    protected void SetDateErrorMessage()
    {
        DateFieldErrorMessage = "";
        //if (DateTimeField != null)
        //{
        //    DateFieldErrorMessage = MBDateTimeField.ErrorText;
        //}
    }

    #endregion

}
