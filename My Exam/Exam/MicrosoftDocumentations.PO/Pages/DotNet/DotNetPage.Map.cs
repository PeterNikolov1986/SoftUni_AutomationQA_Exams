namespace MicrosoftDocumentations.PO.Pages.DotNet
{
    using OpenQA.Selenium;

    public partial class DotNetPage
    {
        private IWebElement DotNetStandartHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//nav[@id='affixed-left-container']/ul/li[2]/ul/li[5]"));
            }
        }

        private IWebElement FourthArticleHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//nav[@id='affixed-left-container']/ul/li[2]/ul/li[5]/ul/li[1]"));
            }
        }

        private IWebElement FifthArticleHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//nav[@id='affixed-left-container']/ul/li[2]/ul/li[29]"));
            }
        }

        private IWebElement SixthArticleHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//nav[@id='affixed-left-container']/ul/li[2]/ul/li[1]"));
            }
        }
    }
}
