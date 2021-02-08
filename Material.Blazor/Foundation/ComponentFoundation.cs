using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor.Internal
{
    /// <summary>
    /// The base class for all Material.Blazor components.
    /// </summary>
    public abstract class ComponentFoundation : ComponentBase, IDisposable
    {
        private readonly string[] ReservedAttributes = { "disabled" };
        private readonly string[] EventAttributeNames = { "onfocus", "onblur", "onfocusin", "onfocusout", "onmouseover", "onmouseout", "onmousemove", "onmousedown", "onmouseup", "onclick", "ondblclick", "onwheel", "onmousewheel", "oncontextmenu", "ondrag", "ondragend", "ondragenter", "ondragleave", "ondragover", "ondragstart", "ondrop", "onkeydown", "onkeyup", "onkeypress", "onchange", "oninput", "oninvalid", "onreset", "onselect", "onselectstart", "onselectionchange", "onsubmit", "onbeforecopy", "onbeforecut", "onbeforepaste", "oncopy", "oncut", "onpaste", "ontouchcancel", "ontouchend", "ontouchmove", "ontouchstart", "ontouchenter", "ontouchleave", "ongotpointercapture", "onlostpointercapture", "onpointercancel", "onpointerdown", "onpointerenter", "onpointerleave", "onpointermove", "onpointerout", "onpointerover", "onpointerup", "oncanplay", "oncanplaythrough", "oncuechange", "ondurationchange", "onemptied", "onpause", "onplay", "onplaying", "onratechange", "onseeked", "onseeking", "onstalled", "onstop", "onsuspend", "ontimeupdate", "onvolumechange", "onwaiting", "onloadstart", "ontimeout", "onabort", "onload", "onloadend", "onprogress", "onerror", "onactivate", "onbeforeactivate", "onbeforedeactivate", "ondeactivate", "onended", "onfullscreenchange", "onfullscreenerror", "onloadeddata", "onloadedmetadata", "onpointerlockchange", "onpointerlockerror", "onreadystatechange", "onscroll" };
        private readonly string[] AriaAttributeNames = { "aria-activedescendant", "aria-atomic", "aria-autocomplete", "aria-busy", "aria-checked", "aria-controls", "aria-describedat", "aria-describedby", "aria-disabled", "aria-dropeffect", "aria-expanded", "aria-flowto", "aria-grabbed", "aria-haspopup", "aria-hidden", "aria-invalid", "aria-label", "aria-labelledby", "aria-level", "aria-live", "aria-multiline", "aria-multiselectable", "aria-orientation", "aria-owns", "aria-posinset", "aria-pressed", "aria-readonly", "aria-relevant", "aria-required", "aria-selected", "aria-setsize", "aria-sort", "aria-valuemax", "aria-valuemin", "aria-valuenow", "aria-valuetext" };
        private bool? disabled = null;

        [Inject] private protected IJSRuntime JsRuntime { get; set; }
        [Inject] private protected IMBTooltipService TooltipService { get; set; }
        [Inject] private protected ILogger<ComponentFoundation> Logger { get; set; }


        [CascadingParameter] protected MBCascadingDefaults CascadingDefaults { get; set; } = new MBCascadingDefaults();


        /// <summary>
        /// Gets or sets a collection of additional attributes that will be applied to the created element.
        /// </summary>
        [Parameter(CaptureUnmatchedValues = true)] public IReadOnlyDictionary<string, object> UnmatchedAttributes { get; set; }




        /// <summary>
        /// Indicates whether the component is disabled.
        /// </summary>
        [Parameter]
        public bool? Disabled
        {
            get => disabled;
            set
            {
                if (disabled != value)
                {
                    disabled = value;

                    if (HasInstantiated)
                    {
                        OnDisabledSet?.Invoke(this, null);
                    }
                }
            }
        }


        /// <summary>
        /// A markup capable tooltip.
        /// </summary>
        [Parameter] public string Tooltip { get; set; }


        /// <summary>
        /// Gets a value for the component's 'id' attribute.
        /// </summary>
        private protected string CrossReferenceId { get; set; } = Utilities.GenerateUniqueElementName();


        /// <summary>
        /// Tooltip id for aria-describedby attribute.
        /// </summary>
        private Guid TooltipId { get; set; } = Guid.NewGuid();


        /// <summary>
        /// Attributes for splatting to be set by a component's OnInitialized() function.
        /// </summary>
        private protected IDictionary<string, object> ComponentSetAttributes { get; set; } = new Dictionary<string, object>();


        /// <summary>
        /// Determines whether to apply the disabled attribute.
        /// </summary>
        internal bool AppliedDisabled => CascadingDefaults.AppliedDisabled(Disabled);


        /// <summary>
        /// True if the component has been instantiated with a Material Components Web JSInterop call.
        /// </summary>
        private protected bool HasInstantiated { get; set; }


        /// <summary>
        /// Derived components can use this to get a callback from the <see cref="AppliedDisabled"/> setter when the consumer changes the value.
        /// This allows a component to take action with Material Theme js to update the DOM to reflect the data change visually. 
        /// </summary>
        private protected event EventHandler OnDisabledSet;


        /// <summary>
        /// Attributes That the component can elect to set for inclusion in SplatAttributes.
        /// </summary>
        private protected IDictionary<string, object> ComponentPureHtmlAttributes { get; set; } = new Dictionary<string, object>(StringComparer.CurrentCultureIgnoreCase);


        /// <summary>
        /// Allows a component to build or map out a group of CSS classes to be applied to the component. Use this in <see cref="OnInitialialized()"/>, <see cref="OnParametersSet()"/> or their asynchronous counterparts.
        /// </summary>
        private protected ClassMapper ClassMapperInstance { get; } = new ClassMapper();


        /// <summary>
        /// Allows a component to build or map out a group of HTML styles to be applied to the component. Use this in <see cref="OnInitialialized()"/>, <see cref="OnParametersSet()"/> or their asynchronous counterparts.
        /// </summary>
        private protected StyleMapper StyleMapperInstance { get; } = new StyleMapper();


        /// <summary>
        /// Components should override this with a function to be called when Material.Blazor wants to run Material Components Web instantiation via JS Interop - always gets called from <see cref="OnAfterRenderAsync()"/>, which should not be overridden.
        /// </summary>
        private protected virtual async Task InstantiateMcwComponent() => await Task.CompletedTask;


        /// <summary>
        /// Components should override this with a function to be called when Material.Blazor wants to run Material Components Web instantiation via JS Interop - always gets called from <see cref="OnAfterRenderAsync()"/>, which should not be overridden.
        /// </summary>
        private protected virtual async Task DestroyMcwComponent() => await Task.CompletedTask;


        ~ComponentFoundation() => Dispose(false);


        private bool _disposed;
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (HasInstantiated)
            {
                _ = DestroyMcwComponent();
            }

            if (disposing && !string.IsNullOrWhiteSpace(Tooltip))
            {
                TooltipService.RemoveTooltip(TooltipId);
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            _disposed = true;
        }


        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }



        private readonly string[] stylisticAttributes = { "id", "class", "style" };
        /// <summary>
        /// Attributes ready for splatting in components. Guaranteed not null, unlike UnmatchedAttributes. Default parameter is <see cref="SplatType.All".
        /// </summary>
        internal IReadOnlyDictionary<string, object> AttributesToSplat(SplatType splatType = SplatType.All)
        {
            var allAttributes = new Dictionary<string, object>(ComponentPureHtmlAttributes);
            var idClassAndStyle = new Dictionary<string, object>();
            var htmlAttributes = new Dictionary<string, object>(ComponentPureHtmlAttributes);
            var eventAttributes = new Dictionary<string, object>();
            var requiredAttributes = new Dictionary<string, object>();

            var unmatchedId = (UnmatchedAttributes?.Where(a => a.Key == "id").FirstOrDefault().Value ?? "").ToString();
            var unmatchedClass = (UnmatchedAttributes?.Where(a => a.Key == "class").FirstOrDefault().Value ?? "").ToString();
            var unmatchedStyle = (UnmatchedAttributes?.Where(a => a.Key == "style").FirstOrDefault().Value ?? "").ToString();
            var nonStylisticAttributes = new Dictionary<string, object>(UnmatchedAttributes?.Where(a => !stylisticAttributes.Contains(a.Key.ToLower())) ?? new Dictionary<string, object>());

            // merge ComponentSetAttributes into the dictionary
            nonStylisticAttributes = nonStylisticAttributes.Union(ComponentSetAttributes)
                    .GroupBy(g => g.Key)
                    .ToDictionary(pair => pair.Key, pair => pair.First().Value);

            if (!string.IsNullOrWhiteSpace(Tooltip))
            {
                nonStylisticAttributes.Add("aria-describedby", TooltipId.ToString());
            }

            if (splatType != SplatType.IdClassAndStyleOnly)
            {
                allAttributes = allAttributes.Union(nonStylisticAttributes)
                    .GroupBy(g => g.Key)
                    .ToDictionary(pair => pair.Key, pair => pair.First().Value);

                if (AppliedDisabled) allAttributes.Add("disabled", AppliedDisabled);

                if (splatType == SplatType.ExcludeIdClassAndStyle) return allAttributes;

                htmlAttributes = allAttributes
                                    .Where(kvp => !EventAttributeNames.Contains(kvp.Key))
                                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

                if (splatType == SplatType.HtmlExcludingIdClassAndStyle) return htmlAttributes;

                eventAttributes = allAttributes
                                    .Where(kvp => EventAttributeNames.Contains(kvp.Key))
                                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

                if (splatType == SplatType.EventsOnly) return eventAttributes;
            }

            var classString = (ClassMapperInstance.ToString() + " " + unmatchedClass).Trim();
            var styleString = (StyleMapperInstance.ToString() + " " + unmatchedStyle).Trim();

            if (!string.IsNullOrWhiteSpace(unmatchedId)) idClassAndStyle.Add("id", unmatchedId);
            if (!string.IsNullOrWhiteSpace(classString)) idClassAndStyle.Add("class", classString);
            if (!string.IsNullOrWhiteSpace(styleString)) idClassAndStyle.Add("style", styleString);

            foreach (var item in idClassAndStyle)
            {
                if (allAttributes.ContainsKey(item.Key))
                {
                    allAttributes[item.Key] += " " + item.Value;
                }
                else
                {
                    allAttributes.Add(item.Key, item.Value);
                }
            }

            if (splatType == SplatType.IdClassAndStyleOnly)
            {
                return idClassAndStyle;
            }
            else if (splatType == SplatType.All)
            {
                return allAttributes;
            }

            if ((ushort)(splatType & SplatType.IdClassAndStyleOnly) > 0)
            {
                foreach (var item in idClassAndStyle)
                {
                    if (requiredAttributes.ContainsKey(item.Key))
                    {
                        requiredAttributes[item.Key] += " " + item.Value;
                    }
                    else
                    {
                        requiredAttributes.Add(item.Key, item.Value);
                    }
                }
            }

            if ((ushort)(splatType & SplatType.HtmlExcludingIdClassAndStyle) > 0)
            {
                foreach (var item in htmlAttributes)
                {
                    if (requiredAttributes.ContainsKey(item.Key))
                    {
                        requiredAttributes[item.Key] += " " + item.Value;
                    }
                    else
                    {
                        requiredAttributes.Add(item.Key, item.Value);
                    }
                }
            }

            if ((ushort)(splatType & SplatType.EventsOnly) > 0)
            {
                foreach (var item in eventAttributes)
                {
                    requiredAttributes.Add(item.Key, item.Value);
                }
            }

            return requiredAttributes;
        }


        /// <summary>
        /// Material.Blazor components *must always* override this at the start of `OnParametersSet().
        /// </summary>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            CheckAttributeValidity();
        }


        /// <summary>
        /// Material.Blazor components *must always* override this at the start of `OnParametersSet().
        /// </summary>
        protected override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();

            CheckAttributeValidity();
        }


        /// <summary>
        /// Material.Blazor allows a user to limit unmatched attributes that will be splatted to a defined list in <see cref="MBCascadingDefaults"/>.
        /// This method checks validity against that list.
        /// </summary>
        private void CheckAttributeValidity()
        {
            if (UnmatchedAttributes is null)
            {
                return;
            }

            var reserved = UnmatchedAttributes.Keys.Intersect(ReservedAttributes);

            if (reserved.Count() > 0)
            {
                throw new ArgumentException(
                    $"Material.Blazor: You cannot use {string.Join(", ", reserved.Select(x => $"'{x}'"))} attributes in {Utilities.GetTypeName(GetType())}. Material.Blazor reserves the 'display' HTML attributes for internal use; use the 'Display' parameter instead");
            }

            var forbidden =
                    UnmatchedAttributes
                        .Select(kvp => kvp.Key)
                        .Except(EventAttributeNames)
                        .Except(AriaAttributeNames)
                        .Except(CascadingDefaults.AppliedAllowedSplattableAttributes);

            if (forbidden.Count() > 0)
            {
                var message = $"You cannot use {string.Join(", ", forbidden.Select(x => $"'{x}'"))} attributes in {Utilities.GetTypeName(GetType())}. Either remove the attribute or change 'ConstrainSplattableAttributes' or 'AllowedSplattableAttributes' in your MBCascadingDefaults";

                if (CascadingDefaults.ConstrainSplattableAttributes)
                {
                    throw new ArgumentException($"Material.Blazor: {message}");
                }
                else
                {
                    LogMBWarning(message);
                }
            }
        }


        /// <summary>
        /// Material.Blazor components generally *should not* override this because it handles the case where components need
        /// to be adjusted when inside an <c>MBDialog</c> or <c>MBCard</c>. 
        /// </summary>
        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                _ = InstantiateMcwComponent();
                HasInstantiated = true;
                AddTooltip();
            }
        }


        /// <summary>
        /// Material.Blazor components generally *should not* override this because it handles the case where components need
        /// to be adjusted when inside an <c>MBDialog</c> or <c>MBCard</c>. 
        /// </summary>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            OnAfterRender(firstRender);
            await Task.CompletedTask;
        }


        /// <summary>
        /// Adds a tooltip if tooltip text has been provided.
        /// </summary>
        private protected void AddTooltip()
        {
            if (!string.IsNullOrWhiteSpace(Tooltip))
            {
                TooltipService.AddTooltip(TooltipId, new MarkupString(Tooltip));
            }
        }


        /// <summary>
        /// Logs a critical message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        protected void LogMBCritical(EventId eventId, string message, params object[] args) => Logger.LogCritical(eventId, $"MATERIAL.BLAZOR CRITICAL - {message}", args);


        /// <summary>
        /// Logs a critical message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        protected void LogMBCritical(EventId eventId, Exception exception, string message, params object[] args) => Logger.LogCritical(eventId, exception, $"MATERIAL.BLAZOR CRITICAL - {message}", args);


        /// <summary>
        /// Logs a critical message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        protected void LogMBCritical(string message, params object[] args) => Logger.LogCritical($"MATERIAL.BLAZOR CRITICAL - {message}", args);


        /// <summary>
        /// Logs a critical message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        protected void LogMBCritical(Exception exception, string message, params object[] args) => Logger.LogCritical(exception, $"MATERIAL.BLAZOR CRITICAL - {message}", args);


        /// <summary>
        /// Logs a debug message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
