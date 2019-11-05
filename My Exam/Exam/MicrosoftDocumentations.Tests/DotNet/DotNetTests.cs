namespace MicrosoftDocumentations.Tests.DotNet
{
    using Exam.Base.Tests;
    using MicrosoftDocumentations.PO.PageSetup;
    using NUnit.Framework;

    [TestFixture]
    public class DotNetTests : BaseTests
    {
        private static readonly int[] positions = new int[] { 0, 1, 2 };
        private DotNetPageProvider provider;

        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            this.provider = new DotNetPageProvider(base.ServiceSetupBuilder);
            this.provider.HomePage.NavigateToHomePage();
            this.provider.HomePage.OpenDotNetPage();
        }

        [TearDown]
        public override void TearDown()
        {
            this.provider.HomePage.TakeScreenshot();
            this.provider.DotNetPage.TakeScreenshot();
            this.provider.ArticlePage.TakeScreenshot();
            base.TearDown();
        }

        [TestCaseSource(nameof(positions))]
        public void ArticlesHyperlinks_ScrollPageTo_SectionsWithEqualNames(int position)
        {
            switch (position)
            {
                case 0: this.provider.DotNetPage.OpenFourthArticlePage(); break;
                case 1: this.provider.DotNetPage.OpenFifthArticlePage(); break;
                case 2: this.provider.DotNetPage.OpenSixthArticlePage(); break;
            }

            this.provider.ArticlePage.AssertThat_InThisArticleHyperlink_ScrollsPageTo_ProperArticleSection();
        }
    }
}
