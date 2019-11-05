namespace ToolsQA.PO.Pages.Home
{
    using OpenQA.Selenium;

    public partial class HomePage
    {
        private IWebElement SliderButton
        {
            get
            {
                return base.ElementsFinder.FindElement(By.Id("menu-item-97"));
            }
        }

        private IWebElement AccordionButton
        {
            get
            {
                return base.ElementsFinder.FindElement(By.Id("menu-item-144"));
            }
        }
    }
}
