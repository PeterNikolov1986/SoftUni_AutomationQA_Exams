namespace AtP.PO.Pages.Article
{
    using System;
    using System.Linq;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Remote;

    public partial class ArticlePage
    {
        private string[] hTags = new string[] { "h2", "h3" };

        public void AssertThat_QuickNavigationHyperlinks_ScrollPageTo_ProperSections()
        {
            foreach (IWebElement navigationHyperlink in this.QuickNavigationHyperlinks)
            {
                RemoteWebElement hyperlink = (RemoteWebElement)navigationHyperlink;

                this.ScrollQuickNavigationHyperlink(hyperlink);

                string navigationHyperlinkHref = hyperlink.GetAttribute("href");
                string sectionID = navigationHyperlinkHref.Substring(navigationHyperlinkHref.IndexOf('#') + 1);
                IWebElement articleSection = this.ArticleSection(sectionID);
                RemoteWebElement section = (RemoteWebElement)articleSection;

                hyperlink.Click();
                this.ScrollQuickNavigationHyperlink(hyperlink);

                Assert.That(section.Displayed);
                Assert.AreEqual(hyperlink.Text, section.Text);
                Assert.That(hTags.Contains(section.TagName));
            }
        }
    }
}
