namespace ToolsQA.PO.Pages.Accordion.Sections.CustomizeIcons
{
    using NUnit.Framework;
    using OpenQA.Selenium;

    public partial class CustomizeIconsSection
    {
        public void AssertThat_SectionArrows_AreDisplayed_InFrontOf_AllSections()
        {
            foreach (IWebElement section in this.Sections)
            {
                Assert.That(section.GetAttribute("class").Contains("ui-accordion-icons"));
            }
        }

        public void AssertThat_OnlyTextOf_OpenedSection_IsVisible_ForUser(int position)
        {
            Assert.That(this.Sections[position].GetAttribute("aria-selected").Contains("true"));
            Assert.That(this.Sections[position].GetAttribute("aria-expanded").Contains("true"));
            Assert.That(this.TextSections[position].GetAttribute("aria-hidden").Contains("false"));
            Assert.That(this.TextSections[position].GetAttribute("style").Contains("block"));
            Assert.That(this.TextSections[position].Displayed);
        }
    }
}
