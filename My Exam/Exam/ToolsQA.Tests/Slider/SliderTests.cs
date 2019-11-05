namespace ToolsQA.Tests.Slider
{
    using Exam.Base.Tests;
    using NUnit.Framework;
    using ToolsQA.PO.PageSetup;

    [TestFixture]
    public class SliderTests : BaseTests
    {
        private const int NEGATIVE_DRAG = -60;
        private const int FIRST_DRAG = 60;
        private const int SECOND_DRAG = 120;
        private const int THIRD_DRAG = 200;
        private const int FOURTH_DRAG = 280;
        private const int FIFTH_DRAG = 360;
        private const int SIXTH_DRAG = 440;
        private const int SEVENTH_DRAG = 520;
        private const int EIGHTH_DRAG = 600;
        private const int NINTH_DRAG = 680;

        private SliderPageProvider provider;

        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            this.provider = new SliderPageProvider(base.ServiceSetupBuilder);
        }

        [TearDown]
        public override void TearDown()
        {
            this.provider.HomePage.TakeScreenshot();
            this.provider.SliderPage.TakeScreenshot();
            base.TearDown();
        }

        [TestCase(FIRST_DRAG)]
        [TestCase(SECOND_DRAG)]
        [TestCase(THIRD_DRAG)]
        [TestCase(FOURTH_DRAG)]
        [TestCase(FIFTH_DRAG)]
        [TestCase(SIXTH_DRAG)]
        [TestCase(SEVENTH_DRAG)]
        [TestCase(EIGHTH_DRAG)]
        [TestCase(NINTH_DRAG)]
        public void SliderDrag_Increases_DigitBoxValue(int xOffset)
        {
            this.provider.HomePage.NavigateToHomePage();
            this.provider.HomePage.OpenSliderPage();

            int defaultValue = this.provider.SliderPage.GetDigitBoxValue(NEGATIVE_DRAG);
            int changedValue = this.provider.SliderPage.GetDigitBoxValue(xOffset);

            this.provider.SliderPage.AssertThat_SliderDrag_Increases_DigitBoxValue(defaultValue, changedValue);
        }
    }
}
