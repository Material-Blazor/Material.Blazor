//
//  2020-03-31  Mark Stega
//              Added ClassMapper/Class & StyleMapper/Style
//
//  2020-04-13  Mark Stega
//              Reworked 
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// Determines what attributes to splat from <see cref="SplatAttributes"/>.
    /// </summary>
    internal enum SplatType : ushort
    { 
        /// <summary>
        /// Return all attributes including class and style, also including values from <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        All = 0xFFFF,

        /// <summary>
        /// Return only class and style values, which includes <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        ClassAndStyleOnly = 0x0002,

        /// <summary>
        /// Return only class and style values, which includes <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        HtmlExcludingClassAndStyle = 0x0004,

        /// <summary>
        /// Return only class and style values, which includes <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        EventsOnly = 0x0008,

        /// <summary>
        /// Return all attributes except class and style, also excluding <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        ExcludeClassAndStyle = HtmlExcludingClassAndStyle | EventsOnly,

        /// <summary>
        /// Return all attributes except class and style, also excluding <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        ExcludeHtmlExcludingClassAndStyle = ClassAndStyleOnly | EventsOnly,

        /// <summary>
        /// Return all attributes except class and style, also excluding <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        ExcludeEvents = ClassAndStyleOnly | HtmlExcludingClassAndStyle
    }

    public abstract class MdcComponentBase : ComponentBase
    {
        private const string ClassAttrName = "class";
        private const string StyleAttrName = "style";
        private const string DisabledAttributeName = "disabled";

        private readonly string[] ReservedAttributes = { ClassAttrName, StyleAttrName, DisabledAttributeName };
        private readonly string[] EventAttributeNames = { "onfocus", "onblur", "onfocusin", "onfocusout", "onmouseover", "onmouseout", "onmousemove", "onmousedown", "onmouseup", "onclick", "ondblclick", "onwheel", "onmousewheel", "oncontextmenu", "ondrag", "ondragend", "ondragenter", "ondragleave", "ondragover", "ondragstart", "ondrop", "onkeydown", "onkeyup", "onkeypress", "onchange", "oninput", "oninvalid", "onreset", "onselect", "onselectstart", "onselectionchange", "onsubmit", "onbeforecopy", "onbeforecut", "onbeforepaste", "oncopy", "oncut", "onpaste", "ontouchcancel", "ontouchend", "ontouchmove", "ontouchstart", "ontouchenter", "ontouchleave", "ongotpointercapture", "onlostpointercapture", "onpointercancel", "onpointerdown", "onpointerenter", "onpointerleave", "onpointermove", "onpointerout", "onpointerover", "onpointerup", "oncanplay", "oncanplaythrough", "oncuechange", "ondurationchange", "onemptied", "onpause", "onplay", "onplaying", "onratechange", "onseeked", "onseeking", "onstalled", "onstop", "onsuspend", "ontimeupdate", "onvolumechange", "onwaiting", "onloadstart", "ontimeout", "onabort", "onload", "onloadend", "onprogress", "onerror", "onactivate", "onbeforeactivate", "onbeforedeactivate", "ondeactivate", "onended", "onfullscreenchange", "onfullscreenerror", "onloadeddata", "onloadedmetadata", "onpointerlockchange", "onpointerlockerror", "onreadystatechange", "onscroll" };
        private readonly string[] AriaAttributeNames = { "aria-activedescendant", "aria-atomic", "aria-autocomplete", "aria-busy", "aria-checked", "aria-controls", "aria-describedat", "aria-describedby", "aria-disabled", "aria-dropeffect", "aria-expanded", "aria-flowto", "aria-grabbed", "aria-haspopup", "aria-hidden", "aria-invalid", "aria-label", "aria-labelledby", "aria-level", "aria-live", "aria-multiline", "aria-multiselectable", "aria-orientation", "aria-owns", "aria-posinset", "aria-pressed", "aria-readonly", "aria-relevant", "aria-required", "aria-selected", "aria-setsize", "aria-sort", "aria-valuemax", "aria-valuemin", "aria-valuenow", "aria-valuetext" };

        [CascadingParameter] protected MdcCascadingDefaults CascadingDefaults { get; set; } = new MdcCascadingDefaults();


        /// <summary>
        /// Gets or sets a collection of additional attributes that will be applied to the created element.
        /// </summary>
        [Parameter(CaptureUnmatchedValues = true)] public IReadOnlyDictionary<string, object> UnmatchedAttributes { get; set; }


        /// <summary>
        /// Specifies one or more additional class names for the component.
        /// </summary>
        [Parameter]
        public string Class { get; set; } = "";


        /// <summary>
        /// Specifies one or more additional styles for the component.
        /// </summary>
        [Parameter]
        public string Style { get; set; } = "";


        /// <summary>
        /// Gets whether the component is disabled.
        /// </summary>
        [Parameter] public bool Disabled { get; set; } = false;


        /// <summary>
        /// Attributes That the component can elect to set for inclusion in SplatAttributes.
        /// </summary>
        private protected IDictionary<string, object> ComponentPureHtmlAttributes { get; set; } = new Dictionary<string, object>(StringComparer.CurrentCultureIgnoreCase);


        /// <summary>
        /// Allows a component to build or map out a group of CSS classes to be applied to the component. Use this in <see cref="OnInitialialized()"/>, <see cref="OnParametersSet()"/> or their asynchronous counterparts.
        /// </summary>
        private protected ClassMapper ClassMapper { get; } = new ClassMapper();


        /// <summary>
        /// Allows a component to build or map out a group of HTML styles to be applied to the component. Use this in <see cref="OnInitialialized()"/>, <see cref="OnParametersSet()"/> or their asynchronous counterparts.
        /// </summary>
        private protected StyleMapper StyleMapper { get; } = new StyleMapper();


        /// <summary>
        /// Components should override this with a function to be called when BlazorMdc wants to run Material Theme initialization via JS Interop - always gets called from <see cref="OnAfterRenderAsync()"/>, which should not be overridden.
        /// </summary>
        private protected virtual async Task InitializeMdcComponent() => await Task.CompletedTask;


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
            
            if (splatType != SplatType.ClassAndStyleOnly)
            {
                if (UnmatchedAttributes != null)
                {
                    foreach (var item in UnmatchedAttributes)
                    {
                        allAttributes.Add(item.Key.ToLower(), item.Value);
                    }
                }

                if (Disabled) allAttributes.Add(DisabledAttributeName, Disabled);

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

            var classString = (ClassMapper.ToString() + " " + Class).Trim();
            var styleString = (StyleMapper.ToString() + " " + Style).Trim();

            if (!string.IsNullOrWhiteSpace(classString)) classAndStyle.Add(ClassAttrName, classString);
            if (!string.IsNullOrWhiteSpace(styleString)) classAndStyle.Add(StyleAttrName, styleString);

            foreach (var item in classAndStyle)
            {
                allAttributes.Add(item.Key, item.Value);
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
                    requiredAttributes.Add(item.Key, item.Value);
                }
            }

            if ((ushort)(splatType & SplatType.HtmlExcludingClassAndStyle) > 0)
            {
                foreach (var item in htmlAttributes)
                {
                    requiredAttributes.Add(item.Key, item.Value);
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
                    $"BlazorMdc: You cannot use {string.Join(", ", reserved.Select(x => $"'{x}'"))} attributes in {Utilities.GetTypeName(GetType())}. BlazorMdc reserves the 'class', 'style' and 'display' HTML attributes for internal use, so use the 'Class', 'Style' and 'Display' parameters instead");
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
                    $"BlazorMdc: You cannot use {string.Join(", ", forbidden.Select(x => $"'{x}'"))} attributes in {Utilities.GetTypeName(GetType())}. Either remove the attribute or change 'ConstrainSplattableAttributes' or 'AllowedSplattableAttributes' in your MdcCascadingDefaults");
            }
        }


        /// <summary>
        /// BlazorMdc components generally *should not* override this because it handles the case where components need
        /// to be adjusted when inside an <c>MdcDialog</c> or <c>MdcCard</c>. 
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
