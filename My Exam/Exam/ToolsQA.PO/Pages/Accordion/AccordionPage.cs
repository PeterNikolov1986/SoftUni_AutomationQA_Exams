namespace ToolsQA.PO.Pages.Accordion
{
    using System;
    using Exam.Base.Pages;
    using Exam.Core.Services.Interfaces;
    using Exam.Core.Shared.Constants;

    public partial class AccordionPage : BasePage
    {
        private readonly IWebPageScroller pageScroller;
        private readonly IMouseActionsBuilder mouseActions;

        public AccordionPage(IWindowMaximizer windowMaximizer,
            IWebElementsFinder elementsFinder,
            IScreenshotMaker screenshotMaker,
            IWebPageScroller pageScroller,
            IMouseActionsBuilder mouseActions)
            : base(windowMaximizer, elementsFinder, screenshotMaker)
        {
            this.pageScroller = pageScroller ?? throw new ArgumentNullException(ExceptionConstants.PAGE_SCROLLER);
            this.mouseActions = mouseActions ?? throw new ArgumentNullException(ExceptionConstants.MOUSE_ACTIONS);
        }

        public void OpenCustomizeIconsSection()
        {
            this.pageScroller.ScrollToCorrectPosition(this.CustomizeIconsButton);
            this.mouseActions.PressElement(this.CustomizeIconsButton);
        }
    }
}
