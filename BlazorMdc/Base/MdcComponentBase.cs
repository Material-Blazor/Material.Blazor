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
        private MdcCascadingDefaults CascadingDefaults { get; set; }

        protected MdcCascadingDefaults AppliedDefaults => (CascadingDefaults == null) ? new MdcCascadingDefaults() : CascadingDefaults;

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

//        [CascadingParameter]
//        public MatTheme Theme { get; set; }

        protected ClassMapper ClassMapper { get; } = new ClassMapper();


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


        protected StyleMapper StyleMapper = new StyleMapper();

        private string _class;
        private string _style;
    }

}
