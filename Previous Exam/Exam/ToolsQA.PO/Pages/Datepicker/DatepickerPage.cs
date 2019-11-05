namespace ToolsQA.PO.Pages.Datepicker
{
    using System;
    using System.Linq;
    using Exam.Base.Pages;
    using Exam.Core.Services.Interfaces;
    using Exam.Core.Shared.Constants;

    public partial class DatepickerPage : BasePage
    {
        private readonly IMouseActionsBuilder mouseActions;

        public DatepickerPage(IWindowMaximizer windowMaximizer,
            IWebElementsFinder elementsFinder,
            IScreenshotMaker screenshotMaker,
            IMouseActionsBuilder mouseActions)
            : base(windowMaximizer, elementsFinder, screenshotMaker)
        {
            this.mouseActions = mouseActions ?? throw new ArgumentNullException(ExceptionConstants.MOUSE_ACTIONS);
        }

        private string DateFormat
        {
            get
            {
                return this.DateInputField.GetAttribute("value");
            }
        }

        private string[] DateOptions
        {
            get
            {
                return new string[] {
                    "March 1, 2018",
                    "2018-03-01",
                    "1 Mar, 18",
                    "1 March, 18",
                    "Thursday, 1 March, 2018",
                    "day 1 of March in the year 2018" };
            }
        }

        public void SelectFormatDateOption(int position)
        {
            this.mouseActions.PressElement(this.FormatDateSection);
            this.mouseActions.PressElement(this.FormatDateOptions.ElementAt(position));
        }

        public void SelectProperDate()
        {
            this.mouseActions.PressElement(this.DateInputField);

            while (this.MonthOption.Text != "March")
            {
                this.mouseActions.PressElement(this.MonthLeftArrow);
            }

            this.mouseActions.PressElement(this.DateOption);
        }
    }
}
