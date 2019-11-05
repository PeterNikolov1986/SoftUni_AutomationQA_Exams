namespace AtP.PO.Pages.Article
{
    using System;
    using Exam.Base.Pages;
    using Exam.Core.Services.Interfaces;
    using Exam.Core.Shared.Constants;
    using OpenQA.Selenium.Remote;

    public partial class ArticlePage : BasePage
    {
        private readonly IWebPageScroller pageScroller;

        public ArticlePage(IWindowMaximizer windowMaximizer,
            IWebElementsFinder elementsFinder,
            IScreenshotMaker screenshotMaker,
            IWebPageScroller pageScroller)
            : base(windowMaximizer, elementsFinder, screenshotMaker)
        {
            this.pageScroller = pageScroller ?? throw new ArgumentNullException(ExceptionConstants.PAGE_SCROLLER);
        }

        private void ScrollQuickNavigationHyperlink(RemoteWebElement element)
        {
            this.pageScroller.ScrollToCorrectPosition(element);
            this.pageScroller.FindCorrectLocation(this.QuickNavigationColumns.Location.Y - this.QuickNavigationColumns.Size.Height);
        }
    }
}
