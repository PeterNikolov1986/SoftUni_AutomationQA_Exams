namespace Exam.Core.Services
{
    using System;
    using Exam.Core.Services.Interfaces;
    using Exam.Core.ServiceSupport.Interfaces;
    using Exam.Core.Shared.Constants;
    using Exam.Core.Shared.Types;
    using OpenQA.Selenium;

    public class WebPageScroller : IWebPageScroller
    {
        private readonly IJavaScriptExecutor jse;
        private readonly ITimeManager timeManager;

        public WebPageScroller(IJavaScriptExecutor jse, ITimeManager timeManager)
        {
            this.jse = jse ?? throw new ArgumentNullException(ExceptionConstants.JSE);
            this.timeManager = timeManager ?? throw new ArgumentNullException(ExceptionConstants.TIME_MANAGER);
        }

        public void ScrollToCorrectPosition(IWebElement element)
        {
            this.jse.ExecuteScript("arguments[0].scrollIntoView();", element);
            this.timeManager.DelayPage(DelayType.Single);
        }

        public void ScrollToFalsePosition(IWebElement element)
        {
            this.jse.ExecuteScript("arguments[0].scrollIntoView(false);", element);
            this.timeManager.DelayPage(DelayType.Double);
        }
    }
}
