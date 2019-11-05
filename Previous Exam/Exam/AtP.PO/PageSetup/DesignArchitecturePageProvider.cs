namespace AtP.PO.PageSetup
{
    using System;
    using AtP.PO.Pages.Article;
    using AtP.PO.Pages.DesignArchitecture;
    using AtP.PO.Pages.Home;
    using AtP.PO.Pages.Sidebar;
    using Exam.Core.ServiceSetup.Interfaces;
    using Exam.Core.Shared.Constants;

    public class DesignArchitecturePageProvider
    {
        private readonly IServiceSetupBuilder serviceSetup;

        public DesignArchitecturePageProvider(IServiceSetupBuilder serviceSetup)
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
                    this.serviceSetup.MouseActionsBuilder);
            }
        }

        public SidebarPage SidebarPage
        {
            get
            {
                return new SidebarPage(this.serviceSetup.WindowMaximizer,
                    this.serviceSetup.ElementsFinder,
                    this.serviceSetup.ScreenshotMaker,
                    this.serviceSetup.PageScroller,
                    this.serviceSetup.MouseActionsBuilder);
            }
        }

        public DesignArchitecturePage DesignArchitecturePage
        {
            get
            {
                return new DesignArchitecturePage(this.serviceSetup.WindowMaximizer,
                    this.serviceSetup.ElementsFinder,
                    this.serviceSetup.ScreenshotMaker,
                    this.serviceSetup.PageScroller,
                    this.serviceSetup.MouseActionsBuilder);
            }
        }

        public ArticlePage ArticlePage
        {
            get
            {
                return new ArticlePage(this.serviceSetup.WindowMaximizer,
                    this.serviceSetup.ElementsFinder,
                    this.serviceSetup.ScreenshotMaker,
                    this.serviceSetup.PageScroller);
            }
        }
    }
}
