namespace Exam.Core.Services.Interfaces
{
    using OpenQA.Selenium;

    public interface IWebPageScroller
    {
        void ScrollToCorrectPosition(IWebElement element);

        void ScrollToFalsePosition(IWebElement element);
    }
}
