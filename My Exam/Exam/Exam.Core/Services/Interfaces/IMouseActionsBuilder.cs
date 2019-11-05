namespace Exam.Core.Services.Interfaces
{
    using OpenQA.Selenium;

    public interface IMouseActionsBuilder
    {
        void PressElement(IWebElement element);

        void DragElement(IWebElement source, int xOffset);
    }
}
