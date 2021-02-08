using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;

using System;
using System.Threading.Tasks;

namespace Material.Blazor
{
    /// <summary>
    /// A confirmation dialog requiring the user to type in either a generated six digit sequence or a string provided in <see cref="ConfirmationPhrase"/>.
    /// The consumer can elect to use standard "OK" and "Cancel" buttons by leaving <see cref="UnconfirmedButtons"/> and <see cref="ConfirmedButtons"/>
    /// null, in which case the "OK" button gives the dialog an action result of <see cref="ConfirmActionResult"/>, or <see cref="CancelActionResult"/>
    /// for the "Cancel" button.
    /// <para>Alternatively the consumer can supply render fragments with buttons to <see cref="UnconfirmedButtons"/> and <see cref="ConfirmedButtons"/>. The former
    /// is rendered until the correct confirmaton text is entered into the text box at which point it is replaced with the latter. Typically
    /// these are identical save that one or more of the repeated buttons in <see cref="UnconfirmedButtons"/> is disabled, but not in <see cref="ConfirmedButtons"/>.
    /// This components throws an <see cref="ArgumentException"/> if one of these render fragments is set while the other is not.</para>
    /// </summary>
    public partial class MBConfirmationDialog
    {
        public const string ConfirmActionResult = "confirm";
        public const string CancelActionResult = "cancel";


        /// <summary>
        /// The dialog title.
        /// </summary>
        [Parameter] public string Title { get; set; }


        /// <summary>
        /// Optional confirmation text. If omitted a random six digit code is generated for confirmation.
        /// </summary>
        [Parameter] public string ConfirmationPhrase { get; set; }


        /// <summary>
        /// The phrase following <see cref="ConfirmationPhrase"/> in the confirmation paragraph.
        /// "Please type <see cref="ConfirmationPhrase"/> <see cref="ActionPhrase"/>"
        /// </summary>
        [Parameter] public string ActionPhrase { get; set; } = "to confirm";


        /// <summary>
        /// Disables the confirmation text field if True.
        /// </summary>
        [Parameter] public bool ConfirmationDisabled { get; set; }


        /// <summary>
        /// The dialog body, with the confirmation paragraph rendered beneath it and the 
        /// confirmation text field beneath that.
        /// </summary>
        [Parameter] public RenderFragment Body { get; set; }


        /// <summary>
        /// A render fragment containing buttons in the unconfirmed state, typically one
        /// or more should be disabled. Both this and <see cref="ConfirmedButtons"/> should be set
        /// or both null in unison.
        /// </summary>
        [Parameter] public RenderFragment UnconfirmedButtons { get; set; }


        /// <summary>
        /// A render fragment containing buttons in the confirmed state, typically none
        /// disabled and they should otherwise <see cref="UnconfirmedButtons"/>. 
        /// Both this and <see cref="UnconfirmedButtons"/> should be set
        /// or both null in unison.
        /// </summary>
        [Parameter] public RenderFragment ConfirmedButtons { get; set; }


        /// <summary>
        /// Dialogs by default apply <c>overflow: hidden;</c>. This means that selects or datepickers are often
        /// cropped. Set this parameter to true to make the dialog apply <c>overflow: visible;</c> to rectify this.
        /// Defaults to false.
        /// </summary>
        [Parameter] public bool OverflowVisible { get; set; } = false;


        private MBDialog Dialog { get; set; }
        private string EnteredText { get; set; } = "";
        private bool Confirmed { get; set; } = false;
        private string MyConfirmationPhrase => string.IsNullOrWhiteSpace(ConfirmationPhrase) ? digitText : ConfirmationPhrase;


        private string digitText = "";


        /// <inheritdoc/>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            if ((UnconfirmedButtons == null && ConfirmedButtons != null) ||
                (UnconfirmedButtons != null && ConfirmedButtons == null))
            {
                throw new ArgumentException($"Material.Blazor: UnconfirmedButtons and ConfirmedButton in {Utilities.GetTypeName(this.GetType())} must both be either null or not null");
            }
        }


        private void OnInput(ChangeEventArgs args)
        {
            if (args.Value.ToString() == MyConfirmationPhrase)
            {
                Confirmed = true;
            }
            else
            {
                Confirmed = false;
            }
        }


        /// <summary>
        /// Shows the dialog.
        /// </summary>
        /// <returns></returns>
        public async Task<string> ShowAsync()
        {
            EnteredText = "";
            Confirmed = false;
            digitText = RandomDigits();
            StateHasChanged();
            return await Dialog.ShowAsync();
        }


        /// <summary>
        /// Hides the dialog.
        /// </summary>
        /// <returns></returns>
        public async Task HideAsync()
        {
            EnteredText = "";
            Confirmed = false;
            await Dialog.HideAsync();
        }


        /// <summary>
        /// Builds a string of six random digits. Each digit is prevented from repeating the prior digit's value.
        /// </summary>
        /// <returns></returns>
        private static string RandomDigits()
        {
            var rand = new Random();

            var digits = new int[] { rand.Next(0, 10), rand.Next(0, 9), rand.Next(0, 9), rand.Next(0, 9), rand.Next(0, 9), rand.Next(0, 9) };

            var result = digits[0].ToString();

            for (int i = 1; i < digits.Length; i++)
            {
                digits[i] += (digits[i] >= digits[i - 1]) ? 1 : 0;
                result += digits[i].ToString();
            }

            return result;
        }
    }
}
