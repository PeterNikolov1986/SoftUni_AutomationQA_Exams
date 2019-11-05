namespace MicrosoftDocumentations.PO.PageSetup
{
    using System;
    using Exam.Core.ServiceSetup.Interfaces;
    using Exam.Core.Shared.Constants;
    using MicrosoftDocumentations.PO.Pages.Article;
    using MicrosoftDocumentations.PO.Pages.DotNetFramework;
    using MicrosoftDocumentations.PO.Pages.Home;

    public class DotNetFrameworkPageProvider
    {
        private readonly IServiceSetupBuilder serviceSetup;

        public DotNetFrameworkPageProvider(IServiceSetupBuilder serviceSetup)
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

        public DotNetFrameworkPage DotNetFrameworkPage
        {
            get
            {
                return new DotNetFrameworkPage(this.serviceSetup.WindowMaximizer,
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
