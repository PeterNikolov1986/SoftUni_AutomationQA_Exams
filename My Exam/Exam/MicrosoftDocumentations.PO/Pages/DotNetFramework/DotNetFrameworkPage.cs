namespace MicrosoftDocumentations.PO.Pages.DotNetFramework
{
    using System;
    using Exam.Base.Pages;
    using Exam.Core.Services.Interfaces;
    using Exam.Core.Shared.Constants;

    public partial class DotNetFrameworkPage : BasePage
    {
        private readonly IWebPageScroller pageScroller;
        private readonly IMouseActionsBuilder mouseActions;

        public DotNetFrameworkPage(IWindowMaximizer windowMaximizer,
            IWebElementsFinder elementFinder,
            IScreenshotMaker screenshotmaker,
            IWebPageScroller pageScroller,
            IMouseActionsBuilder mouseActions)
            : base(windowMaximizer, elementFinder, screenshotmaker)
        {
            this.pageScroller = pageScroller ?? throw new ArgumentNullException(ExceptionConstants.PAGE_SCROLLER);
            this.mouseActions = mouseActions ?? throw new ArgumentNullException(ExceptionConstants.MOUSE_ACTIONS);
        }

        public void OpenSeventhArticlePage()
        {
            this.pageScroller.ScrollToCorrectPosition(this.DevelopmentGuideHyperlink);

            if (this.DevelopmentGuideHyperlink.Text != "Development Guide")
            {
                throw new ArgumentException(ExceptionConstants.UNSUITABLE_HYPERLINK);
            }

            this.mouseActions.PressElement(this.DevelopmentGuideHyperlink);
            this.pageScroller.ScrollToCorrectPosition(this.SeventhArticleHyperlink);

            if (this.SeventhArticleHyperlink.Text != "Accessibility")
            {
                throw new ArgumentException(ExceptionConstants.UNSUITABLE_ARTICLE_TITLE);
            }

            this.mouseActions.PressElement(this.SeventhArticleHyperlink);
        }

        public void OpenEighthArticlePage()
        {
            this.pageScroller.ScrollToCorrectPosition(this.EighthArticleHyperlink);

            if (this.EighthArticleHyperlink.Text != "What's new")
            {
                throw new ArgumentException(ExceptionConstants.UNSUITABLE_ARTICLE_TITLE);
            }

            this.mouseActions.PressElement(this.EighthArticleHyperlink);
        }
    }
}
