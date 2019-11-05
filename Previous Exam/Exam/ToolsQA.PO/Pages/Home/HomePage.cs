namespace ToolsQA.PO.Pages.Home
{
    using System;
    using Exam.Base.Pages;
    using Exam.Core.Services.Interfaces;
    using Exam.Core.Shared.Constants;

    public partial class HomePage : BasePage
    {
        private readonly IWebPageNavigator pageNavigator;
        private readonly IWebPageScroller pageScroller;
        private readonly IMouseActionsBuilder mouseActions;

        public HomePage(IWindowMaximizer windowMaximizer,
            IWebElementsFinder elementsFinder,
            IScreenshotMaker screenshotMaker,
            IWebPageNavigator pageNavigator,
            IWebPageScroller pageScroller,
            IMouseActionsBuilder mouseActions)
            : base(windowMaximizer, elementsFinder, screenshotMaker)
        {
            this.pageNavigator = pageNavigator ?? throw new ArgumentNullException(ExceptionConstants.PAGE_NAVIGATOR);
            this.pageScroller = pageScroller ?? throw new ArgumentNullException(ExceptionConstants.PAGE_SCROLLER);
            this.mouseActions = mouseActions ?? throw new ArgumentNullException(ExceptionConstants.MOUSE_ACTIONS);
        }

        public void NavigateToHomePage()
        {
            this.pageNavigator.NavigateToPage(UrlConstants.TOOLSQA_HOMEPAGE);
        }

        public void OpenTooltipPage()
        {
            this.pageScroller.ScrollToFalsePosition(this.TooltipButton);
            this.mouseActions.PressElement(this.TooltipButton);
        }

        public void OpenDatepickerPage()
        {
            this.pageScroller.ScrollToFalsePosition(this.DatepickerButton);
            this.mouseActions.PressElement(this.DatepickerButton);
        }
    }
}
