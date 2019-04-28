using System;
using System.Windows;
using LetsTalk.Agent.Modules.TimeCard;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;

namespace LetsTalk.Agent
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //TODO: What Do I do?
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<TimeCardModule>();
            base.ConfigureModuleCatalog(moduleCatalog);
        }


        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
#if (DEBUG)
            RunInDebugMode();
#else
            RunInReleaseMode();
#endif
            ShutdownMode = ShutdownMode.OnMainWindowClose;
        }

        private static void RunInReleaseMode()
        {
            AppDomain.CurrentDomain.UnhandledException += AppDomainUnhandledException;

            try
            {
                //var bootstrapper = new AgentBootstrapper();
                //bootstrapper.Run();

            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private static void AppDomainUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            HandleException(e.ExceptionObject as Exception);
        }

        private static void HandleException(Exception ex)
        {
            if (ex == null)
                return;

            ExceptionPolicy.HandleException(ex, "Default Policy");
            MessageBox.Show(Agent.Properties.Resources.UnhandledException);
            Environment.Exit(1);
        }

        private static void RunInDebugMode()
        {
            //var bootstrapper = new AgentBootstrapper();
            //bootstrapper.Run();
        }
    }
}
