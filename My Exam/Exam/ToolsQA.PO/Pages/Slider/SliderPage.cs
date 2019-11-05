namespace ToolsQA.PO.Pages.Slider
{
    using System;
    using Exam.Base.Pages;
    using Exam.Core.Services.Interfaces;
    using Exam.Core.Shared.Constants;

    public partial class SliderPage : BasePage
    {
        private readonly IMouseActionsBuilder mouseActions;

        public SliderPage(IWindowMaximizer windowMaximizer,
            IWebElementsFinder elementsFinder,
            IScreenshotMaker screenshotMaker,
            IMouseActionsBuilder mouseActions)
            : base(windowMaximizer, elementsFinder, screenshotMaker)
        {
            this.mouseActions = mouseActions ?? throw new ArgumentNullException(ExceptionConstants.MOUSE_ACTIONS);
        }

        public int GetDigitBoxValue(int xOffset)
        {
            this.mouseActions.DragElement(this.Slider, xOffset);

            return int.Parse(this.DigitBox.GetAttribute("value"));
        }
    }
}
