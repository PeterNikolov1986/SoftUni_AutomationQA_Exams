namespace ToolsQA.PO.PageSetup
{
    using System;
    using Exam.Core.ServiceSetup.Interfaces;
    using Exam.Core.Shared.Constants;
    using ToolsQA.PO.Pages.Accordion;
    using ToolsQA.PO.Pages.Accordion.Sections.CustomizeIcons;
    using ToolsQA.PO.Pages.Home;

    public class AccordionPageProvider
    {
        private readonly IServiceSetupBuilder serviceSetup;

        public AccordionPageProvider(IServiceSetupBuilder serviceSetup)
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

        public AccordionPage AccordionPage
        {
            get
            {
                return new AccordionPage(this.serviceSetup.WindowMaximizer,
                    this.serviceSetup.ElementsFinder,
                    this.serviceSetup.ScreenshotMaker,
                    this.serviceSetup.PageScroller,
                    this.serviceSetup.MouseActionsBuilder);
            }
        }

        public CustomizeIconsSection CustomizeIconsSection
        {
            get
            {
                return new CustomizeIconsSection(this.serviceSetup.WindowMaximizer,
                    this.serviceSetup.ElementsFinder,
                    this.serviceSetup.ScreenshotMaker,
                    this.serviceSetup.PageScroller,
                    this.serviceSetup.MouseActionsBuilder);
            }
        }
    }
}
