//
//  2020-03-31  Mark Stega
//              Created - See MatBlazor for the original implementation by @SamProf
//

using Microsoft.AspNetCore.Components;

namespace BlazorMdc
{
    /// <summary>
    /// MatDivider is a component that allows for Material styling of a line separator with various orientation options. 
    /// </summary>
    public class BasePMdcDivider : MdcComponentBase
    {
        [Parameter] public bool Inset { get; set; }

        [Parameter] public bool Padded { get; set; }


        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-list-divider")
                .AddIf("mdc-list-divider--inset", () => Inset)
                .AddIf("mdc-list-divider--padded", () => Padded);
        }
    }
}