namespace ToolsQA.Tests.Accordion
{
    using Exam.Base.Tests;
    using NUnit.Framework;
    using ToolsQA.PO.PageSetup;

    [TestFixture]
    class AccordionTests : BaseTests
    {
        private static readonly int[] positions = new int[] { 0, 1, 2, 3 };
        private AccordionPageProvider provider;

        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            this.provider = new AccordionPageProvider(base.ServiceSetupBuilder);
            this.provider.HomePage.NavigateToHomePage();
            this.provider.HomePage.OpenAccordionPage();
            this.provider.AccordionPage.OpenCustomizeIconsSection();
        }

        [TearDown]
        public override void TearDown()
        {
            this.provider.HomePage.TakeScreenshot();
            this.provider.AccordionPage.TakeScreenshot();
            this.provider.CustomizeIconsSection.TakeScreenshot();
            base.TearDown();
        }

        [Test]
        public void SectionArrows_AreDisplayed_InFrontOf_AllSections()
        {
            this.provider.CustomizeIconsSection.ClickTwiceToggleIconsButton();

            this.provider.CustomizeIconsSection.AssertThat_SectionArrows_AreDisplayed_InFrontOf_AllSections();
        }

        [TestCaseSource(nameof(positions))]
        public void OnlyTextOf_OpenedSection_IsVisible_ForUser(int position)
        {
            this.provider.CustomizeIconsSection.OpenSection(position);

            this.provider.CustomizeIconsSection.AssertThat_OnlyTextOf_OpenedSection_IsVisible_ForUser(position);
        }
    }
}
