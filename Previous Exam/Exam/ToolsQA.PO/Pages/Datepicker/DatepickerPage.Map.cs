namespace ToolsQA.PO.Pages.Datepicker
{
    using System.Collections.Generic;
    using OpenQA.Selenium;

    public partial class DatepickerPage
    {
        private IWebElement FormatDateSection
        {
            get
            {
                return base.ElementsFinder.FindElement(By.Id("ui-id-4"));
            }
        }

        private IEnumerable<IWebElement> FormatDateOptions
        {
            get
            {
                return base.ElementsFinder.FindElements(By.CssSelector("#format options"));
            }
        }

        private IWebElement DateInputField
        {
            get
            {
                return base.ElementsFinder.FindElement(By.Id("datepicker4"));
            }
        }

        public IWebElement MonthOption
        {
            get
            {
                return base.ElementsFinder.FindElement(By.CssSelector("span.ui-datepicker-month"));
            }
        }
        
        public IWebElement MonthLeftArrow
        {
            get
            {
                return base.ElementsFinder.FindElement(By.CssSelector("span.ui-icon.ui-icon-circle-triangle-w"));
            }
        }
        
        public IWebElement DateOption
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//tbody/tr[1]/td[4]"));
            }
        }
    }
}
