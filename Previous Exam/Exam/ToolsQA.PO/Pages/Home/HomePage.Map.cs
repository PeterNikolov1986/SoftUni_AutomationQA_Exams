namespace ToolsQA.PO.Pages.Home
{
    using OpenQA.Selenium;

    public partial class HomePage
    {
        private IWebElement TooltipButton
        {
            get
            {
                return base.ElementsFinder.FindElement(By.Id("menu-item-99"));
            }
        }

        private IWebElement DatepickerButton
        {
            get
            {
                return base.ElementsFinder.FindElement(By.Id("menu-item-146"));
            }
        }
    }
}
