namespace MicrosoftDocumentations.PO.Pages.DotNet
{
    using System;
    using Exam.Base.Pages;
    using Exam.Core.Services.Interfaces;
    using Exam.Core.Shared.Constants;

    public partial class DotNetPage : BasePage
    {
        private readonly IWebPageScroller pageScroller;
        private readonly IMouseActionsBuilder mouseActions;

        public DotNetPage(IWindowMaximizer windowMaximizer,
            IWebElementsFinder elementFinder,
            IScreenshotMaker screenshotmaker,
            IWebPageScroller pageScroller,
            IMouseActionsBuilder mouseActions)
            : base(windowMaximizer, elementFinder, screenshotmaker)
        {
            this.pageScroller = pageScroller ?? throw new ArgumentNullException(ExceptionConstants.PAGE_SCROLLER);
            this.mouseActions = mouseActions ?? throw new ArgumentNullException(ExceptionConstants.MOUSE_ACTIONS);
        }

        public void OpenFourthArticlePage()
        {
            this.pageScroller.ScrollToCorrectPosition(this.DotNetStandartHyperlink);

            if (this.DotNetStandartHyperlink.Text != ".Net Standart")
            {
                throw new ArgumentException(ExceptionConstants.UNSUITABLE_HYPERLINK);
            }

            this.mouseActions.PressElement(this.DotNetStandartHyperlink);
            this.pageScroller.ScrollToCorrectPosition(this.FourthArticleHyperlink);

            if (this.FourthArticleHyperlink.Text != ".Net Standart")
            {
                throw new ArgumentException(ExceptionConstants.UNSUITABLE_ARTICLE_TITLE);
            }

            this.mouseActions.PressElement(this.FourthArticleHyperlink);
        }

        public void OpenFifthArticlePage()
        {
            this.pageScroller.ScrollToCorrectPosition(this.FifthArticleHyperlink);

            if (this.FifthArticleHyperlink.Text != "Events")
            {
                throw new ArgumentException(ExceptionConstants.UNSUITABLE_ARTICLE_TITLE);
            }

            this.mouseActions.PressElement(this.FifthArticleHyperlink);
        }

        public void OpenSixthArticlePage()
        {
            this.pageScroller.ScrollToCorrectPosition(this.SixthArticleHyperlink);

            if (this.SixthArticleHyperlink.Text != ".NET Standart Guide")
            {
                throw new ArgumentException(ExceptionConstants.UNSUITABLE_ARTICLE_TITLE);
            }

            this.mouseActions.PressElement(this.SixthArticleHyperlink);
        }
    }
}
