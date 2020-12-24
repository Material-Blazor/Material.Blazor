﻿using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor.Internal
{
    /// <summary>
    /// For Material.Blazor internal use only.
    /// </summary>
    public partial class InternalDatePickerPanel : InputComponent<DateTime>
    {
        /// <summary>
        /// Date selection criteria
        /// </summary>
        [Parameter] public MBDateSelectionCriteria? DateSelectionCriteria { get; set; }


        /// <summary>
        /// Minimum date set by the consumer
        /// </summary>
        [Parameter] public DateTime MinDate { get; set; }


        /// <summary>
        /// Maximum date set by the consumer
        /// </summary>
        [Parameter] public DateTime MaxDate { get; set; }


        /// <summary>
        /// Reference to the <c>&lt;li&gt;</c> embedded in the panel.
        /// </summary>
        internal ElementReference ListItemReference { get; set; }


        /// <summary>
        /// Specification for date format
        /// </summary>
        [Parameter] public string DateFormat { get; set; }


        private bool ScrollToYear { get; set; } = false;

        private string[] DaysOfWeek { get; set; }

        private bool PreviousMonthDisabled => (StartOfDisplayMonth <= MinDate);

        private bool NextMonthDisabled => (StartOfDisplayMonth.AddMonths(1) >= MaxDate);

        private bool _showYearPad = false;
        internal bool ShowYearPad
        {
            get => _showYearPad;
            set
            {
                _showYearPad = value;
                ScrollToYear = value;
            }
        }

        private LinkedList<DateTime> Dates { get; set; } = new LinkedList<DateTime>();

        private LinkedList<int> Years { get; set; } = new LinkedList<int>();

        private DateTime InitialDate { get; set; }

        private DateTime CachedComponentValue { get; set; }

        private DateTime CachedMinDate { get; set; }

        private DateTime CachedMaxDate { get; set; }

        private string CachedComponentValueText => Utilities.DateToString(CachedComponentValue, DateFormat);

        private int MonthsOffset { get; set; } = 0;

        private DateTime StartOfDisplayMonth { get; set; }

        private string MonthText => StartOfDisplayMonth.ToString("MMMM yyyy");

        private int Year => StartOfDisplayMonth.Year;

        private bool IsFirstParametersSet { get; set; } = true;


        private readonly string currentYearId = Utilities.GenerateUniqueElementName();

        private readonly IMBIconFoundry foundry = MBIconHelper.MIFoundry(MBIconMITheme.Filled);


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapperInstance
                .Add("mdc-typography--body2 mb-dp-container");

            DaysOfWeek = (new DateTimeFormatInfo()).DayNames.Select(d => d.Substring(0, 1)).ToArray();

            ForceShouldRenderToTrue = true;
        }


        /// <inheritdoc/>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            if (IsFirstParametersSet)
            {
                IsFirstParametersSet = false;
                SetParameters(true);
            }
        }


        internal void SetParameters(bool forceSetup, DateTime? newValue = null)
        {
            if (forceSetup || ComponentValue != CachedComponentValue || MinDate != CachedMinDate || MaxDate != CachedMaxDate)
            {
                if (newValue != null)
                {
                    Value = (DateTime)newValue;
                }

                InitialDate = ComponentValue;
                CachedComponentValue = ComponentValue;
                CachedMinDate = MinDate;
                CachedMaxDate = MaxDate;

                var startDate = StartOfDisplayMonth = new DateTime(ComponentValue.Year, ComponentValue.Month, 1).AddMonths(MonthsOffset);
                var endDate = startDate.AddMonths(1).AddDays(-1);

                startDate = startDate.AddDays(-Convert.ToInt32(startDate.DayOfWeek));
                endDate = endDate.AddDays(-Convert.ToInt32(endDate.DayOfWeek) + 7);

                Dates = new LinkedList<DateTime>();

                for (var date = startDate; date < endDate; date = date.AddDays(1))
                {
                    Dates.AddLast(date);
                }

                var startYear = ((MinDate.Year - 1) / 4) * 4 + 1;
                var endYear = ((MaxDate.Year + 3) / 4) * 4 + 1;

                Years = new LinkedList<int>();

                for (var year = startYear; year < endYear; year++)
                {
                    Years.AddLast(year);
                }

                ShowYearPad = false;

                StateHasChanged();
            }
        }


        private async Task OnDayItemClickAsync(DateTime dateTime)
        {
            ComponentValue = dateTime;
            CachedComponentValue = Value;
            MonthsOffset = 0;
            SetParameters(true);
            await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBDatePicker.listItemClick", ListItemReference, CachedComponentValueText);
        }


        private void OnYearItemClick(int year)
        {
            MonthsOffset += (year - StartOfDisplayMonth.Year) * 12;
            ShowYearPad = false;
            SetParameters(true);
        }


        private void OnPreviousMonthClick()
        {
            MonthsOffset--;
            SetParameters(true);
        }


        private void OnShowCurrentDateClick()
        {
            MonthsOffset = 0;
            SetParameters(true);
        }


        private void OnNextMonthClick()
        {
            MonthsOffset++;
            SetParameters(true);
        }


        /// <inheritdoc/>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (!firstRender && ScrollToYear)
            {
                ScrollToYear = false;

                await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBDatePicker.scrollToYear", currentYearId);
            }
        }
    }
}
