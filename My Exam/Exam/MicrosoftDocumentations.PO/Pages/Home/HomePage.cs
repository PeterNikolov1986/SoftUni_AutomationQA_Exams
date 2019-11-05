namespace MicrosoftDocumentations.PO.Pages.Home
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
            this.pageNavigator.NavigateToPage(UrlConstants.MS_DOCS_HOMEPAGE);
        }

        public void OpenDotNetCorePage()
        {
            this.pageScroller.ScrollToCorrectPosition(this.DotNetCoreGuideHyperlink);

            if (this.DotNetCoreGuideHyperlink.Text != ".NET Core Guide")
            {
                throw new ArgumentException(ExceptionConstants.UNSUITABLE_HYPERLINK);
            }

            this.mouseActions.PressElement(this.DotNetCoreGuideHyperlink);
        }

        public void OpenDotNetPage()
        {
            this.pageScroller.ScrollToCorrectPosition(this.DotNetGuideHyperlink);

            if (this.DotNetGuideHyperlink.Text != ".NET Guide")
            {
                throw new ArgumentException(ExceptionConstants.UNSUITABLE_HYPERLINK);
            }

            this.mouseActions.PressElement(this.DotNetGuideHyperlink);
        }

        public void OpenDotNetFrameworkPage()
        {
            this.pageScroller.ScrollToCorrectPosition(this.DotNetFrameworkGuideHyperlink);

            if (this.DotNetFrameworkGuideHyperlink.Text != ".NET Framework Guide")
            {
                throw new ArgumentException(ExceptionConstants.UNSUITABLE_HYPERLINK);
            }

            this.mouseActions.PressElement(this.DotNetFrameworkGuideHyperlink);
        }
    }
}
