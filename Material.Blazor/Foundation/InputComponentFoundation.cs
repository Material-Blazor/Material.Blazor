using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Material.Blazor.Internal
{
    /// <summary>
    /// This is like InputBase from Microsoft.AspNetCore.Components.Forms, except that it treats
    /// [CascadingParameter] EditContext as optional.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class InputComponentFoundation<T> : ComponentFoundation, IMBDialogChild
    {
        private bool _previousParsingAttemptFailed;
        private ValidationMessageStore _parsingValidationMessages;
        private Type _nullableUnderlyingType;
        private bool _hasSetInitialParameters;
        protected bool _instantiate = false;
        protected bool _hasInstantiated = false;

        [CascadingParameter] private EditContext CascadedEditContext { get; set; }

        [CascadingParameter] private IMBDialog Dialog { get; set; }


        /// <summary>
        /// Gets a value for the component's 'id' attribute.
        /// </summary>
        [Parameter] public string Id { get; set; } = Utilities.GenerateUniqueElementName();


        private T _underlyingValue;
        private T _debouncedUnderlyingValue = default;
        /// <summary>
        /// Gets or sets the value of the input. This should be used with two-way binding.
        /// </summary>
        /// <example>
        /// @bind-Value="@model.PropertyName"
        /// </example>
        [Parameter] public T Value
        {
            get => _underlyingValue;
            set
            {
                if (!EqualityComparer<T>.Default.Equals(value, _underlyingValue))
                {
                    _underlyingValue = value;

                    if (_hasInstantiated)
                    {
                        InvokeAsync(() => DebouncedOnValueSet());
                    }
                    else
                    {
                        _debouncedUnderlyingValue = value;
                    }
                }
            }
        }


        private object _lockable = "";
        /// <summary>
        /// Inserts a 1ms delay to debounce Blazor's two-way binding, which can cause infinite bounce
        /// issues with Material Theme's potential for a JS feedback loop when Blazor occasionally
        /// bounces binding.
        /// </summary>
        /// <returns></returns>
        private async Task DebouncedOnValueSet()
        {
            await Task.Delay(1);

            bool invokeUpdate = false;

            lock (_lockable)
            {
                if (!EqualityComparer<T>.Default.Equals(_debouncedUnderlyingValue, _underlyingValue))
                {
                    _debouncedUnderlyingValue = _underlyingValue;
                    invokeUpdate = true;
                }
            }

            if (invokeUpdate)
            {
                OnValueSet?.Invoke(this, null);
            }
        }

        /// <summary>
        /// Derived components can use this to get a callback from the <see cref="Value"/> setter when the consumer changes the value.
        /// This allows a component to take action with Material Theme js to update the DOM to reflect the data change visually. An
        /// example is a select where the relevant list item needs to be automatically clicked to get Material Theme to update
        /// the value shown in the <c>&lt;input&gt;</c> HTML tag.
        /// </summary>
        protected event EventHandler OnValueSet;


        /// <summary>
        /// Gets or sets a callback that updates the bound value.
        /// </summary>
        [Parameter] public EventCallback<T> ValueChanged { get; set; }


        /// <summary>
        /// Gets or sets an expression that identifies the bound value.
        /// </summary>
        [Parameter] public Expression<Func<T>> ValueExpression { get; set; }


        /// <summary>
        /// Gets the associated EditContext.
        /// </summary>
        protected EditContext EditContext { get; private set; }


        /// <summary>
        /// Gets the <see cref="FieldIdentifier"/> for the bound value.
        /// </summary>
        protected FieldIdentifier FieldIdentifier { get; private set; }


        /// <summary>
        /// Gets or sets the value of the component. To be used by BlazorMdc components for binding to native components, or to set the value
        /// in response to an event arising from the native component. This property fires a change event to the consumer in contrast the 
        /// <see cref="Value"/> parameter. As a result BlazorMdc components must always change the value by using this rather than <see cref="Value"/>
        /// which never fires a change event but does call <see cref="OnValueSet(T)"/> which would cause a race condition if called in response to
        /// user interaction arising within a BlazorMdc component.
        /// </summary>
        private protected T ReportingValue
        {
            get => _underlyingValue;
            set
            {
                var hasChanged = !EqualityComparer<T>.Default.Equals(value, _underlyingValue);
                if (hasChanged)
                {
                    _debouncedUnderlyingValue = value;
                    _underlyingValue = value;
                    _ = ValueChanged.InvokeAsync(value);
                    EditContext?.NotifyFieldChanged(FieldIdentifier);
                    StateHasChanged();
                }
            }
        }


        /// <summary>
        /// Gets or sets the current value of the input, represented as a string.
        /// </summary>
        protected string ReportingValueAsString
        {
            get => FormatValueToString(ReportingValue);
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
                    ReportingValue = default;
                }
                else if (TryParseValueFromString(value, out var parsedValue, out var validationErrorMessage))
                {
                    parsingFailed = false;
                    ReportingValue = parsedValue;
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

                        // Since we're not writing to ReportingValue, we'll need to notify about modification from here
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
        /// Allows <see cref="ShouldRender()"/> to return "true" habitually.
        /// </summary>
        private protected bool ForceShouldRenderToTrue { get; set; } = false;


        /// <summary>
        /// Allows <see cref="ShouldRender()"/> to return "true" for the next render only.
        /// </summary>
        internal bool AllowNextRender = false;


        /// <summary>
        /// Formats the value as a string. Derived classes can override this to determine the formating used for <see cref="ReportingValueAsString"/>.
        /// </summary>
        /// <param name="value">The value to format.</param>
        /// <returns>A string representation of the value.</returns>
        protected virtual string FormatValueToString(T value)
            => value?.ToString();


        /// <summary>
        /// Parses a string to create an instance of <typeparamref name="T"/>. Derived classes can override this to change how
        /// <see cref="ReportingValueAsString"/> interprets incoming values.
        /// </summary>
        /// <param name="value">The string value to be parsed.</param>
        /// <param name="result">An instance of <typeparamref name="T"/>.</param>
        /// <param name="validationErrorMessage">If the value could not be parsed, provides a validation error message.</param>
        /// <returns>True if the value could be parsed; otherwise false.</returns>
        protected virtual bool TryParseValueFromString(string value, out T result, out string validationErrorMessage)
            => throw new NotImplementedException($"This component does not parse string inputs. Bind to the '{nameof(ReportingValue)}' property, not '{nameof(ReportingValueAsString)}'.");


        /// <summary>
        /// Gets a string that indicates the status of the field being edited. This will include
        /// some combination of "modified", "valid", or "invalid", depending on the status of the field.
        /// </summary>
        protected string FieldClass
            => EditContext?.FieldCssClass(FieldIdentifier) ?? string.Empty;


        /// <para>
        /// Components must call base.OnInitialized() otherwise rendering in dialogs will be unpredictable.
        /// </para>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            OnInitDialog();
        }


        /// <para>
        /// Components must call base.OnInitialized() otherwise rendering in dialogs will be unpredictable.
        /// </para>
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            OnInitDialog();
        }


        private void OnInitDialog()
        {
            if (Dialog != null && !Dialog.HasInstantiated)
            {
                Dialog.RegisterLayoutAction(this);
            }
            else
            {
                _instantiate = true;
            }
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor.
        // This implementation of SetParametersAsync is largely untouched from our original fork of Steve Sanderson's
        // RazoComponents.MaterialDesign repo. To be honest we're not entirely sure what it does but we are leaving it
        // alone given Steve's provenance.
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


        /// <inheritdoc/>
        void IMBDialogChild.RequestInstantiation()
        {
            _instantiate = true;
            AllowNextRender = true;
        }


        private protected void AllowNextShouldRender()
        {
            AllowNextRender = true;
        }


        /// <summary>
        /// BlazorMdc components descending from MdcInputComponentBase _*must not*_ override ShouldRender().
        /// </summary>
        protected override bool ShouldRender()
        {
            if (ForceShouldRenderToTrue || AllowNextRender)
            {
                AllowNextRender = false;
                return true;
            }

            return false;
        }


        /// <summary>
        /// BlazorMdc components descending from MdcInputComponentBase _*must not*_ override OnAfterRenderAsync(bool).
        /// </summary>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (_instantiate)
            {
                _instantiate = false;
                _hasInstantiated = true;
                await InitializeMdcComponent();
            }
        }
    }
}
