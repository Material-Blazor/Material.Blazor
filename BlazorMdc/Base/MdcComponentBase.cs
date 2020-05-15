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
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// Determines what attributes to splat from <see cref="SplatAttributes"/>.
    /// </summary>
    internal enum SplatType
    { 
        /// <summary>
        /// Return all attributes including class and style, also including values from <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        All,

        /// <summary>
        /// Return only class and style values, which includes <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        ClassAndStyleOnly,

        /// <summary>
        /// Return all attributes except class and style, also excluding <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        ExcludeClassAndStyle
    }

    public abstract class MdcComponentBase : ComponentBase
    {
        private const string Class = "class";
        private const string Style = "style";

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
        /// Attributes ready for splatting in components. Guaranteed not null, unlike UnmatchedAttributes. Default parameter is <see cref="SplatType.All".
        /// </summary>
        internal IReadOnlyDictionary<string, object> AttributesToSplat(SplatType splatType = SplatType.All)
        {
            var result = new Dictionary<string, object>(ComponentSetAttributes);

            if (UnmatchedAttributes != null)
            {
                foreach (var item in UnmatchedAttributes)
                {
                    result.Add(item.Key.ToLower(), item.Value);
                }
            }

            if (result.ContainsKey(Class))
            {
                result[Class] += " " + ClassMapper.ToString();
            }
            else
            {
                result.Add(Class, ClassMapper.ToString());
            }

            if (result.ContainsKey(Style))
            {
                result[Style] += " " + StyleMapper.ToString();
            }
            else
            {
                result.Add(Style, StyleMapper.ToString());
            }

            return splatType switch
            {
                SplatType.All => result,
                SplatType.ClassAndStyleOnly => result.Where(r => r.Key == Class || r.Key == Style).ToDictionary(k => k.Key, k => k.Value),
                SplatType.ExcludeClassAndStyle => result.Where(r => r.Key != Class && r.Key != Style).ToDictionary(k => k.Key, k => k.Value),
                _ => throw new NotImplementedException(),
            };
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
