using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
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
    /// <summary>
    /// A blade display component. Adds blades to the right hand side of the viewport (or bock where this component is located), with
    /// blades displayed left to right in ascending order of when they were requested (newest blades to the right).
    /// </summary>
    public partial class MBBladeSet
    {
        private const int transitionMs = 200;

        [Inject] private protected ILogger<MBBladeSet> Logger { get; set; }



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
        private class QueueElement
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
            /// The blade component. Used only for add actions.
            /// </summary>
            public IComponent BaseComponent { get; set; }


            /// <summary>
            /// Parameters for the blade component. Used only for add actions.
            /// </summary>
            public object BaseParameters { get; set; }


            /// <summary>
            /// True if parameters are supplied.
            /// </summary>
            public bool HasParameters { get; set; }


            /// <summary>
            /// Additional CSS for the blade. Used only for add actions.
            /// </summary>
            public string AdditionalCss { get; set; }


            /// <summary>
            /// Additional style attributes the blade. Used only for add actions.
            /// </summary>
            public string AdditionalStyles { get; set; }
        }


        /// <summary>
        /// Structs for queued blade add/remove actions.
        /// </summary>
        private class QueueElement<TParameters> : QueueElement where TParameters : MBBladeComponentParameters
        {
            /// <summary>
            /// The blade component. Used only for add actions.
            /// </summary>
            public IMBBladeComponent<TParameters> Component { get => (IMBBladeComponent<TParameters>)BaseComponent; set => BaseComponent = value; }


            /// <summary>
            /// Parameters for the blade component. Used only for add actions.
            /// </summary>
            public TParameters Parameters { get => (TParameters)BaseParameters; set => BaseParameters = value; }
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
        /// Render fragment for the page content.
        /// </summary>
        [Parameter] public RenderFragment PageContent { get; set; }


        /// <summary>
        /// Render fragment for each blade.
        /// </summary>
        [Parameter] public RenderFragment<string> BladeContent { get; set; }


        /// <summary>
        /// Additional CSS classes to apply to the mb-bladeset-main-content block that contains page content.
        /// </summary>
        [Parameter] public string MainContentAdditionalCss { get; set; }


        /// <summary>
        /// Additional style attributes to apply to the mb-bladeset-main-content block that contains page content.
        /// </summary>
        [Parameter] public string MainContentAdditionalStyles { get; set; }


        /// <summary>
        /// Additional CSS classes to apply to the mb-blades block that contains all blades. Note that this block is not rendered if
        /// no blades are currently being displayed, so it's safe to use (for instance) a class such as <code>mdc-elevation--z3</code>
        /// that bleeds outside its block.
        /// </summary>
        [Parameter] public string BladesAdditionalCss { get; set; }


        /// <summary>
        /// Additional style attributes to apply to the mb-blades block that contains all blades. Note that this block is not rendered if
        /// no blades are currently being displayed, so it's safe to apply styles that bleed outside its block.
        /// </summary>
        [Parameter] public string BladesAdditionalStyles { get; set; }


        /// <summary>
        /// References to each blade presently shown. These references are passed back to render fragments via Context to tell the consumer
        /// what contents to render.
        /// </summary>
        public ImmutableList<string> BladeReferences => Blades.Select(b => b.Value.BladeReference).ToImmutableList();


        /// <summary>
        /// Invoked without arguments at the outset of a blade being added or removed from the bladeset.
        /// </summary>
        public event EventHandler BladeSetChanged;


        private readonly SemaphoreSlim queueSemaphore = new(1, 1);
        private readonly ConcurrentQueue<QueueElement> bladeSetActionQueue = new();
        private readonly ConcurrentQueue<BladeInfo> addedBladesQueue = new();
        private readonly ConcurrentQueue<BladeInfo> removedBladesQueue = new();

        private string CachedBladesAdditionalCss { get; set; }
        private string CachedBladesAdditionalStyles { get; set; }
        private bool BladesAttributesSet { get; set; } = false;

        private string CachedMainContentAdditionalCss { get; set; }
        private string CachedMainContentAdditionalStyles { get; set; }
        private bool MainContentAttributesSet { get; set; } = false;

        private Dictionary<string, BladeInfo> Blades { get; set; } = new();
        private Dictionary<string, object> MainContentAttributes { get; set; }
        private Dictionary<string, object> BladesAttributes { get; set; }


        /// <summary>
        /// Adds the specified blade then animating its opening sequence.
        /// </summary>
        /// <param name="bladeReference">A string reference that the MBBladeSet component passes back via Context so the consumer can display the correct blade contents.</param>
        /// <param name="additionalCss">CSS styles to be applied to the &lt;mb-blade&gt; block.</param>
        /// <param name="additionalStyles">Style attributes to be applied to the &lt;mb-blade&gt; block.</param>
        public async Task AddBladeAsync<TParam>(string bladeReference, IMBBladeComponent<TParam> component, TParam parameters, string additionalCss = "", string additionalStyles = "") where TParam : MBBladeComponentParameters
        {
            QueueElement<TParam> queueElement = new() { BladeSetAction = BladeSetAction.Add, Component = component, Parameters = parameters, BladeReference = bladeReference, AdditionalCss = additionalCss, AdditionalStyles = additionalStyles };
            await QueueAction(queueElement).ConfigureAwait(false);
        }


        /// <summary>
        /// Animates the specified blade's closing sequence then removes it.
        /// </summary>
        /// <param name="bladeReference">The reference of the blade to be removed.</param>
        /// <returns></returns>
        public async Task RemoveBladeAsync(string bladeReference)
        {
            QueueElement queueElement = new() { BladeSetAction = BladeSetAction.Remove, BladeReference = bladeReference };
            await QueueAction(queueElement).ConfigureAwait(false);
        }


        /// <summary>
        /// Places the blade action on a concurrent queue and then dequeues the next action governed by semaphore locking.
        /// Dequeuing is throttled to ensure that only one blade is being added/removed at a time.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        private async Task QueueAction(QueueElement action)
        {
            bladeSetActionQueue.Enqueue(action);

            await queueSemaphore.WaitAsync();

            try
            {
                if (bladeSetActionQueue.TryDequeue(out var queueElement))
                {
                    if (queueElement.BladeSetAction == BladeSetAction.Add)
                    {
                        BladeInfo addedBlade = new() { BladeReference = queueElement.BladeReference, AdditionalCss = queueElement.AdditionalCss, AdditionalStyles = queueElement.AdditionalStyles, Status = BladeStatus.NewClosed };
                        Blades.Add(queueElement.BladeReference, addedBlade);
                        addedBladesQueue.Enqueue(addedBlade);

                        StateHasChanged();
                    }
                    else
                    {
                        Blades[queueElement.BladeReference].Status = BladeStatus.ClosedToRemove;
                        removedBladesQueue.Enqueue(Blades[queueElement.BladeReference]);

                        StateHasChanged();
                    }

                    await Task.Delay(transitionMs + 20);
                }
            }
            finally
            {
                queueSemaphore.Release();
            }
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();

            if (!MainContentAttributesSet || CachedMainContentAdditionalCss != MainContentAdditionalCss || CachedMainContentAdditionalStyles != MainContentAdditionalStyles)
            {
                //Logger.LogInformation("MBBladeSet updating MainContentAttributeSet");

                MainContentAttributesSet = true;
                CachedMainContentAdditionalCss = MainContentAdditionalCss;
                CachedMainContentAdditionalStyles = MainContentAdditionalStyles;

                MainContentAttributes = new();

                if (!string.IsNullOrWhiteSpace(MainContentAdditionalCss))
                {
                    MainContentAttributes.Add("class", MainContentAdditionalCss.Trim());
                }

                if (!string.IsNullOrWhiteSpace(MainContentAdditionalStyles))
                {
                    MainContentAttributes.Add("style", MainContentAdditionalStyles.Trim());
                }
            }

            if (!BladesAttributesSet || CachedBladesAdditionalCss != BladesAdditionalCss || CachedBladesAdditionalStyles != BladesAdditionalStyles)
            {
                //Logger.LogInformation("MBBladeSet updating BladeAttributeSet");

                BladesAttributesSet = true;
                CachedBladesAdditionalCss = BladesAdditionalCss;
                CachedBladesAdditionalStyles = BladesAdditionalStyles;

                BladesAttributes = new();

                if (!string.IsNullOrWhiteSpace(BladesAdditionalCss))
                {
                    BladesAttributes.Add("class", BladesAdditionalCss.Trim());
                }

                if (!string.IsNullOrWhiteSpace(BladesAdditionalStyles))
                {
                    BladesAttributes.Add("style", BladesAdditionalStyles.Trim());
                }
            }
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            base.OnAfterRender(firstRender);

            if (addedBladesQueue.TryDequeue(out var addedBlade))
            {
                await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBBladeSet.openBlade", addedBlade.BladeElementReference, addedBlade.BladeContentElementReference, transitionMs);

                addedBlade.Status = BladeStatus.Open;

                StateHasChanged();

                BladeSetChanged?.Invoke(this, null);
            }
            else if (removedBladesQueue.TryDequeue(out var removedBlade))
            {
                await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBBladeSet.closeBlade", removedBlade.BladeElementReference, transitionMs);

                await Task.Delay(transitionMs);

                Blades.Remove(removedBlade.BladeReference);

                StateHasChanged();

                BladeSetChanged?.Invoke(this, null);
            }
        }
    }
}
