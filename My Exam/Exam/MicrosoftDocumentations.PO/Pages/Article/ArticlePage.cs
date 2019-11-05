namespace MicrosoftDocumentations.PO.Pages.Article
{
    using System;
    using Exam.Base.Pages;
    using Exam.Core.Services.Interfaces;
    using Exam.Core.Shared.Constants;

    public partial class ArticlePage : BasePage
    {
        private readonly IWebPageScroller pageScroller;

        public ArticlePage(IWindowMaximizer windowMaximizer,
            IWebElementsFinder elementFinder,
            IScreenshotMaker screenshotmaker,
            IWebPageScroller pageScroller)
            : base(windowMaximizer, elementFinder, screenshotmaker)
        {
            this.pageScroller = pageScroller ?? throw new ArgumentNullException(ExceptionConstants.PAGE_SCROLLER);
        }
    }
}
