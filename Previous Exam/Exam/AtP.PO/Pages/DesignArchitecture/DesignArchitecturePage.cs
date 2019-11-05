namespace AtP.PO.Pages.DesignArchitecture
{
    using System;
    using Exam.Base.Pages;
    using Exam.Core.Services.Interfaces;
    using Exam.Core.Shared.Constants;

    public partial class DesignArchitecturePage : BasePage
    {
        private const string FIRST_ARTICLE_TITLE = "What Is a Test Automation Framework?";
        private const string SECOND_ARTICLE_TITLE = "How We Test Software: QA Process Architecture- Business Services Part One";
        private const string THIRD_ARTICLE_TITLE = "How We Test Software: QA Process Architecture- Business Services Part Three";
        private const string FOURTH_ARTICLE_TITLE = "5 Must-Have Features of Full-Stack Test Automation Frameworks Part 1";
        private const string FIFTH_ARTICLE_TITLE = "Highlight Elements on Action- Test Automation Framework Extensibility through Observer Design Pattern";
        private const string SIXTH_ARTICLE_TITLE = "How to Write Good Bug Reports And Gather Quality Metrics Data";
        private const string UNSUITABLE_ARTICLE_TITLE = "The chosen article title's hyperlink for opening is inappropriate.";

        private readonly IWebPageScroller pageScroller;
        private readonly IMouseActionsBuilder mouseActions;

        public DesignArchitecturePage(IWindowMaximizer windowMaximizer,
            IWebElementsFinder elementsFinder,
            IScreenshotMaker screenshotMaker,
            IWebPageScroller pageScroller,
            IMouseActionsBuilder mouseActions)
            : base(windowMaximizer, elementsFinder, screenshotMaker)
        {
            this.pageScroller = pageScroller ?? throw new ArgumentNullException(ExceptionConstants.PAGE_SCROLLER);
            this.mouseActions = mouseActions ?? throw new ArgumentNullException(ExceptionConstants.MOUSE_ACTIONS);
        }

        public void OpenFirstArticlePage()
        {
            this.pageScroller.ScrollToFalsePosition(this.FirstArticleTitleHyperlink);

            if (this.FirstArticleTitleHyperlink.Text != FIRST_ARTICLE_TITLE)
            {
                throw new ArgumentException(UNSUITABLE_ARTICLE_TITLE);
            }

            this.mouseActions.PressElement(this.FirstArticleTitleHyperlink);
        }

        public void OpenSecondArticlePage()
        {
            this.pageScroller.ScrollToFalsePosition(this.SecondArticleTitleHyperlink);

            if (this.SecondArticleTitleHyperlink.Text != SECOND_ARTICLE_TITLE)
            {
                throw new ArgumentException(UNSUITABLE_ARTICLE_TITLE);
            }

            this.mouseActions.PressElement(this.SecondArticleTitleHyperlink);
        }

        public void OpenThirdArticlePage()
        {
            this.pageScroller.ScrollToFalsePosition(this.ThirdArticleTitleHyperlink);

            if (this.ThirdArticleTitleHyperlink.Text != THIRD_ARTICLE_TITLE)
            {
                throw new ArgumentException(UNSUITABLE_ARTICLE_TITLE);
            }

            this.mouseActions.PressElement(this.ThirdArticleTitleHyperlink);
        }

        public void OpenFourthArticlePage()
        {
            this.pageScroller.ScrollToFalsePosition(this.FourthArticleTitleHyperlink);

            if (this.FourthArticleTitleHyperlink.Text != FOURTH_ARTICLE_TITLE)
            {
                throw new ArgumentException(UNSUITABLE_ARTICLE_TITLE);
            }

            this.mouseActions.PressElement(this.FourthArticleTitleHyperlink);
        }

        public void OpenFifthArticlePage()
        {
            this.pageScroller.ScrollToFalsePosition(this.FifthArticleTitleHyperlink);

            if (this.FifthArticleTitleHyperlink.Text != FIFTH_ARTICLE_TITLE)
            {
                throw new ArgumentException(UNSUITABLE_ARTICLE_TITLE);
            }

            this.mouseActions.PressElement(this.FifthArticleTitleHyperlink);
        }

        public void OpenSixthArticlePage()
        {
            this.pageScroller.ScrollToFalsePosition(this.SixthArticleTitleHyperlink);

            if (this.SixthArticleTitleHyperlink.Text != SIXTH_ARTICLE_TITLE)
            {
                throw new ArgumentException(UNSUITABLE_ARTICLE_TITLE);
            }

            this.mouseActions.PressElement(this.SixthArticleTitleHyperlink);
        }
    }
}
