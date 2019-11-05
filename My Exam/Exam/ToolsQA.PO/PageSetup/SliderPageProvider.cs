namespace ToolsQA.PO.PageSetup
{
    using System;
    using Exam.Core.ServiceSetup.Interfaces;
    using Exam.Core.Shared.Constants;
    using ToolsQA.PO.Pages.Home;
    using ToolsQA.PO.Pages.Slider;

    public class SliderPageProvider
    {
        private readonly IServiceSetupBuilder serviceSetup;

        public SliderPageProvider(IServiceSetupBuilder serviceSetup)
        {
            this.serviceSetup = serviceSetup ?? throw new ArgumentNullException(ExceptionConstants.SERVICE_SETUP);
        }

        public HomePage HomePage
        {
            get
            {
                return new HomePage(this.serviceSetup.WindowMaximizer,
                    this.serviceSetup.ElementsFinder,
                    this.serviceSetup.ScreenshotMaker,
                    this.serviceSetup.PageNavigator,
                    this.serviceSetup.PageScroller,
                    this.serviceSetup.MouseActionsBuilder);
            }
        }

        public SliderPage SliderPage
        {
            get
            {
                return new SliderPage(this.serviceSetup.WindowMaximizer,
                    this.serviceSetup.ElementsFinder,
                    this.serviceSetup.ScreenshotMaker,
                    this.serviceSetup.MouseActionsBuilder);
            }
        }
    }
}
