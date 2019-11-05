namespace MicrosoftDocumentations.Tests.Home
{
    using Exam.Base.Tests;
    using MicrosoftDocumentations.PO.PageSetup;
    using NUnit.Framework;

    [TestFixture]
    public class HomeTests : BaseTests
    {
        private HomePageProvider provider;

        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            this.provider = new HomePageProvider(base.ServiceSetupBuilder);
        }

        [TearDown]
        public override void TearDown()
        {
            this.provider.HomePage.TakeScreenshot();
            this.provider.ArticlePage.TakeScreenshot();
            base.TearDown();
        }

        [Test]
        public void ArticleHyperlinks_ScrollPageTo_SectionsWithEqualNames()
        {
            this.provider.HomePage.NavigateToHomePage();

            this.provider.ArticlePage.AssertThat_InThisArticleHyperlink_ScrollsPageTo_ProperArticleSection();
        }
    }
}