#if Logging
        protected void LogMBDebug(EventId eventId, string message, params object[] args) => Logger.LogDebug(eventId, $"MATERIAL.BLAZOR DEBUG - {message}", args);
#else
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Null logging function")]
        protected void LogMBDebug(EventId eventId, string message, params object[] args) {}
#endif


        /// <summary>
        /// Logs a debug message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
#if Logging
        protected void LogMBDebug(EventId eventId, Exception exception, string message, params object[] args) => Logger.LogDebug(eventId, exception, $"MATERIAL.BLAZOR DEBUG - {message}", args);
#else
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Null logging function")]
        protected void LogMBDebug(EventId eventId, Exception exception, string message, params object[] args) { }
#endif


        /// <summary>
        /// Logs a debug message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
#if Logging
        protected void LogMBDebug(string message, params object[] args) => Logger.LogDebug($"MATERIAL.BLAZOR DEBUG - {message}", args);
#else
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Null logging function")]
        protected void LogMBDebug(string message, params object[] args) {}
#endif


        /// <summary>
        /// Logs a debug message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
#if Logging
        protected void LogMBDebug(Exception exception, string message, params object[] args) => Logger.LogDebug(exception, $"MATERIAL.BLAZOR DEBUG - {message}", args);
#else
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Null logging function")]
        protected void LogMBDebug(Exception exception, string message, params object[] args) { }
