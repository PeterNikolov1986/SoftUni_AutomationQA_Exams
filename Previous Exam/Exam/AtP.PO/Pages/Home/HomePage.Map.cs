namespace AtP.PO.Pages.Home
{
    using OpenQA.Selenium;

    public partial class HomePage
    {
        private IWebElement BlogHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.Id("menu-item-6"));
            }
        }
    }
}
