namespace ToolsQA.Tests.Tooltip
{
    using Exam.Base.Tests;
    using NUnit.Framework;
    using ToolsQA.PO.PageSetup;

    [TestFixture]
    public class TooltipTests : BaseTests
    {
        private TooltipPageProvider provider;
        private string tooltipXPathMessage;

        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            this.provider = new TooltipPageProvider(base.ServiceSetupBuilder);
            this.provider.HomePage.NavigateToHomePage();
            this.provider.HomePage.OpenTooltipPage();
            this.tooltipXPathMessage = this.provider.TooltipPage.FindTooltipXPathMessage();
        }

        [TearDown]
        public override void TearDown()
        {
            this.provider.HomePage.TakeScreenshot();
            this.provider.TooltipPage.TakeScreenshot();
            base.TearDown();
        }
        
        [Test]
        public void Tooltip_IsDisplayed_OnTheScreen()
        {
            this.provider.TooltipPage.AssertThat_Tooltip_IsDisplayed_OnTheScreen(this.tooltipXPathMessage);
        }

        [Test]
        public void Tooltip_Contains_ProperTextMessage()
        {
            this.provider.TooltipPage.AssertThat_Tooltip_Contains_ProperTextMessage(this.tooltipXPathMessage);
        }
    }
}
