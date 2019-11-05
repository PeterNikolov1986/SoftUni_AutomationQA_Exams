namespace ToolsQA.Tests.Datepicker
{
    using Exam.Base.Tests;
    using NUnit.Framework;
    using ToolsQA.PO.PageSetup;

    [TestFixture]
    public class DatepickerTests : BaseTests
    {
        private static readonly int[] positions = new int[] { 0, 1, 2, 3, 4, 5 };
        private DatepickerPageProvider provider;

        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            this.provider = new DatepickerPageProvider(base.ServiceSetupBuilder);
        }

        [TearDown]
        public override void TearDown()
        {
            this.provider.HomePage.TakeScreenshot();
            this.provider.DatepickerPage.TakeScreenshot();
            base.TearDown();
        }

        [TestCaseSource(nameof(positions))]
        public void FormateDateOptions_Change_DateInputFieldValueTo_ProperFormat(int position)
        {
            this.provider.HomePage.NavigateToHomePage();
            this.provider.HomePage.OpenDatepickerPage();

            this.provider.DatepickerPage.SelectFormatDateOption(position);
            this.provider.DatepickerPage.SelectProperDate();

            this.provider.DatepickerPage.AssertThat_FormateDateOptions_Change_DateInputFieldValueTo_ProperFormat(position);
        }
    }
}
