namespace MicrosoftDocumentations.Tests.DotNetCore
{
    using Exam.Base.Tests;
    using MicrosoftDocumentations.PO.PageSetup;
    using NUnit.Framework;

    [TestFixture]
    public class DotNetCoreTests : BaseTests
    {
        private static readonly int[] positions = new int[] { 0, 1, 2 };
        private DotNetCorePageProvider provider;

        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            this.provider = new DotNetCorePageProvider(base.ServiceSetupBuilder);
            this.provider.HomePage.NavigateToHomePage();
            this.provider.HomePage.OpenDotNetCorePage();
        }

        [TearDown]
        public override void TearDown()
        {
            this.provider.HomePage.TakeScreenshot();
            this.provider.DotNetCorePage.TakeScreenshot();
            this.provider.ArticlePage.TakeScreenshot();
            base.TearDown();
        }

        [TestCaseSource(nameof(positions))]
        public void ArticlesHyperlinks_ScrollPageTo_SectionsWithEqualNames(int position)
        {
            switch (position)
            {
                case 0: this.provider.DotNetCorePage.OpenFirstArticlePage(); break;
                case 1: this.provider.DotNetCorePage.OpenSecondArticlePage(); break;
                case 2: this.provider.DotNetCorePage.OpenThirdArticlePage(); break;
            }

            this.provider.ArticlePage.AssertThat_InThisArticleHyperlink_ScrollsPageTo_ProperArticleSection();
        }
    }
}
