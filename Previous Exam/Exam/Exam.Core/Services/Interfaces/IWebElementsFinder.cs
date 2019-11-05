namespace Exam.Core.Services.Interfaces
{
    using System.Collections.Generic;
    using OpenQA.Selenium;

    public interface IWebElementsFinder
    {
        IWebElement FindElement(By by);

        IEnumerable<IWebElement> FindElements(By by);
    }
}
