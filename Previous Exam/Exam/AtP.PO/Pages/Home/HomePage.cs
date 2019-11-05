namespace AtP.PO.Pages.Home
{
    using System;
    using Exam.Base.Pages;
    using Exam.Core.Services.Interfaces;
    using Exam.Core.Shared.Constants;

    public partial class HomePage : BasePage
    {
        private readonly IWebPageNavigator pageNavigator;
        private readonly IMouseActionsBuilder mouseActions;

        public HomePage(IWindowMaximizer windowMaximizer,
            IWebElementsFinder elementsFinder,
            IScreenshotMaker screenshotMaker,
            IWebPageNavigator pageNavigator,
            IMouseActionsBuilder mouseActions)
            : base(windowMaximizer, elementsFinder, screenshotMaker)
        {
            this.pageNavigator = pageNavigator ?? throw new ArgumentNullException(ExceptionConstants.PAGE_NAVIGATOR);
            this.mouseActions = mouseActions ?? throw new ArgumentNullException(ExceptionConstants.MOUSE_ACTIONS);
        }

        public void NavigateToHomePage()
        {
            this.pageNavigator.NavigateToPage(UrlConstants.ATP_HOMEPAGE);
        }

        public void OpenSidebarPage()
        {
            this.mouseActions.PressElement(this.BlogHyperlink);
        }
    }
}