#endif


        /// <summary>
        /// Logs a debug message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
#if LoggingVerbose
        protected void LogMBDebugVerbose(EventId eventId, string message, params object[] args) => Logger.LogDebug(eventId, $"MATERIAL.BLAZOR DEBUG - {message}", args);
#else
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Null logging function")]
        protected void LogMBDebugVerbose(EventId eventId, string message, params object[] args) {}
#endif


        /// <summary>
        /// Logs a debug message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
#if LoggingVerbose
        protected void LogMBDebugVerbose(EventId eventId, Exception exception, string message, params object[] args) => Logger.LogDebug(eventId, exception, $"MATERIAL.BLAZOR DEBUG - {message}", args);
#else
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Null logging function")]
        protected void LogMBDebugVerbose(EventId eventId, Exception exception, string message, params object[] args) { }
#endif


        /// <summary>
        /// Logs a debug message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
#if LoggingVerbose
        protected void LogMBDebugVerbose(string message, params object[] args) => Logger.LogDebug($"MATERIAL.BLAZOR DEBUG - {message}", args);
#else
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Null logging function")]
        protected void LogMBDebugVerbose(string message, params object[] args) {}
#endif


        /// <summary>
        /// Logs a debug message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
#if LoggingVerbose
        protected void LogMBDebugVerbose(Exception exception, string message, params object[] args) => Logger.LogDebug(exception, $"MATERIAL.BLAZOR DEBUG - {message}", args);
