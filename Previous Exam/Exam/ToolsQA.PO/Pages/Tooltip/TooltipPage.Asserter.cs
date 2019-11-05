namespace ToolsQA.PO.Pages.Tooltip
{
    using NUnit.Framework;
    using OpenQA.Selenium;

    public partial class TooltipPage
    {
        private const string TOOLTIP_TEXT = "We ask for your age only for statistical purposes.";

        public void AssertThat_Tooltip_IsDisplayed_OnTheScreen(string tooltipXPathMessage)
        {
            IWebElement tooltip = this.Tooltip(tooltipXPathMessage);

            Assert.That(tooltip.Displayed);
        }

        public void AssertThat_Tooltip_Contains_ProperTextMessage(string tooltipXPathMessage)
        {
            IWebElement tooltip = this.Tooltip(tooltipXPathMessage);

            Assert.That(tooltip.Text.Contains(TOOLTIP_TEXT));
            Assert.AreEqual(TOOLTIP_TEXT, tooltip.Text);
        }
    }
}
