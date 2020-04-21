//
//  2020-04-20  Mark Stega
//              Created (loosely) from MdcRadioButtons
//

using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorMdc
{
    public class MdcRadioButton<TItem> : MdcInputComponentBase<TItem>, IMdcDialogChild
    {
        [CascadingParameter] private IMdcDialog Dialog { get; set; }


        [Parameter] public TItem CheckedValue { get; set; }
        [Parameter] public string Label { get; set; }
        [Parameter] public string ButtonContainerClass { get; set; }
        [Parameter] public bool Vertical { get; set; } = false;

        private bool instantiate = false;
        private readonly string RadioId = Utilities.GenerateCssElementSelector();
        private ElementReference ElementReference { get; set; }
        private ElementReference elementReference;
        private string radioName = Utilities.GenerateCssElementSelector();
        private bool Checked;
        private string InputControl;


        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-touch-target-wrapper");

            BuildInputControl();

            if (Dialog != null)
            {
                Dialog.RegisterLayoutAction(this);
            }
        }


        protected void BuildInputControl()
        {
            string InputControl = "<input class=\"mdc-radio__native-control";
            if (Disabled)
            {
                InputControl += "  mdc-radio--disabled";
            }
            InputControl += "\"";
            InputControl += " type=\"radio\"";
            InputControl += " id=\"" + RadioId + "\"";
            InputControl += " name=\"" + radioName + "\"";
            if (Checked)
            {
                InputControl += " checked";
            }
            if (Disabled)
            {
                InputControl += " disabled=\"true\"";
            }
            InputControl += " @onclick=\"@(_ => OnItemClickAsync(CheckedValue))\">";

            StateHasChanged();
        }


        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            Checked = Value.Equals(CheckedValue);

            BuildInputControl();
        }


        private async Task OnItemClickAsync(TItem dataValue)
        {
            Value = dataValue;
            await ValueChanged.InvokeAsync(Value);
        }


        public void RequestInstantiation()
        {
            instantiate = true;
        }


        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if ((firstRender && (Dialog is null)) || instantiate)
            {
                instantiate = false;
                await jsRuntime.InvokeAsync<object>("BlazorMdc.radioButton.init", elementReference);
            }
        }
    }
}
