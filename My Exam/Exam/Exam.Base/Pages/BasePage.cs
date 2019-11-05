namespace Exam.Base.Pages
{
    using System;
    using Exam.Core.Services.Interfaces;
    using Exam.Core.Shared.Constants;
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;

    public abstract class BasePage
    {
        private readonly IWindowMaximizer windowMaximizer;
        private readonly IWebElementsFinder elementsFinder;
        private readonly IScreenshotMaker screenshotMaker;

        public BasePage(IWindowMaximizer windowMaximizer,
            IWebElementsFinder elementsFinder,
            IScreenshotMaker screenshotMaker)
        {
            this.windowMaximizer = windowMaximizer ?? throw new ArgumentNullException(ExceptionConstants.WINDOW_MAXIMIZER);
            this.elementsFinder = elementsFinder ?? throw new ArgumentNullException(ExceptionConstants.ELEMENT_FINDER);
            this.screenshotMaker = screenshotMaker ?? throw new ArgumentNullException(ExceptionConstants.SCREENSHOT_MAKER);

            this.windowMaximizer.MaximizeBrowserWindow();
        }

        protected internal IWebElementsFinder ElementsFinder
        {
            get
            {
                return this.elementsFinder;
            }
        }

        public void TakeScreenshot()
        {
            string testName = TestContext.CurrentContext.Test.Name;

            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                this.screenshotMaker.TakeScreenshot(testName);
            }
        }
    }
}
