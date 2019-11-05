namespace Exam.Core.Services
{
    using System;
    using Exam.Core.Services.Interfaces;
    using Exam.Core.ServiceSupport.Interfaces;
    using Exam.Core.Shared.Constants;
    using Exam.Core.Shared.Types;
    using OpenQA.Selenium;

    public class WebPageNavigator : IWebPageNavigator
    {
        private readonly IWebDriver driver;
        private readonly ITimeManager timeManager;

        public WebPageNavigator(IWebDriver driver, ITimeManager timeManager)
        {
            this.driver = driver ?? throw new ArgumentNullException(ExceptionConstants.WEB_DRIVER);
            this.timeManager = timeManager ?? throw new ArgumentNullException(ExceptionConstants.TIME_MANAGER);
        }

        public void NavigateToPage(string pageUrl)
        {
            if (string.IsNullOrEmpty(pageUrl) || string.IsNullOrWhiteSpace(pageUrl))
            {
                throw new ArgumentException("The provided web page's URL can not be incorrect.");
            }

            this.driver.Navigate().GoToUrl(pageUrl);
            this.timeManager.DelayPage(DelayType.Single);
        }
    }
}
