namespace Exam.Core.ServiceSetup.Services
{
    using System;
    using Exam.Core.Services;
    using Exam.Core.Services.Interfaces;
    using Exam.Core.ServiceSetup.Interfaces;
    using Exam.Core.ServiceSupport.Interfaces;
    using Exam.Core.ServiceSupport.Services;
    using Exam.Core.Shared.Constants;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public class ServiceSetupBuilder : IServiceSetupBuilder
    {
        private readonly IWebDriver driver;

        public ServiceSetupBuilder(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(ExceptionConstants.WEB_DRIVER);
        }

        public IWindowMaximizer WindowMaximizer
        {
            get
            {
                return new WindowMaximizer(this.driver);
            }
        }

        public IWebElementsFinder ElementsFinder
        {
            get
            {
                return new WebElementsFinder(this.driver);
            }
        }

        public IScreenshotMaker ScreenshotMaker
        {
            get
            {
                return new ScreenshotMaker(this.driver);
            }
        }

        public IWebPageNavigator PageNavigator
        {
            get
            {
                return new WebPageNavigator(this.driver, this.GetTimeManager());
            }
        }

        public IMouseActionsBuilder MouseActionsBuilder
        {
            get
            {
                return new MouseActionsBuilder(this.GetActions(), this.GetTimeManager());
            }
        }

        public IWebPageScroller PageScroller
        {
            get
            {
                return new WebPageScroller(this.GetJavaScriptExecutor(), this.GetTimeManager());
            }
        }

        private ITimeManager GetTimeManager()
        {
            return new TimeManager(this.driver);
        }

        private Actions GetActions()
        {
            return new Actions(this.driver);
        }

        private IJavaScriptExecutor GetJavaScriptExecutor()
        {
            return (IJavaScriptExecutor)this.driver;
        }
    }
}
