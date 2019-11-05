namespace ToolsQA.PO.Pages.Accordion
{
    using OpenQA.Selenium;

    public partial class AccordionPage
    {
        private IWebElement CustomizeIconsButton
        {
            get
            {
                return base.ElementsFinder.FindElement(By.Id("ui-id-2"));
            }
        }
    }
}
