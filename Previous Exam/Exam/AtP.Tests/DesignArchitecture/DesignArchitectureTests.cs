namespace AtP.Tests.DesignArchitecture
{
    using AtP.PO.PageSetup;
    using Exam.Base.Tests;
    using NUnit.Framework;

    [TestFixture]
    public class DesignArchitectureTests : BaseTests
    {
        private static readonly int[] positions = new int[] { 0, 1, 2, 3, 4, 5 };
        private DesignArchitecturePageProvider provider;

        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            this.provider = new DesignArchitecturePageProvider(base.ServiceSetupBuilder);
            this.provider.HomePage.NavigateToHomePage();
            this.provider.HomePage.OpenSidebarPage();
            this.provider.SidebarPage.OpenDesignArchitecturePage();
        }

        [TearDown]
        public override void TearDown()
        {
            this.provider.HomePage.TakeScreenshot();
            this.provider.SidebarPage.TakeScreenshot();
            this.provider.DesignArchitecturePage.TakeScreenshot();
            this.provider.ArticlePage.TakeScreenshot();
            base.TearDown();
        }

        [TestCaseSource(nameof(positions))]
        public void QuickNavigationHyperlinks_ScrollPageTo_ProperSections(int position)
        {
            switch (position)
            {
                case 0: this.provider.DesignArchitecturePage.OpenFirstArticlePage(); break;
                case 1: this.provider.DesignArchitecturePage.OpenSecondArticlePage(); break;
                case 2: this.provider.DesignArchitecturePage.OpenThirdArticlePage(); break;
                case 3: this.provider.DesignArchitecturePage.OpenFourthArticlePage(); break;
                case 4: this.provider.DesignArchitecturePage.OpenFifthArticlePage(); break;
                case 5: this.provider.DesignArchitecturePage.OpenSixthArticlePage(); break;
            }

            this.provider.ArticlePage.AssertThat_QuickNavigationHyperlinks_ScrollPageTo_ProperSections();
        }
    }
}
