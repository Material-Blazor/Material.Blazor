using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Material.Blazor
{
    public partial class MBBladeSet
    {
        /// <summary>
        /// The three states in a blade's lifecycle.
        /// </summary>
        private enum BladeStatus { NewClosed, Open, ClosedToRemove }


        /// <summary>
        /// Actions for the concurrent queue.
        /// </summary>
        private enum BladeSetAction { Add, Remove }


        /// <summary>
        /// Structs for queued blade add/remove actions.
        /// </summary>
        private struct QueueElement
        {
            /// <summary>
            /// The queued operation.
            /// </summary>
            public BladeSetAction BladeSetAction { get; set; }


            /// <summary>
            /// The blade referene to be operated on.
            /// </summary>
            public string BladeReference { get; set; }


            /// <summary>
            /// Additional CSS for the blade.
            /// </summary>
            public string AdditionalCss { get; set; }
        }


        /// <summary>
        /// Information specifying the blade's status and CSS class. 
        /// </summary>
        private class BladeInfo
        {
            /// <summary>
            /// The blade's reference.
            /// </summary>
            public string BladeReference { get; init; }


            /// <summary>
            /// Additional CSS classes to add to the mb-blade block.
            /// </summary>
            public string AdditionalCss { get; set; } = "";


            /// <summary>
            /// Additional stle attributes to add to the mb-blade block.
            /// </summary>
            public string AdditionalStyles { get; set; } = "";


            /// <summary>
            /// The blade's current animation status.
            /// </summary>
            public BladeStatus Status { get; set; }


            /// <summary>
            /// JSInterop element ref for the mb-blade block.
            /// </summary>
            public ElementReference BladeElementReference { get; set; }


            /// <summary>
            /// JSInterop element ref for the mb-blade-content block.
            /// </summary>
            public ElementReference BladeContentElementReference { get; set; }


            /// <summary>
            /// JSInterop element ref for the mb-blade-content block.
            /// </summary>
            public readonly DateTime Created = DateTime.UtcNow;


            /// <summary>
            /// Attributes to splat on to the mb-blade element.
            /// </summary>
            public Dictionary<string, object> Attributes
            {
                get
                {
                    Dictionary<string, object> result = new();

                    if (!string.IsNullOrWhiteSpace(AdditionalCss))
                    {
                        result.Add("class", AdditionalCss.Trim());
                    }

                    if (!string.IsNullOrWhiteSpace(AdditionalStyles))
                    {
                        result.Add("style", AdditionalStyles.Trim());
                    }

                    return result;
                }
            }
        }


        [Inject] private protected IJSRuntime JsRuntime { get; set; }


        /// <summary>
        /// Render fragment for each blade.
        /// </summary>
        [Parameter] public RenderFragment PageContent { get; set; }


        /// <summary>
        /// Render fragment for each blade.
        /// </summary>
        [Parameter] public RenderFragment<string> BladeContent { get; set; }


        /// <summary>
        /// Additional CSS classes to apply to the mb-blade-set block.
        /// </summary>
        [Parameter] public string MainContentAdditionalCss { get; set; }


        /// <summary>
        /// Additional style attributes to apply to the mb-blade-set block.
        /// </summary>
        [Parameter] public string MainContentAdditionalStyles { get; set; }


        /// <summary>
        /// Additional CSS classes to apply to the mb-blades block.
        /// </summary>
        [Parameter] public string BladesAdditionalCss { get; set; }


        /// <summary>
        /// Additional style attributes to apply to the mb-blades block.
        /// </summary>
        [Parameter] public string BladesAdditionalStyles { get; set; }


        /// <summary>
        /// References to each blade presently shown.
        /// </summary>
        public ImmutableList<string> BladeReferences => Blades.Select(b => b.Value.BladeReference).ToImmutableList();


        /// <summary>
        /// Invoked without arguments at the outset of a blade being added or removed from the bladeset.
        /// </summary>
        public event EventHandler BladeSetChanged;


        private readonly SemaphoreSlim queueSemaphore = new(1, 1);
        private readonly ConcurrentQueue<QueueElement> bladeSetAactionQueue = new();
        private Dictionary<string, BladeInfo> Blades { get; set; } = new();
        private Dictionary<string, object> MainContentAttributes { get; set; }
        private Dictionary<string, object> BladesAttributes { get; set; }
        private ElementReference BladeSetElem { get; set; }
        private ElementReference MainContentElementReference { get; set; }
        private ElementReference ScrollHelperElementReference { get; set; }


        /// <summary>
        /// Adds the specified blade then animating its opening sequence.
        /// </summary>
        /// <param name="bladeReference"></param>
        /// <returns></returns>
        public void AddBlade(string bladeReference, string additionalCss = "") => _ = QueueAction(new() { BladeSetAction = BladeSetAction.Add, BladeReference = bladeReference, AdditionalCss = additionalCss });


        /// <summary>
        /// Animates the specified blade's closing sequence then removes it.
        /// </summary>
        /// <param name="bladeReference"></param>
        /// <returns></returns>
        public void RemoveBlade(string bladeReference) => _ = QueueAction(new() { BladeSetAction = BladeSetAction.Remove, BladeReference = bladeReference });


        /// <summary>
        /// Places the blade action on a concurrent queue and then dequeues the next action governed by semaphore locking.
        /// Dequeuing is throttled to ensure that only one blade is being added/removed at a time.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        private async Task QueueAction(QueueElement action)
        {
            bladeSetAactionQueue.Enqueue(action);

            await queueSemaphore.WaitAsync();

            try
            {
                if (bladeSetAactionQueue.TryDequeue(out QueueElement queueElement))
                {
                    if (queueElement.BladeSetAction == BladeSetAction.Add)
                    {
                        Blades.Add(queueElement.BladeReference, new() { BladeReference = queueElement.BladeReference, AdditionalCss = queueElement.AdditionalCss, Status = BladeStatus.NewClosed });

                        StateHasChanged();
                    }
                    else
                    {
                        Blades[queueElement.BladeReference].Status = BladeStatus.ClosedToRemove;

                        StateHasChanged();
                    }

                    await Task.Delay(220);
                }
            }
            finally
            {
                queueSemaphore.Release();
            }
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            MainContentAttributes = new();
            BladesAttributes = new();

            if (!string.IsNullOrWhiteSpace(MainContentAdditionalCss))
            {
                MainContentAttributes.Add("class", MainContentAdditionalCss.Trim());
            }

            if (!string.IsNullOrWhiteSpace(MainContentAdditionalStyles))
            {
                MainContentAttributes.Add("style", MainContentAdditionalStyles.Trim());
            }

            if (!string.IsNullOrWhiteSpace(BladesAdditionalCss))
            {
                BladesAttributes.Add("class", BladesAdditionalCss.Trim());
            }

            if (!string.IsNullOrWhiteSpace(BladesAdditionalStyles))
            {
                BladesAttributes.Add("style", BladesAdditionalStyles.Trim());
            }
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            base.OnAfterRender(firstRender);

            var addedBlades = Blades.Values.Where(b => b.Status == BladeStatus.NewClosed);
            var removedBlades = Blades.Values.Where(b => b.Status == BladeStatus.ClosedToRemove);

            if (addedBlades.Any() || removedBlades.Any())
            {
                foreach (var bladeInfo in addedBlades)
                {
                    await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBBladeSet.openBlade", BladeSetElem, MainContentElementReference, ScrollHelperElementReference, bladeInfo.BladeElementReference, bladeInfo.BladeContentElementReference);
                    
                    bladeInfo.Status = BladeStatus.Open;
                    
                    BladeSetChanged.Invoke(this, null);
                }

                foreach (var bladeInfo in removedBlades)
                {
                    await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBBladeSet.closeBlade", bladeInfo.BladeElementReference);

                    await Task.Delay(200);

                    Blades.Remove(bladeInfo.BladeReference);

                    StateHasChanged();

                    BladeSetChanged.Invoke(this, null);
                }

                StateHasChanged();
            }
        }
    }
}
