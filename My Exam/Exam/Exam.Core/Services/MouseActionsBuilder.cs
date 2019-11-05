namespace Exam.Core.Services
{
    using System;
    using Exam.Core.Services.Interfaces;
    using Exam.Core.ServiceSupport.Interfaces;
    using Exam.Core.Shared.Constants;
    using Exam.Core.Shared.Types;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public class MouseActionsBuilder : IMouseActionsBuilder
    {
        private readonly Actions builder;
        private readonly ITimeManager timeManager;

        public MouseActionsBuilder(Actions builder, ITimeManager timeManager)
        {
            this.builder = builder ?? throw new ArgumentNullException(ExceptionConstants.ACTIONS);
            this.timeManager = timeManager ?? throw new ArgumentNullException(ExceptionConstants.TIME_MANAGER);
        }

        public void PressElement(IWebElement element)
        {
            element.Click();
            this.timeManager.DelayPage(DelayType.Single);
        }

        public void DragElement(IWebElement source, int xOffset)
        {
            this.builder.DragAndDropToOffset(source, xOffset, 0).Perform();
            this.timeManager.DelayPage(DelayType.Double);
        }
    }
}
