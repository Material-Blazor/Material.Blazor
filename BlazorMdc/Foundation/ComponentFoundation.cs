using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMdc.Internal
{
    public abstract class ComponentFoundation : ComponentBase, IDisposable
    {
        private readonly string[] ReservedAttributes = { "disabled" };
        private readonly string[] EventAttributeNames = { "onfocus", "onblur", "onfocusin", "onfocusout", "onmouseover", "onmouseout", "onmousemove", "onmousedown", "onmouseup", "onclick", "ondblclick", "onwheel", "onmousewheel", "oncontextmenu", "ondrag", "ondragend", "ondragenter", "ondragleave", "ondragover", "ondragstart", "ondrop", "onkeydown", "onkeyup", "onkeypress", "onchange", "oninput", "oninvalid", "onreset", "onselect", "onselectstart", "onselectionchange", "onsubmit", "onbeforecopy", "onbeforecut", "onbeforepaste", "oncopy", "oncut", "onpaste", "ontouchcancel", "ontouchend", "ontouchmove", "ontouchstart", "ontouchenter", "ontouchleave", "ongotpointercapture", "onlostpointercapture", "onpointercancel", "onpointerdown", "onpointerenter", "onpointerleave", "onpointermove", "onpointerout", "onpointerover", "onpointerup", "oncanplay", "oncanplaythrough", "oncuechange", "ondurationchange", "onemptied", "onpause", "onplay", "onplaying", "onratechange", "onseeked", "onseeking", "onstalled", "onstop", "onsuspend", "ontimeupdate", "onvolumechange", "onwaiting", "onloadstart", "ontimeout", "onabort", "onload", "onloadend", "onprogress", "onerror", "onactivate", "onbeforeactivate", "onbeforedeactivate", "ondeactivate", "onended", "onfullscreenchange", "onfullscreenerror", "onloadeddata", "onloadedmetadata", "onpointerlockchange", "onpointerlockerror", "onreadystatechange", "onscroll" };
        private readonly string[] AriaAttributeNames = { "aria-activedescendant", "aria-atomic", "aria-autocomplete", "aria-busy", "aria-checked", "aria-controls", "aria-describedat", "aria-describedby", "aria-disabled", "aria-dropeffect", "aria-expanded", "aria-flowto", "aria-grabbed", "aria-haspopup", "aria-hidden", "aria-invalid", "aria-label", "aria-labelledby", "aria-level", "aria-live", "aria-multiline", "aria-multiselectable", "aria-orientation", "aria-owns", "aria-posinset", "aria-pressed", "aria-readonly", "aria-relevant", "aria-required", "aria-selected", "aria-setsize", "aria-sort", "aria-valuemax", "aria-valuemin", "aria-valuenow", "aria-valuetext" };
        private bool? disabled = null;

        [Inject] private protected IJSRuntime JsRuntime { get; set; }
        [Inject] private protected IMTTooltipService TooltipService { get; set; }


        [CascadingParameter] protected MTCascadingDefaults CascadingDefaults { get; set; } = new MTCascadingDefaults();


        /// <summary>
        /// Gets or sets a collection of additional attributes that will be applied to the created element.
        /// </summary>
        [Parameter(CaptureUnmatchedValues = true)] public IReadOnlyDictionary<string, object> UnmatchedAttributes { get; set; }




        /// <summary>
        /// Indicates whether the component is disabled.
        /// </summary>
        [Parameter] public bool? Disabled
        {
            get => disabled;
            set
            {
                if (disabled != value)
                {
                    disabled = value;
                    OnDisabledSet?.Invoke(this, null);
                }
            }
        }


        /// <summary>
        /// A markup capable tooltip.
        /// </summary>
        [Parameter] public string Tooltip { get; set; }


        /// <summary>
        /// Tooltip id for aria-describedby attribute.
        /// </summary>
        private Guid TooltipId { get; set; } = Guid.NewGuid();


        /// <summary>
        /// Attributes for splatting to be set by a component's OnInitialized() function.
        /// </summary>
        private protected IDictionary<string, object> ComponentSetAttributes { get; set; } = new Dictionary<string, object>();        internal bool AppliedDisabled => CascadingDefaults.AppliedDisabled(Disabled);


        /// <summary>
        /// Derived components can use this to get a callback from the <see cref="AppliedDisabled"/> setter when the consumer changes the value.
        /// This allows a component to take action with Material Theme js to update the DOM to reflect the data change visually. 
        /// </summary>
        protected event EventHandler OnDisabledSet;


        /// <summary>
        /// Attributes That the component can elect to set for inclusion in SplatAttributes.
        /// </summary>
        private protected IDictionary<string, object> ComponentPureHtmlAttributes { get; set; } = new Dictionary<string, object>(StringComparer.CurrentCultureIgnoreCase);


        /// <summary>
        /// Allows a component to build or map out a group of CSS classes to be applied to the component. Use this in <see cref="OnInitialialized()"/>, <see cref="OnParametersSet()"/> or their asynchronous counterparts.
        /// </summary>
        private protected ClassAndStyleMapper ClassMapper { get; } = new ClassAndStyleMapper();


        /// <summary>
        /// Allows a component to build or map out a group of HTML styles to be applied to the component. Use this in <see cref="OnInitialialized()"/>, <see cref="OnParametersSet()"/> or their asynchronous counterparts.
        /// </summary>
        private protected ClassAndStyleMapper StyleMapper { get; } = new ClassAndStyleMapper();


        /// <summary>
        /// Components should override this with a function to be called when BlazorMdc wants to run Material Theme initialization via JS Interop - always gets called from <see cref="OnAfterRenderAsync()"/>, which should not be overridden.
        /// </summary>
        private protected virtual async Task InitializeMdcComponent() => await Task.CompletedTask;


        private bool disposedValue;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing && !string.IsNullOrWhiteSpace(Tooltip))
                {
                    TooltipService.RemoveTooltip(TooltipId);
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }


        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }



        /// <summary>
        /// Attributes ready for splatting in components. Guaranteed not null, unlike UnmatchedAttributes. Default parameter is <see cref="SplatType.All".
        /// </summary>
        internal IReadOnlyDictionary<string, object> AttributesToSplat(SplatType splatType = SplatType.All)
        {
            var allAttributes = new Dictionary<string, object>(ComponentPureHtmlAttributes);
            var classAndStyle = new Dictionary<string, object>();
            var htmlAttributes = new Dictionary<string, object>(ComponentPureHtmlAttributes);
            var eventAttributes = new Dictionary<string, object>();
            var requiredAttributes = new Dictionary<string, object>();

            var unmatchedClass = UnmatchedAttributes?.Where(a => a.Key.ToLower() == "class").FirstOrDefault().Value ?? "";
            var unmatchedStyle = UnmatchedAttributes?.Where(a => a.Key.ToLower() == "style").FirstOrDefault().Value ?? "";
            var nonStylisticAttributes = new Dictionary<string, object>(UnmatchedAttributes?.Where(a => a.Key.ToLower() != "class" && a.Key.ToLower() != "style") ?? new Dictionary<string, object>());

            // merge ComponentSetAttributes into the dictionary
            nonStylisticAttributes = nonStylisticAttributes.Union(ComponentSetAttributes)
                    .GroupBy(g => g.Key)
                    .ToDictionary(pair => pair.Key, pair => pair.First().Value);

            if (!string.IsNullOrWhiteSpace(Tooltip))
            {
                nonStylisticAttributes.Add("aria-describedby", TooltipId.ToString());
                TooltipService.AddTooltip(TooltipId, new MarkupString(Tooltip));
            }

            if (splatType != SplatType.ClassAndStyleOnly)
            {
                allAttributes = allAttributes.Union(nonStylisticAttributes)
                    .GroupBy(g => g.Key)
                    .ToDictionary(pair => pair.Key, pair => pair.First().Value);

                if (AppliedDisabled) allAttributes.Add("disabled", AppliedDisabled);

                if (splatType == SplatType.ExcludeClassAndStyle) return allAttributes;

                htmlAttributes = allAttributes
                                    .Where(kvp => !EventAttributeNames.Contains(kvp.Key))
                                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

                if (splatType == SplatType.HtmlExcludingClassAndStyle) return htmlAttributes;

                eventAttributes = allAttributes
                                    .Where(kvp => EventAttributeNames.Contains(kvp.Key))
                                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

                if (splatType == SplatType.EventsOnly) return eventAttributes;
            }

            var classString = (ClassMapper.ToClassString() + " " + unmatchedClass).Trim();
            var styleString = (StyleMapper.ToStyleString() + " " + unmatchedStyle).Trim();

            if (!string.IsNullOrWhiteSpace(classString)) classAndStyle.Add("class", classString);
            if (!string.IsNullOrWhiteSpace(styleString)) classAndStyle.Add("style", styleString);

            foreach (var item in classAndStyle)
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

            if (splatType == SplatType.ClassAndStyleOnly)
            {
                return classAndStyle;
            }
            else if (splatType == SplatType.All)
            {
                return allAttributes;
            }

            if ((ushort)(splatType & SplatType.ClassAndStyleOnly) > 0)
            {
                foreach (var item in classAndStyle)
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

            if ((ushort)(splatType & SplatType.HtmlExcludingClassAndStyle) > 0)
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
        /// BlazorMdc components *must always* override this at the start of `OnParametersSet().
        /// </summary>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            CheckAttributeValidity();
        }


        /// <summary>
        /// BlazorMdc components *must always* override this at the start of `OnParametersSet().
        /// </summary>
        protected override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();

            CheckAttributeValidity();
        }


        /// <summary>
        /// BlazorMdc allows a user to limit unmatched attributes that will be splatted to a defined list in <see cref="BlazorMdc.MTCascadingDefaults"/>.
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
                    $"BlazorMdc: You cannot use {string.Join(", ", reserved.Select(x => $"'{x}'"))} attributes in {Utilities.GetTypeName(GetType())}. BlazorMdc reserves the 'display' HTML attributes for internal use; use the 'Display' parameter instead");
            }

            if (!CascadingDefaults.ConstrainSplattableAttributes)
            {
                return;
            }

            var forbidden =
                    UnmatchedAttributes
                        .Select(kvp => kvp.Key)
                        .Except(EventAttributeNames)
                        .Except(AriaAttributeNames)
                        .Except(CascadingDefaults.AppliedAllowedSplattableAttributes);

            if (forbidden.Count() > 0)
            {
                throw new ArgumentException(
                    $"BlazorMdc: You cannot use {string.Join(", ", forbidden.Select(x => $"'{x}'"))} attributes in {Utilities.GetTypeName(GetType())}. Either remove the attribute or change 'ConstrainSplattableAttributes' or 'AllowedSplattableAttributes' in your MTCascadingDefaults");
            }
        }


        /// <summary>
        /// BlazorMdc components generally *should not* override this because it handles the case where components need
        /// to be adjusted when inside an <c>MTDialog</c> or <c>MTCard</c>. 
        /// </summary>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await InitializeMdcComponent();
            }
        }
    }
}
