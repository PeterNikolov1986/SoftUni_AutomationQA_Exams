namespace Exam.Core.Services
{
    using System;
    using Exam.Core.Services.Interfaces;
    using Exam.Core.Shared.Constants;
    using OpenQA.Selenium;

    public class WindowMaximizer : IWindowMaximizer
    {
        private readonly IWebDriver driver;

        public WindowMaximizer(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(ExceptionConstants.WEB_DRIVER);
        }

        public void MaximizeBrowserWindow()
        {
            this.driver.Manage().Window.Maximize();
        }
    }
}
