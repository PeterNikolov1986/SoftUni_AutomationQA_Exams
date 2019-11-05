namespace ToolsQA.PO.Pages.Accordion.Sections.CustomizeIcons
{
    using System.Collections.Generic;
    using System.Linq;
    using OpenQA.Selenium;

    public partial class CustomizeIconsSection
    {
        private List<IWebElement> Sections
        {
            get
            {
                return this.ElementsFinder.FindElements(By.CssSelector("div#accordion_icons h3")).ToList();
            }
        }

        private List<IWebElement> TextSections
        {
            get
            {
                return this.ElementsFinder.FindElements(By.XPath("//div[@id='accordion_icons']/h3/following-sibling::div")).ToList();
            }
        }

        private IWebElement ToggleIconsButton
        {
            get
            {
                return base.ElementsFinder.FindElement(By.Id("toggle"));
            }
        }
    }
}
