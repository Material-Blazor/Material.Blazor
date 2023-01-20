﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Material.Blazor.Internal;

/// <summary>
/// Base component for Filled and Outlined Text Fields.
/// </summary>
public abstract class InternalTextFieldBase : InputComponentMD3<string>
{
    [CascadingParameter] private MBDateTimeField DateTimeField { get; set; }


#nullable enable annotations

    /// <summary>
    /// Determines whether the button has a badge - defaults to false.
    /// </summary>
    [Parameter] public bool HasBadge { get; set; }


    /// <summary>
    /// The badge's style - see <see cref="MBBadgeStyle"/>, defaults to <see cref="MBBadgeStyle.ValueBearing"/>.
    /// </summary>
    [Parameter] public MBBadgeStyle BadgeStyle { get; set; } = MBBadgeStyle.ValueBearing;


    /// <summary>
    /// When true collapses the badge.
    /// </summary>
    [Parameter]
    public bool BadgeExited { get; set; }
    private bool _cachedBadgeExited;


    /// <summary>
    /// The button's density.
    /// </summary>
    [Parameter]
    public string BadgeValue { get; set; }
    private string _cachedBadgeValue;


    /// <summary>
    /// The text field's density.
    /// </summary>
    [Parameter] public MBDensity? Density { get; set; }


    /// <summary>
    /// Helper text that is displayed either with focus or persistently with <see cref="HelperTextPersistent"/>.
    /// </summary>
    [Parameter] public string HelperText { get; set; } = "";


    /// <summary>
    /// Makes the <see cref="HelperText"/> persistent if true.
    /// </summary>
    [Parameter] public bool HelperTextPersistent { get; set; } = false;


    /// <summary>
    /// The leading icon's name. No leading icon shown if not set.
    /// </summary>
    [Parameter] public string? LeadingIcon { get; set; }


    /// <summary>
    /// Field label.
    /// </summary>
    [Parameter] public string? Label { get; set; }


    /// <summary>
    /// Prefix text.
    /// </summary>
    [Parameter] public string? Prefix { get; set; }


    /// <summary>
    /// Suffix text.
    /// </summary>
    [Parameter] public string? Suffix { get; set; }


    /// <summary>
    /// The text alignment style.
    /// <para>Overrides <see cref="MBCascadingDefaults.TextAlignStyle"/></para>
    /// </summary>
    [Parameter] public MBTextAlignStyle? TextAlignStyle { get; set; }


    /// <summary>
    /// The trailing icon's name. No leading icon shown if not set.
    /// </summary>
    [Parameter] public string? TrailingIcon { get; set; }


    /// <summary>
    /// Delivers Material Theme validation methods from native Blazor validation. Either use this or
    /// the Blazor <code>ValidationMessage</code> component, but not both. This parameter takes the same input as
    /// <code>ValidationMessage</code>'s <code>For</code> parameter.
    /// </summary>
    [Parameter] public Expression<Func<object>> ValidationMessageFor { get; set; }

#nullable restore annotations


    /// <summary>
    /// The <code>@ref</code> reference for the top level <code>&lt;label&gt;</code> code block with
    /// class <code>mdc-text-field</code>
    /// </summary>
    internal ElementReference ElementReference { get; set; }


    /// <summary>
    /// Used by <see cref="MBNumericDoubleField"/> to force the text field to select
    /// all text in the <code>&lt;input&gt;</code> code block.
    /// </summary>
    internal bool SelectAllText { get; set; } = false;


    private MBDensity AppliedDensity => CascadingDefaults.AppliedTextFieldDensity(Density);
    private string AppliedTextInputStyleClass => Utilities.GetTextAlignClass(CascadingDefaults.AppliedStyle(TextAlignStyle));
    private string DisplayLabel => Label + LabelSuffix;
    private string FloatingLabelClass { get; set; }
    private ElementReference InputReference { get; set; }
    private MarkupString HelperTextMarkup => new(HelperText);
    private ElementReference HelperTextReference { get; set; }
    private ElementReference ErrorTextReference { get; set; }
    private string DateFieldErrorMessage { get; set; }
    private bool HasErrorText => !string.IsNullOrWhiteSpace(DateFieldErrorMessage);
    private bool HasHelperText => !string.IsNullOrWhiteSpace(HelperText) || PerformsValidation;
    private string LabelSuffix { get; set; } = "";
    private bool PerformsValidation => EditContext != null && ValidationMessageFor != null;
    private MBBadge Badge { get; set; }




    private readonly string labelId = Utilities.GenerateUniqueElementName();
    private readonly string helperTextId = Utilities.GenerateUniqueElementName();


