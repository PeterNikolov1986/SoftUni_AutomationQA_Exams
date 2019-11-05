namespace MicrosoftDocumentations.PO.Pages.Home
{
    using OpenQA.Selenium;

    public partial class HomePage
    {
        private IWebElement DotNetCoreGuideHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//nav[@id='affixed-left-container']/ul/li[3]"));
            }
        }
        
        private IWebElement DotNetGuideHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//nav[@id='affixed-left-container']/ul/li[2]"));
            }
        }

        private IWebElement DotNetFrameworkGuideHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//nav[@id='affixed-left-container']/ul/li[4]"));
            }
        }
    }
}
