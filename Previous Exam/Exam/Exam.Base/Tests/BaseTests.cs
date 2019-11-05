namespace Exam.Base.Tests
{
    using System.Configuration;
    using System.IO;
    using System.Reflection;
    using Exam.Core.ServiceSetup.Interfaces;
    using Exam.Core.ServiceSetup.Services;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;

    public abstract class BaseTests
    {
        private IWebDriver driver;
        private IServiceSetupBuilder serviceSetup;

        protected IServiceSetupBuilder ServiceSetupBuilder
        {
            get
            {
                return new ServiceSetupBuilder(this.driver);
            }
        }

        public virtual void SetUp()
        {
            this.SetUpWebDriver();
            this.serviceSetup = this.ServiceSetupBuilder;
        }

        public virtual void TearDown()
        {
            this.driver.Quit();
        }

        private void SetUpWebDriver()
        {
            string browserType = ConfigurationManager.AppSettings["WebBrowserType"];
            string chromePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            switch (browserType)
            {
                case "Chrome": this.driver = new ChromeDriver(chromePath); break;
                case "Firefox": this.driver = new FirefoxDriver(); break;

                default: this.driver = new ChromeDriver(chromePath); break;
            }
        }
    }
}