    private MBCascadingDefaults.DensityInfo DensityInfo
    {
        get
        {
            var d = CascadingDefaults.GetDensityCssClass(AppliedDensity);

            //var suffix = AppliedInputStyle == MBTextInputStyle.Filled ? "--tf--filled" : "--tf--outlined";
            //suffix += string.IsNullOrWhiteSpace(LeadingIcon) ? "" : "-with-leading-icon";

            //d.CssClassName += suffix;

            return d;
        }
    }

    private bool ShowLabel => !string.IsNullOrWhiteSpace(Label);


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        SetDateErrorMessage();

        //_ = ConditionalCssClasses
        //    .AddIf(DensityInfo.CssClassName, () => DensityInfo.ApplyCssClass)
        //    .AddIf(FieldClass, () => !string.IsNullOrWhiteSpace(FieldClass))
        //    .AddIf("mdc-text-field--filled", () => AppliedInputStyle == MBTextInputStyle.Filled)
        //    .AddIf("mdc-text-field--outlined", () => AppliedInputStyle == MBTextInputStyle.Outlined)
        //    .AddIf("mdc-text-field--no-label", () => !ShowLabel)
        //    .AddIf("mdc-text-field--disabled", () => AppliedDisabled)
        //    .AddIf("mdc-text-field--with-leading-icon", () => LeadingIcon is not null)
        //    .AddIf("mdc-text-field--with-trailing-icon", () => TrailingIcon is not null)
        //    .AddIf("mb-date-field", () => DateTimeField is not null);

        //FloatingLabelClass = string.IsNullOrEmpty(ComponentValue) ? "" : "mdc-floating-label--float-above";

        if (EditContext != null)
        {
            EditContext.OnValidationStateChanged += OnValidationStateChangedCallback;

            if (HasRequiredAttribute(ValidationMessageFor))
            {
                LabelSuffix = " *";
            }
        }
    }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync().ConfigureAwait(false);

        if (_cachedBadgeValue != BadgeValue || _cachedBadgeExited != BadgeExited)
        {
            _cachedBadgeValue = BadgeValue;
            _cachedBadgeExited = BadgeExited;

            if (Badge is not null)
            {
                //EnqueueJSInteropAction(() => Badge.SetValueAndExited(BadgeValue, BadgeExited));
            }
        }
    }


    /// <inheritdoc/>
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, ComponentName());
        {
            builder.AddAttribute(1, "class", @class);
            builder.AddAttribute(2, "style", style);
            builder.AddAttribute(3, "id", id);

            builder.AddAttribute(4, "value", BindConverter.FormatValue(Value));
            builder.AddAttribute(5, "onchange", EventCallback.Factory.CreateBinder(this, ValueChanged.InvokeAsync, Value));
            builder.SetUpdatesAttributeName("value");

            if (AppliedDisabled)
            {
                builder.AddAttribute(6, "disabled");
            }

            builder.AddAttribute(7, "label", DisplayLabel);
            
            if (!string.IsNullOrWhiteSpace(Prefix))
            {
                builder.AddAttribute(8, "prefixText", Prefix);
            }

            if (!string.IsNullOrWhiteSpace(Suffix))
            {
                builder.AddAttribute(9, "suffixText", Suffix);
            }

            if (!string.IsNullOrWhiteSpace(LeadingIcon))
            {
                builder.OpenElement(10, "md-icon");
                {
                    builder.AddAttribute(11, "slot", "leadingicon");
                    builder.AddContent(12, LeadingIcon);
                }
                builder.CloseElement();
            }

            if (!string.IsNullOrWhiteSpace(TrailingIcon))
            {
                builder.OpenElement(13, "md-icon");
                {
                    builder.AddAttribute(14, "slot", "trailingicon");
                    builder.AddContent(15, TrailingIcon);
                }
                builder.CloseElement();
            }
        }
        builder.CloseElement();
    }


    /// <summary>
    /// Inherited classes must specify the material-web compoent name.
    /// </summary>
    /// <returns></returns>
    private protected abstract string ComponentName();



    protected void SetDateErrorMessage()
    {
        DateFieldErrorMessage = "";
        if (DateTimeField != null)
        {
            DateFieldErrorMessage = MBDateTimeField.ErrorText;
        }
    }


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


    private void OnValidationStateChangedCallback(object sender, EventArgs e)
    {
        if (ValidationMessageFor != null)
        {
            var fieldIdentifier = FieldIdentifier.Create(ValidationMessageFor);
            var validationMessage = string.Join("<br />", EditContext.GetValidationMessages(fieldIdentifier));

            //_ = InvokeAsync(() => InvokeJsVoidAsync("MaterialBlazor.MBTextField.setHelperText", ElementReference, HelperTextReference, HelperText.Trim(), HelperTextPersistent, PerformsValidation, !string.IsNullOrEmpty(Value), validationMessage));
        }
    }
}
