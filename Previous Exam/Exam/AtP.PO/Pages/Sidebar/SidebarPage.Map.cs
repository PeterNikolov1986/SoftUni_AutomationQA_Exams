namespace AtP.PO.Pages.Sidebar
{
    using OpenQA.Selenium;

    public partial class SidebarPage
    {
        private IWebElement HyperlinksContainer
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//section[@id='xyz_insert_html_widget-7']/div/ul"));
            }
        }

        private IWebElement DesignArchitectureHyperlink
        {
            get
            {
                return base.ElementsFinder.FindElement(By.XPath("//section[@id='xyz_insert_html_widget-7']/div/ul/li[2]"));
            }
        }
    }
}
