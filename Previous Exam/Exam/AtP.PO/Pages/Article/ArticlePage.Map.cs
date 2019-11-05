namespace AtP.PO.Pages.Article
{
    using OpenQA.Selenium;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ArticlePage
    {
        private IWebElement QuickNavigationColumns
        {
            get
            {
                return base.ElementsFinder.FindElement(By.CssSelector("div.ct_column"));
            }
        }

        private List<IWebElement> QuickNavigationHyperlinks
        {
            get
            {
                return base.ElementsFinder.FindElements(By.CssSelector("div.tve_contents_table.tve_clearfix div a")).ToList();
            }
        }

        private IWebElement ArticleSection(string sectionID)
        {
            return base.ElementsFinder.FindElement(By.Id(sectionID));
        }
    }
}
