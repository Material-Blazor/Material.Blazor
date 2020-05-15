//
//  2020-03-31  Mark Stega
//              Added ClassMapper/Class & StyleMapper/Style
//
//  2020-04-13  Mark Stega
//              Reworked 
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Security;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// Determines what attributes to splat from <see cref="SplatAttributes"/>.
    /// </summary>
    internal enum SplatType
    { 
        /// <summary>
        /// Return all attributes including values from <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        AllIncludingMappers,

        /// <summary>
        /// Return only values from <see cref="ClassMapper"/> and <see cref="StyleMapper"/> - merges mappers with other class and style attributes.
        /// </summary>
        MappersOnly,

        /// <summary>
        /// Return all attributes except values from <see cref="ClassMapper"/> and <see cref="StyleMapper"/> - may include class and style.
        /// </summary>
        ExcludeMappers
    }

    public abstract class MdcComponentBase : ComponentBase
    {
        [CascadingParameter] protected MdcCascadingDefaults CascadingDefaults { get; set; } = new MdcCascadingDefaults();

        /// <summary>
        /// Gets or sets a collection of additional attributes that will be applied to the created element.
        /// </summary>
        [Parameter(CaptureUnmatchedValues = true)] public IReadOnlyDictionary<string, object> UnmatchedAttributes { get; set; }


        /// <summary>
        /// Attributes That the component can elect to set for inclusion in SplatAttributes.
        /// </summary>
        internal IDictionary<string, object> ComponentSetAttributes { get; set; } = new Dictionary<string, object>(StringComparer.CurrentCultureIgnoreCase);


        /// <summary>
        /// Attributes ready for splatting in components. Guaranteed not null, unlike UnmatchedAttributes. Default parameter is <see cref="SplatType.AllIncludingMappers".
        /// </summary>
        internal IReadOnlyDictionary<string, object> SplatAttributes(SplatType splatType = SplatType.AllIncludingMappers)
        {
            var result = new Dictionary<string, object>(ComponentSetAttributes);

            if (UnmatchedAttributes != null && splatType != SplatType.MappersOnly)
            {
                foreach (var item in UnmatchedAttributes)
                {
                    result.Add(item.Key.ToLower(), item.Value);
                }
            }

            if (splatType != SplatType.ExcludeMappers)
            {
                if (result.ContainsKey("class"))
                {
                    result["class"] += " " + ClassMapper.ToString();
                }
                else
                {
                    result.Add("class", ClassMapper.ToString());
                }

                if (result.ContainsKey("style"))
                {
                    result["style"] += " " + StyleMapper.ToString();
                }
                else
                {
                    result.Add("style", StyleMapper.ToString());
                }
            }

            return result;
        }


        /// <summary>
        /// Determines whether the "disabled" attribute has been set.
        /// </summary>
        internal bool IsDisabled => UnmatchedAttributes != null && UnmatchedAttributes.ContainsKey("disabled") && Convert.ToBoolean(UnmatchedAttributes["disabled"]);


        protected ClassMapper ClassMapper { get; } = new ClassMapper();

        protected StyleMapper StyleMapper { get; } = new StyleMapper();




        protected virtual async Task InitializeMdcComponent() => await Task.CompletedTask;


        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await InitializeMdcComponent();
            }
        }

        
        //protected MdcComponentBase()
        //{
        //    ClassMapper.Get(() => Class);

        //    StyleMapper.Get(() => Style);
        //}

        ///// <summary>
        ///// Specifies one or more classnames for an DOM element.
        ///// </summary>
        //[Parameter]
        //public string Class { get; set; }


        ///// <summary>
        ///// Specifies an inline style for an DOM element.
        ///// </summary>
        //[Parameter]
        //public string Style { get; set; }
    }
}
