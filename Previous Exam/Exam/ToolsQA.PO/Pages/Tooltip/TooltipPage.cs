namespace ToolsQA.PO.Pages.Tooltip
{
    using System;
    using Exam.Base.Pages;
    using Exam.Core.Services.Interfaces;
    using Exam.Core.Shared.Constants;

    public partial class TooltipPage : BasePage
    {
        private readonly IMouseActionsBuilder mouseActions;

        public TooltipPage(IWindowMaximizer windowMaximizer,
            IWebElementsFinder elementsFinder,
            IScreenshotMaker screenshotMaker,
            IMouseActionsBuilder mouseActions)
            : base(windowMaximizer, elementsFinder, screenshotMaker)
        {
            this.mouseActions = mouseActions ?? throw new ArgumentNullException(ExceptionConstants.MOUSE_ACTIONS);
        }

        public string FindTooltipXPathMessage()
        {
            this.mouseActions.HoverElement(this.AgeTextField);

            string tooltipId = this.AgeTextField.GetAttribute("aria-describedby");
            return $"//div[@id=\"{tooltipId}\"]/div";
        }
    }
}
