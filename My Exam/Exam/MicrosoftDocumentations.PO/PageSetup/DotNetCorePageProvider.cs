namespace MicrosoftDocumentations.PO.PageSetup
{
    using System;
    using Exam.Core.ServiceSetup.Interfaces;
    using Exam.Core.Shared.Constants;
    using MicrosoftDocumentations.PO.Pages.Article;
    using MicrosoftDocumentations.PO.Pages.DotNetCore;
    using MicrosoftDocumentations.PO.Pages.Home;

    public class DotNetCorePageProvider
    {
        private readonly IServiceSetupBuilder serviceSetup;

        public DotNetCorePageProvider(IServiceSetupBuilder serviceSetup)
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

        public DotNetCorePage DotNetCorePage
        {
            get
            {
                return new DotNetCorePage(this.serviceSetup.WindowMaximizer,
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
