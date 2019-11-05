namespace ToolsQA.PO.Pages.Accordion.Sections.CustomizeIcons
{
    using System;
    using Exam.Base.Pages;
    using Exam.Core.Services.Interfaces;
    using Exam.Core.Shared.Constants;

    public partial class CustomizeIconsSection : BasePage
    {
        private readonly IWebPageScroller pageScroller;
        private readonly IMouseActionsBuilder mouseActions;

        public CustomizeIconsSection(IWindowMaximizer windowMaximizer,
            IWebElementsFinder elementsFinder,
            IScreenshotMaker screenshotMaker,
            IWebPageScroller pageScroller,
            IMouseActionsBuilder mouseActions)
            : base(windowMaximizer, elementsFinder, screenshotMaker)
        {
            this.pageScroller = pageScroller ?? throw new ArgumentNullException(ExceptionConstants.PAGE_SCROLLER);
            this.mouseActions = mouseActions ?? throw new ArgumentNullException(ExceptionConstants.MOUSE_ACTIONS);
        }

        public void ClickTwiceToggleIconsButton()
        {
            this.ToggleIconsButton.Click();
            this.mouseActions.PressElement(this.ToggleIconsButton);
        }

        public void OpenSection(int position)
        {
            if (this.Sections.Count != this.TextSections.Count)
            {
                throw new ArgumentException("Both lists' sizes have to be equal.");
            }

            this.pageScroller.ScrollToCorrectPosition(this.Sections[position]);
            this.Sections[position].Click();

            this.pageScroller.ScrollToFalsePosition(this.TextSections[position]);
        }
    }
}
