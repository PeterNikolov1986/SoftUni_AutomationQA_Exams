namespace AtP.PO.Pages.DesignArchitecture
{
    using OpenQA.Selenium;

    public partial class DesignArchitecturePage
    {
        private IWebElement FirstArticleTitleHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//div[@class='bSeCont']//article[12]//h2//a"));
            }
        }

        private IWebElement SecondArticleTitleHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//div[@class='bSeCont']//article[15]//h2//a"));
            }
        }

        private IWebElement ThirdArticleTitleHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//div[@class='bSeCont']//article[13]//h2//a"));
            }
        }

        private IWebElement FourthArticleTitleHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//div[@class='bSeCont']//article[9]//h2//a"));
            }
        }

        private IWebElement FifthArticleTitleHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//div[@class='bSeCont']//article[6]//h2//a"));
            }
        }

        private IWebElement SixthArticleTitleHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//div[@class='bSeCont']//article[4]//h2//a"));
            }
        }
    }
}
