using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

namespace Material.Blazor.Internal;

/// <summary>
/// This is like InputBase from Microsoft.AspNetCore.Components.Forms, except that it treats
/// [CascadingParameter] EditContext as optional.
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class InputComponentMD3<T> : ComponentFoundationMD3
{
    #region members

    private bool _previousParsingAttemptFailed;
    private ValidationMessageStore _parsingValidationMessages;
    private Type _nullableUnderlyingType;
    private bool _hasSetInitialParameters;


    /// <summary>
    /// Gets the associated EditContext.
    /// </summary>
    protected EditContext EditContext { get; private set; }


    /// <summary>
    /// Gets the <see cref="FieldIdentifier"/> for the bound value.
    /// </summary>
    protected FieldIdentifier FieldIdentifier { get; private set; }


    /// <summary>
    /// Performs validation only if true. Used by <see cref="MBDebouncedTextField"/> to disable
    /// form validation for the embedded <see cref="MBTextField"/>, because a debounced field
    /// should not be in a form.
    /// </summary>
    private bool IgnoreFormField => this is MBDebouncedTextField or MultiSelectComponent<T, MBSelectElement<T>>;


    /// <summary>
    /// Gets a string that indicates the status of the field being edited. This will include
    /// some combination of "modified", "valid", or "invalid", depending on the status of the field.
    /// </summary>
    protected string FieldClass => !IgnoreFormField ? (EditContext?.FieldCssClass(FieldIdentifier) ?? string.Empty) : string.Empty;

    #endregion

    #region parameters

    [CascadingParameter] private EditContext CascadedEditContext { get; set; }


    /// <summary>
    /// Gets or sets the value of the input. This should be used with two-way binding.
    /// </summary>
    /// <example>
    /// @bind-Value="@model.PropertyName"
    /// </example>
    [Parameter] public T Value { get; set; }


    /// <summary>
    /// Gets or sets a callback that updates the bound value.
    /// </summary>
    [Parameter] public EventCallback<T> ValueChanged { get; set; }


    /// <summary>
    /// Gets or sets an expression that identifies the bound value.
    /// </summary>
    [Parameter] public Expression<Func<T>> ValueExpression { get; set; }

    #endregion

    #region FormatValueToString

    /// <summary>
    /// Formats the value as a string. Derived classes can override this to determine the formating used for <see cref="ComponentValueAsString"/>.
    /// </summary>
    /// <param name="value">The value to format.</param>
    /// <returns>A string representation of the value.</returns>
    protected virtual string FormatValueToString(T value)
        => value?.ToString();

    #endregion

    #region GetExpressionCustomAttributes

    /// <summary>
    /// Returns the custom attributes assocated with a field. Used by <see cref="MBTextArea"/> and <see cref="MBTextField"/> to
    /// look for a required attribute.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="accessor"></param>
    /// <returns></returns>
    private static IEnumerable<Attribute> GetExpressionCustomAttributes<TItem>(Expression<Func<TItem>> accessor)
    {
        var accessorBody = accessor.Body;

        // Unwrap casts to object
        if (accessorBody is UnaryExpression unaryExpression
            && unaryExpression.NodeType == ExpressionType.Convert
            && unaryExpression.Type == typeof(object))
        {
            accessorBody = unaryExpression.Operand;
        }

        if (accessorBody is not MemberExpression memberExpression)
        {
            throw new ArgumentException($"The provided expression contains a {accessorBody.GetType().Name} which is not supported. {nameof(FieldIdentifier)} only supports simple member accessors (fields, properties) of an object.");
        }

        return memberExpression.Member.GetCustomAttributes();
    }

    #endregion

    #region HasRequiredAttribute

    /// <summary>
    /// Returns true if one of the custom attributes is the <see cref="RequiredAttribute"/>. Used by <see cref="MBTextArea"/> and <see cref="MBTextField"/> to
    /// look for a required attribute.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="accessor"></param>
    /// <returns></returns>
    private protected static bool HasRequiredAttribute<TItem>(Expression<Func<TItem>> accessor)
    {
        if (accessor == null)
        {
            return false;
        }

        var customAttributes = GetExpressionCustomAttributes<TItem>(accessor);

        return customAttributes.Any(a => a.GetType() == typeof(RequiredAttribute));
    }

    #endregion

    #region OnInitializedAsync

    /// <para>
    /// Components must call base.OnInitializedAsync() otherwise rendering in dialogs will be unpredictable.
    /// </para>
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        if (EditContext != null && IgnoreFormField)
        {
            LoggingService.LogWarning($"{GetType()} is in a form but has EditContext features disabled because it is considered a valid Material.Blazor form field type");
        }
    }

    #endregion

    #region SetParametersAsync

    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor.
    //
    // This implementation of GetSelectionAsync is largely untouched from our original fork of Steve Sanderson's
    // RazorComponents.MaterialDesign repo. We've added the storage of a cached Value for use in
    // OnSetParameters/OnSetParametersAsync.
    public override async Task SetParametersAsync(ParameterView parameters)
    {
        parameters.SetParameterProperties(this);

        if (!_hasSetInitialParameters)
        {
            // This is the first run
            // Could put this logic in OnInit, but its nice to avoid forcing people who override OnInit to call base.OnInit()

            if (ValueExpression != null)
            {
                FieldIdentifier = FieldIdentifier.Create(ValueExpression);
            }

            EditContext = CascadedEditContext;
            _nullableUnderlyingType = Nullable.GetUnderlyingType(typeof(T));
            _hasSetInitialParameters = true;

            LoggingService.LogTrace($"SetParametersAsync setting ComponentValue value to '{Value?.ToString() ?? "null"}'");
        }
        else if (CascadedEditContext != EditContext)
        {
            // Not the first run, this is a re-render caused by the parent re-render

            // We don't support changing EditContext because it's messy to be clearing up state and event
            // handlers for the previous one, and there's no strong use case. If a strong use case
            // emerges, we can consider changing this.
            throw new InvalidOperationException($"{GetType()} does not support changing the {nameof(EditContext)} dynamically.");
        }

        // For derived components, retain the usual lifecycle with OnInit/OnParametersSet/etc.
        await base.SetParametersAsync(ParameterView.Empty);
    }

    #endregion
}
