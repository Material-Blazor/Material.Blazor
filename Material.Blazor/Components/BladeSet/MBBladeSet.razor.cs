using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Material.Blazor
{
    public partial class MBBladeSet
    {
        [Inject] private protected IJSRuntime JsRuntime { get; set; }
        
        
        /// <summary>
        /// The three states in a blade's lifecycle.
        /// </summary>
        private enum BladeStatus { NewClosed, Open, ClosedToRemove };


        /// <summary>
        /// Information specifying the blade's status and CSS class. 
        /// </summary>
        private class BladeInfo
        {
            private static int NextNum { get; set; } = 0;
            private readonly string openCssClassName;


            /// <summary>
            /// The blade's reference.
            /// </summary>
            public string Reference { get; init; }


            /// <summary>
            /// The blade's current animation status.
            /// </summary>
            public string AdditionalCss { get; set; } = "";


            /// <summary>
            /// The blade's current animation status.
            /// </summary>
            public BladeStatus Status { get; set; }


            /// <summary>
            /// JSInterop element ref for the mb-blade-content block.
            /// </summary>
            public ElementReference BladeContentElementReference { get; set; }


            /// <summary>
            /// Width of teh mb-blade-content blocked measured via JSInterop.
            /// </summary>
            public string MeasuredContentWidth { get; set; } = "";


            /// <summary>
            /// Width of teh mb-blade-content blocked measured via JSInterop.
            /// </summary>
            public bool HasMeasuredContentWidth => !string.IsNullOrWhiteSpace(MeasuredContentWidth);


            /// <summary>
            /// String defining the style block for the open class to be applied to the mb-blade block.
            /// </summary>
            public MarkupString OpenCssClassDefinition => new($"<style>mb-blade.{openCssClassName} {{ width: {MeasuredContentWidth}; transition: width 200ms; }} </style>");


            /// <summary>
            /// Attributes to splat on to the mb-blade element.
            /// </summary>
            public Dictionary<string, object> Attributes
            {
                get
                {
                    Dictionary<string, object> result = new();

                    string cssClass =
                        Status switch
                        {
                            BladeStatus.Open => openCssClassName,
                            _ => ""
                        }
                        + (string.IsNullOrWhiteSpace(AdditionalCss) ? "" : " " + AdditionalCss.Trim());

                   if (!string.IsNullOrWhiteSpace(cssClass))
                    {
                        result.Add("class", cssClass);
                    }

                    return result;
                }
            }


            public BladeInfo() => openCssClassName = $"open-{NextNum++}";
        }


        /// <summary>
        /// Render fragment for each blade.
        /// </summary>
        [Parameter] public RenderFragment PageContent { get; set; }


        /// <summary>
        /// Render fragment for each blade.
        /// </summary>
        [Parameter] public RenderFragment<string> BladeContent { get; set; }


        /// <summary>
        /// References to each blade presently shown.
        /// </summary>
        public ImmutableList<string> BladeReferences => Blades.Select(b => b.Value.Reference).ToImmutableList();


        private readonly SemaphoreSlim animationSemaphore = new(1, 1);
        private Dictionary<string, BladeInfo> Blades { get; set; } = new();


        /// <summary>
        /// Adds the specified blade then animating its opening sequence.
        /// </summary>
        /// <param name="bladeReference"></param>
        /// <returns></returns>
        public async Task AddBladeAsync(string bladeReference, string additionalCss = "")
        {
            await animationSemaphore.WaitAsync();

            try
            {
                Blades.Add(bladeReference, new() { Reference = bladeReference, AdditionalCss = additionalCss, Status = BladeStatus.NewClosed });

                StateHasChanged();
            }
            finally
            {
                animationSemaphore.Release();
            }
        }


        /// <summary>
        /// Animates the specified blade's closing sequence then removes it.
        /// </summary>
        /// <param name="bladeReference"></param>
        /// <returns></returns>
        public async Task RemoveBladeAsync(string bladeReference)
        {
            await animationSemaphore.WaitAsync();

            try
            {
                Blades[bladeReference].Status = BladeStatus.ClosedToRemove;

                StateHasChanged();

                await Task.Delay(200);

                Blades.Remove(bladeReference);

                StateHasChanged();
            }
            finally
            {
                animationSemaphore.Release();
            }
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            base.OnAfterRender(firstRender);

            var newBlades = Blades.Values.Where(b => b.Status == BladeStatus.NewClosed);

            if (newBlades.Any())
            {
                foreach (var bladeInfo in newBlades)
                {
                    int measurement = await JsRuntime.InvokeAsync<int>("MaterialBlazor.MBBladeSet.getBladeContentsWidth", bladeInfo.BladeContentElementReference);
                    bladeInfo.MeasuredContentWidth = measurement + "px";
                    bladeInfo.Status = BladeStatus.Open;
                }

                StateHasChanged();
            }
        }
    }
}
