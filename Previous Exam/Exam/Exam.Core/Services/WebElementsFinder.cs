namespace Exam.Core.Services
{
    using System;
    using System.Collections.Generic;
    using Exam.Core.Services.Interfaces;
    using Exam.Core.Shared.Constants;
    using OpenQA.Selenium;

    public class WebElementsFinder : IWebElementsFinder
    {
        private readonly IWebDriver driver;

        public WebElementsFinder(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(ExceptionConstants.WEB_DRIVER);
        }

        public IWebElement FindElement(By by)
        {
            return this.driver.FindElement(by);
        }

        public IEnumerable<IWebElement> FindElements(By by)
        {
            return this.driver.FindElements(by);
        }
    }
}
