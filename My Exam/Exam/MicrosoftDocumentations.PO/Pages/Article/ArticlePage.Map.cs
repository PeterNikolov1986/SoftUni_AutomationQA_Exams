namespace MicrosoftDocumentations.PO.Pages.Article
{
    using System.Collections.Generic;
    using System.Linq;
    using OpenQA.Selenium;

    public partial class ArticlePage
    {
        private List<IWebElement> InThisArticleHyperlinks
        {
            get
            {
                return base.ElementsFinder.FindElements(By.CssSelector("nav#side-doc-outline ol li a")).ToList();
            }
        }

        private IWebElement ArticleSection(string articleSectionID)
        {
            return base.ElementsFinder.FindElement(By.Id(articleSectionID));
        }
    }
}
