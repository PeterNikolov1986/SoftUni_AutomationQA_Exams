namespace Exam.Core.Services.Interfaces
{
    using OpenQA.Selenium;

    public interface IWebPageScroller
    {
        void ScrollToFalsePosition(IWebElement element);

        void ScrollToCorrectPosition(IWebElement element);

        void FindCorrectLocation(int position);
    }
}
