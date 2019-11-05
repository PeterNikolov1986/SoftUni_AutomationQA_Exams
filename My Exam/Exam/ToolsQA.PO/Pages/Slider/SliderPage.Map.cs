namespace ToolsQA.PO.Pages.Slider
{
    using OpenQA.Selenium;

    public partial class SliderPage
    {
        private IWebElement DigitBox
        {
            get
            {
                return base.ElementsFinder.FindElement(By.Id("amount1"));
            }
        }

        private IWebElement Slider
        {
            get
            {
                return base.ElementsFinder.FindElement(By.CssSelector("#slider-range-max > span"));
            }
        }
    }
}