#else
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Null logging function")]
        protected void LogMBDebugVerbose(Exception exception, string message, params object[] args) { }
#endif

        /// <summary>
        /// Logs a error message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        protected void LogMBError(EventId eventId, string message, params object[] args) => Logger.LogError(eventId, $"MATERIAL.BLAZOR ERROR - {message}", args);


        /// <summary>
        /// Logs a error message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        protected void LogMBError(EventId eventId, Exception exception, string message, params object[] args) => Logger.LogError(eventId, exception, $"MATERIAL.BLAZOR ERROR - {message}", args);


        /// <summary>
        /// Logs a error message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        protected void LogMBError(string message, params object[] args) => Logger.LogError($"MATERIAL.BLAZOR ERROR - {message}", args);


        /// <summary>
        /// Logs a error message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        protected void LogMBError(Exception exception, string message, params object[] args) => Logger.LogError(exception, $"MATERIAL.BLAZOR ERROR - {message}", args);


        /// <summary>
        /// Logs a information message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        protected void LogMBInformation(EventId eventId, string message, params object[] args) => Logger.LogInformation(eventId, $"MATERIAL.BLAZOR INFORMATION - {message}", args);


        /// <summary>
        /// Logs a information message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        protected void LogMBInformation(EventId eventId, Exception exception, string message, params object[] args) => Logger.LogInformation(eventId, exception, $"MATERIAL.BLAZOR INFORMATION - {message}", args);


        /// <summary>
        /// Logs a information message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        protected void LogMBInformation(string message, params object[] args) => Logger.LogInformation($"MATERIAL.BLAZOR INFORMATION - {message}", args);


        /// <summary>
        /// Logs a information message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        protected void LogMBInformation(Exception exception, string message, params object[] args) => Logger.LogInformation(exception, $"MATERIAL.BLAZOR INFORMATION - {message}", args);


        /// <summary>
        /// Logs a trace message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        protected void LogMBTrace(EventId eventId, string message, params object[] args) => Logger.LogCritical(eventId, $"MATERIAL.BLAZOR TRACE - {message}", args);


        /// <summary>
        /// Logs a trace message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        protected void LogMBTrace(EventId eventId, Exception exception, string message, params object[] args) => Logger.LogTrace(eventId, exception, $"MATERIAL.BLAZOR TRACE - {message}", args);


        /// <summary>
        /// Logs a trace message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        protected void LogMBTrace(string message, params object[] args) => Logger.LogTrace($"MATERIAL.BLAZOR TRACE - {message}", args);


        /// <summary>
        /// Logs a trace message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        protected void LogMBTrace(Exception exception, string message, params object[] args) => Logger.LogTrace(exception, $"MATERIAL.BLAZOR TRACE - {message}", args);


        /// <summary>
        /// Logs a warning message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        protected void LogMBWarning(EventId eventId, string message, params object[] args) => Logger.LogWarning(eventId, $"MATERIAL.BLAZOR WARNING - {message}", args);


        /// <summary>
        /// Logs a warning message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        protected void LogMBWarning(EventId eventId, Exception exception, string message, params object[] args) => Logger.LogWarning(eventId, exception, $"MATERIAL.BLAZOR WARNING - {message}", args);


        /// <summary>
        /// Logs a warning message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        protected void LogMBWarning(string message, params object[] args) => Logger.LogWarning($"MATERIAL.BLAZOR WARNING - {message}", args);


        /// <summary>
        /// Logs a warning message identifying it as having come from Material.Blazor
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message in message template format. Example: "User {User} logged in from {Address}</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        protected void LogMBWarning(Exception exception, string message, params object[] args) => Logger.LogWarning(exception, $"MATERIAL.BLAZOR WARNING - {message}", args);
    }
}
