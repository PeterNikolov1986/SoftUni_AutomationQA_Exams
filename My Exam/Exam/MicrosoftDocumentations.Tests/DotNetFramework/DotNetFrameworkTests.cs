namespace MicrosoftDocumentations.Tests.DotNetFramework
{
    using Exam.Base.Tests;
    using MicrosoftDocumentations.PO.PageSetup;
    using NUnit.Framework;

    [TestFixture]
    public class DotNetFrameworkTests : BaseTests
    {
        private static readonly int[] positions = new int[] { 0, 1 };
        private DotNetFrameworkPageProvider provider;

        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            this.provider = new DotNetFrameworkPageProvider(base.ServiceSetupBuilder);
            this.provider.HomePage.NavigateToHomePage();
            this.provider.HomePage.OpenDotNetFrameworkPage();
        }

        [TearDown]
        public override void TearDown()
        {
            this.provider.HomePage.TakeScreenshot();
            this.provider.DotNetFrameworkPage.TakeScreenshot();
            this.provider.ArticlePage.TakeScreenshot();
            base.TearDown();
        }

        [TestCaseSource(nameof(positions))]
        public void ArticlesHyperlinks_ScrollPageTo_SectionsWithEqualNames(int position)
        {
            switch (position)
            {
                case 0: this.provider.DotNetFrameworkPage.OpenSeventhArticlePage(); break;
                case 1: this.provider.DotNetFrameworkPage.OpenEighthArticlePage(); break;
            }

            this.provider.ArticlePage.AssertThat_InThisArticleHyperlink_ScrollsPageTo_ProperArticleSection();
        }
    }
}
