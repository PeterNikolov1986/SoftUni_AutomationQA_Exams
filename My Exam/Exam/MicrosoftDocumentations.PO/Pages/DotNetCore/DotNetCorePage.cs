namespace MicrosoftDocumentations.PO.Pages.DotNetCore
{
    using System;
    using Exam.Base.Pages;
    using Exam.Core.Services.Interfaces;
    using Exam.Core.Shared.Constants;

    public partial class DotNetCorePage : BasePage
    {
        private readonly IWebPageScroller pageScroller;
        private readonly IMouseActionsBuilder mouseActions;

        public DotNetCorePage(IWindowMaximizer windowMaximizer,
            IWebElementsFinder elementFinder,
            IScreenshotMaker screenshotmaker,
            IWebPageScroller pageScroller,
            IMouseActionsBuilder mouseActions)
            : base(windowMaximizer, elementFinder, screenshotmaker)
        {
            this.pageScroller = pageScroller ?? throw new ArgumentNullException(ExceptionConstants.PAGE_SCROLLER);
            this.mouseActions = mouseActions ?? throw new ArgumentNullException(ExceptionConstants.MOUSE_ACTIONS);
        }

        public void OpenFirstArticlePage()
        {
            this.OpenDockerArticlePage();
            this.pageScroller.ScrollToCorrectPosition(this.FirstArticleHyperlink);

            if (this.FirstArticleHyperlink.Text != "Introduction to .NET and Docker")
            {
                throw new ArgumentException(ExceptionConstants.UNSUITABLE_ARTICLE_TITLE);
            }

            this.mouseActions.PressElement(this.FirstArticleHyperlink);
        }

        public void OpenSecondArticlePage()
        {
            this.OpenDockerArticlePage();
            this.pageScroller.ScrollToCorrectPosition(this.SecondArticleHyperlink);

            if (this.SecondArticleHyperlink.Text != "Container Tools in Visual Studio")
            {
                throw new ArgumentException(ExceptionConstants.UNSUITABLE_ARTICLE_TITLE);
            }

            this.mouseActions.PressElement(this.SecondArticleHyperlink);
        }

        public void OpenThirdArticlePage()
        {
            this.pageScroller.ScrollToCorrectPosition(this.MigrationHyperlink);

            if (this.MigrationHyperlink.Text != "Migration")
            {
                throw new ArgumentException(ExceptionConstants.UNSUITABLE_HYPERLINK);
            }

            this.mouseActions.PressElement(this.MigrationHyperlink);
            this.pageScroller.ScrollToCorrectPosition(this.ThirdArticleHyperlink);

            if (this.ThirdArticleHyperlink.Text != "Migrating from project.json")
            {
                throw new ArgumentException(ExceptionConstants.UNSUITABLE_ARTICLE_TITLE);
            }

            this.mouseActions.PressElement(this.ThirdArticleHyperlink);
        }

        private void OpenDockerArticlePage()
        {
            this.pageScroller.ScrollToCorrectPosition(this.DockerHyperlink);

            if (this.DockerHyperlink.Text != "Docker")
            {
                throw new ArgumentException(ExceptionConstants.UNSUITABLE_HYPERLINK);
            }

            this.mouseActions.PressElement(this.DockerHyperlink);
        }
    }
}
