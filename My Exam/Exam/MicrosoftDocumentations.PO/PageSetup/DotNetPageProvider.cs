namespace MicrosoftDocumentations.PO.PageSetup
{
    using System;
    using Exam.Core.ServiceSetup.Interfaces;
    using Exam.Core.Shared.Constants;
    using MicrosoftDocumentations.PO.Pages.Article;
    using MicrosoftDocumentations.PO.Pages.DotNet;
    using MicrosoftDocumentations.PO.Pages.Home;

    public class DotNetPageProvider
    {
        private readonly IServiceSetupBuilder serviceSetup;

        public DotNetPageProvider(IServiceSetupBuilder serviceSetup)
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

        public DotNetPage DotNetPage
        {
            get
            {
                return new DotNetPage(this.serviceSetup.WindowMaximizer,
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
