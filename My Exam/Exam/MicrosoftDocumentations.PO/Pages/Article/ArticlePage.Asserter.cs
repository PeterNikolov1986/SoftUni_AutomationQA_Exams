namespace MicrosoftDocumentations.PO.Pages.Article
{
    using NUnit.Framework;
    using OpenQA.Selenium;

    public partial class ArticlePage
    {
        public void AssertThat_InThisArticleHyperlink_ScrollsPageTo_ProperArticleSection()
        {
            foreach (IWebElement navigationHyperlink in this.InThisArticleHyperlinks)
            {
                this.pageScroller.ScrollToCorrectPosition(navigationHyperlink);
                navigationHyperlink.Click();

                string hrefAttribute = navigationHyperlink.GetAttribute("href");
                string articleSectionID = hrefAttribute.Substring(hrefAttribute.IndexOf('#') + 1);
                IWebElement articleSection = this.ArticleSection(articleSectionID);

                this.pageScroller.ScrollToCorrectPosition(navigationHyperlink);

                Assert.AreEqual(navigationHyperlink.Text, articleSection.Text);
                Assert.That(articleSection.Displayed);
                Assert.That(articleSection.TagName.Contains("h2"));
            }
        }
    }
}
