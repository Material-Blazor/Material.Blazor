using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BlazorMdc
{
    // This is like InputBase from Microsoft.AspNetCore.Components.Forms, except that it treats
    // [CascadingParameter] EditContext as optional.

    public abstract class MdcInputComponentBase<T> : MdcComponentBase, IMdcDialogChild
    {
        private bool _previousParsingAttemptFailed;
        private ValidationMessageStore _parsingValidationMessages;
        private Type _nullableUnderlyingType;
        private bool _hasSetInitialParameters;
        private T _value;
        private bool _hasRendered = false;
        private bool _instantiate = false;

        [CascadingParameter] EditContext CascadedEditContext { get; set; }

        [CascadingParameter] private MdcDialog Dialog { get; set; }


        /// <summary>
        /// Gets or sets a collection of additional attributes that will be applied to the created element.
        /// </summary>
        [Parameter(CaptureUnmatchedValues = true)] public IReadOnlyDictionary<string, object> AdditionalAttributes { get; set; }

        /// <summary>
        /// Gets a value for the component's 'id' attribute.
        /// </summary>
        [Parameter] public string Id { get; set; } = Utilities.GenerateCssElementSelector();

        /// <summary>
        /// Gets or sets the value of the input. This should be used with two-way binding.
        /// </summary>
        /// <example>
        /// @bind-Value="@model.PropertyName"
        /// </example>
        [Parameter] public T Value
        {
            get => _value;
            set
            {
                var hasChanged = !EqualityComparer<T>.Default.Equals(value, _value);
                if (hasChanged)
                {
                    if (_hasRendered)
                    {
                        Task.Run(async () => await ValueSetterAsync(value));
                    }
                    else
                    {
                        _value = value;
                    }
                }
            }
        }

        /// <summary>
        /// Determines how to handle the consumer setting the Value parameter - can be overridden by Mdc and PMdc components
        /// </summary>
        internal virtual async Task ValueSetterAsync(T value)
        {
            _value = value;
            await Task.CompletedTask;
        }
        
        internal T SetValue(T value)
        {
            return Value = value;
        }

        /// <summary>
        /// Gets or sets a callback that updates the bound value.
        /// </summary>
        [Parameter] public EventCallback<T> ValueChanged { get; set; }

        /// <summary>
        /// Gets or sets an expression that identifies the bound value.
        /// </summary>
        [Parameter] public Expression<Func<T>> ValueExpression { get; set; }

        /// <summary>
        /// Gets the associated <see cref="Microsoft.AspNetCore.Components.Forms.EditContext"/>.
        /// </summary>
        protected EditContext EditContext { get; private set; }

        /// <summary>
        /// Gets the <see cref="FieldIdentifier"/> for the bound value.
        /// </summary>
        protected FieldIdentifier FieldIdentifier { get; private set; }

        /// <summary>
        /// Gets or sets the value of the input. To be used by Mdc and PMdc components for binding to native components, or to set the value
        /// in response to an event arising from the native component. In contrast the <see cref="Value"/> parameter is for use by BlazorMdc's consumers.
        /// Do not mix these usages up.
        /// </summary>
        protected T NativeComponentBoundValue
        {
            get => _value;
            set
            {
                var hasChanged = !EqualityComparer<T>.Default.Equals(value, _value);
                if (hasChanged)
                {
                    _value = value;
                    _ = ValueChanged.InvokeAsync(value);
                    EditContext?.NotifyFieldChanged(FieldIdentifier);
                }
            }
        }

        /// <summary>
        /// Gets or sets the current value of the input, represented as a string.
        /// </summary>
        protected string NativeComponentBoundValueAsString
        {
            get => FormatValueToString(NativeComponentBoundValue);
            set
            {
                _parsingValidationMessages?.Clear();

                bool parsingFailed;

                if (_nullableUnderlyingType != null && string.IsNullOrEmpty(value))
                {
                    // Assume if it's a nullable type, null/empty inputs should correspond to default(T)
                    // Then all subclasses get nullable support almost automatically (they just have to
                    // not reject Nullable<T> based on the type itself).
                    parsingFailed = false;
                    NativeComponentBoundValue = default;
                }
                else if (TryParseValueFromString(value, out var parsedValue, out var validationErrorMessage))
                {
                    parsingFailed = false;
                    NativeComponentBoundValue = parsedValue;
                }
                else
                {
                    parsingFailed = true;

                    if (EditContext != null)
                    {
                        if (_parsingValidationMessages == null)
                        {
                            _parsingValidationMessages = new ValidationMessageStore(EditContext);
                        }

                        _parsingValidationMessages.Add(FieldIdentifier, validationErrorMessage);

                        // Since we're not writing to NativeComponentBoundValue, we'll need to notify about modification from here
                        EditContext.NotifyFieldChanged(FieldIdentifier);
                    }
                }

                // We can skip the validation notification if we were previously valid and still are
                if (parsingFailed || _previousParsingAttemptFailed)
                {
                    EditContext?.NotifyValidationStateChanged();
                    _previousParsingAttemptFailed = parsingFailed;
                }
            }
        }

        /// <summary>
        /// Formats the value as a string. Derived classes can override this to determine the formating used for <see cref="NativeComponentBoundValueAsString"/>.
        /// </summary>
        /// <param name="value">The value to format.</param>
        /// <returns>A string representation of the value.</returns>
        protected virtual string FormatValueToString(T value)
            => value?.ToString();

        /// <summary>
        /// Parses a string to create an instance of <typeparamref name="T"/>. Derived classes can override this to change how
        /// <see cref="NativeComponentBoundValueAsString"/> interprets incoming values.
        /// </summary>
        /// <param name="value">The string value to be parsed.</param>
        /// <param name="result">An instance of <typeparamref name="T"/>.</param>
        /// <param name="validationErrorMessage">If the value could not be parsed, provides a validation error message.</param>
        /// <returns>True if the value could be parsed; otherwise false.</returns>
        protected virtual bool TryParseValueFromString(string value, out T result, out string validationErrorMessage)
            => throw new NotImplementedException($"This component does not parse string inputs. Bind to the '{nameof(NativeComponentBoundValue)}' property, not '{nameof(NativeComponentBoundValueAsString)}'.");

        /// <summary>
        /// Gets a string that indicates the status of the field being edited. This will include
        /// some combination of "modified", "valid", or "invalid", depending on the status of the field.
        /// </summary>
        protected string FieldClass
            => EditContext?.FieldCssClass(FieldIdentifier) ?? string.Empty;


        /// <inheritdoc />
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

                if (Dialog != null)
                {
                    Dialog.RegisterLayoutAction(this);
                }
            }
            else if (CascadedEditContext != EditContext)
            {
                // Not the first run

                // We don't support changing EditContext because it's messy to be clearing up state and event
                // handlers for the previous one, and there's no strong use case. If a strong use case
                // emerges, we can consider changing this.
                throw new InvalidOperationException($"{GetType()} does not support changing the " +
                    $"{nameof(EditContext)} dynamically.");
            }

            // For derived components, retain the usual lifecycle with OnInit/OnParametersSet/etc.
            await base.SetParametersAsync(ParameterView.Empty);
        }


        public void RequestInstantiation()
        {
            _instantiate = true;
        }


        protected override bool ShouldRender()
        {
            return _instantiate;
        }


        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if ((firstRender && (Dialog is null)) || _instantiate)
            {
                _instantiate = false;
                await InitializeMdcComponent();
            }

            if (firstRender)
            {
                _hasRendered = true;
            }
        }
    }
}
