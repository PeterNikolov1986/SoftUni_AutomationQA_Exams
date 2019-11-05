namespace MicrosoftDocumentations.PO.Pages.DotNetCore
{
    using OpenQA.Selenium;

    public partial class DotNetCorePage
    {
        private IWebElement DockerHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//nav[@id='affixed-left-container']/ul/li[3]/ul/li[15]"));
            }
        }

        private IWebElement FirstArticleHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//nav[@id='affixed-left-container']/ul/li[3]/ul/li[15]/ul/li[1]"));
            }
        }

        private IWebElement SecondArticleHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//nav[@id='affixed-left-container']/ul/li[3]/ul/li[15]/ul/li[3]"));
            }
        }

        private IWebElement MigrationHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//nav[@id='affixed-left-container']/ul/li[3]/ul/li[13]"));
            }
        }

        private IWebElement ThirdArticleHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//nav[@id='affixed-left-container']/ul/li[3]/ul/li[13]/ul/li[2]"));
            }
        }
    }
}
