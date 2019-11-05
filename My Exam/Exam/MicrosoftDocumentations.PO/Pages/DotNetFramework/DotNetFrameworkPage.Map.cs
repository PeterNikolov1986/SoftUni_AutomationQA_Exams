namespace MicrosoftDocumentations.PO.Pages.DotNetFramework
{
    using OpenQA.Selenium;

    public partial class DotNetFrameworkPage
    {
        private IWebElement DevelopmentGuideHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//nav[@id='affixed-left-container']/ul/li[4]/ul/li[6]"));
            }
        }

        private IWebElement SeventhArticleHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//nav[@id='affixed-left-container']/ul/li[4]/ul/li[6]/ul/li[4]"));
            }
        }

        private IWebElement EighthArticleHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//nav[@id='affixed-left-container']/ul/li[4]/ul/li[2]"));
            }
        }
    }
}
