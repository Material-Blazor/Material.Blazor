//
//  2020-03-31  Mark Stega
//              Added ClassMapper/Class & StyleMapper/Style
//

using Microsoft.AspNetCore.Components;

using System.Threading.Tasks;

namespace BlazorMdc
{
    public abstract class MdcComponentBase : ComponentBase
    {
        [CascadingParameter]
        protected MdcCascadingDefaults CascadingDefaults { get; set; } = new MdcCascadingDefaults();

        protected ClassMapper ClassMapper { get; } = new ClassMapper();

        protected StyleMapper StyleMapper { get; } = new StyleMapper();

        internal AttributeMapper AttributeMapper { get; } = new AttributeMapper();

        /// <summary>
        /// Gets whether the component is disabled.
        /// </summary>
        [Parameter] public bool Disabled { get; set; } = false;

        
        protected override Task OnAfterRenderAsync(bool isFirstRender)
        {
            if (isFirstRender)
            {
                return OnAfterFirstRenderAsync();
            }
            else
            {
                return Task.CompletedTask;
            }
        }

        protected virtual Task OnAfterFirstRenderAsync()
            => Task.CompletedTask;

        
        protected MdcComponentBase()
        {
            ClassMapper
                .Get(() => this.Class)
                ;//.Get(() => this.Theme?.GetClass());

            StyleMapper.Get(() => Style);
        }

        /// <summary>
        /// Specifies one or more classnames for an DOM element.
        /// </summary>
        [Parameter] public string Class
        {
            get => _class;
            set { _class = value; }
        }


        /// <summary>
        /// Specifies an inline style for an DOM element.
        /// </summary>
        [Parameter] public string Style
        {
            get => _style;
            set { _style = value; }
        }


        private string _class;
        private string _style;
    }
}
