namespace ToolsQA.PO.Pages.Slider
{
    using System;
    using NUnit.Framework;

    public partial class SliderPage
    {
        private const int ONE = 1;
        private const int TWO = 2;
        private const int TEN = 10;

        public void AssertThat_SliderDrag_Increases_DigitBoxValue(int defaultValue, int changedValue)
        {
            if (defaultValue != ONE)
            {
                throw new ArgumentException("The DigitBox default value has to be a digit, equal to 1.");
            }
            else if (changedValue < TWO && changedValue > TEN)
            {
                throw new ArgumentException("The DigitBox changed value has to be a digit between 2 and 10.");
            }

            Assert.AreEqual(defaultValue, ONE);
            Assert.GreaterOrEqual(changedValue, TWO);
            Assert.LessOrEqual(changedValue, TEN);
            Assert.Greater(changedValue, defaultValue);
        }
    }
}
