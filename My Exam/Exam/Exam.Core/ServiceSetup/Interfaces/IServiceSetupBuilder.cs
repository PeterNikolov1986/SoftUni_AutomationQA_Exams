namespace Exam.Core.ServiceSetup.Interfaces
{
    using Exam.Core.Services.Interfaces;

    public interface IServiceSetupBuilder
    {
        IWindowMaximizer WindowMaximizer { get; }

        IWebElementsFinder ElementsFinder { get; }

        IScreenshotMaker ScreenshotMaker { get; }

        IWebPageNavigator PageNavigator { get; }

        IMouseActionsBuilder MouseActionsBuilder { get; }

        IWebPageScroller PageScroller { get; }
    }
}
