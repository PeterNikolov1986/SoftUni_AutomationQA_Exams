namespace Exam.Core.Services.Interfaces
{
    using OpenQA.Selenium;

    public interface IMouseActionsBuilder
    {
        void PressElement(IWebElement element);

        void HoverElement(IWebElement source);
    }
}
