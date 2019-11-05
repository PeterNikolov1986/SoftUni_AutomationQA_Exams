namespace ToolsQA.PO.Pages.Tooltip
{
    using OpenQA.Selenium;

    public partial class TooltipPage
    {
        private IWebElement AgeTextField
        {
            get
            {
                return base.ElementsFinder.FindElement(By.Id("age"));
            }
        }

        private IWebElement Tooltip(string tooltipXPathMessage)
        {
            return base.ElementsFinder.FindElement(By.XPath(tooltipXPathMessage));
        }
    }
}
