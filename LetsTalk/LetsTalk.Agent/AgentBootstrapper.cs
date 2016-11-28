using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using LetsTalk.Agent.Modules;
using LetsTalk.Agent.Modules.Customers;
using LetsTalk.Agent.Modules.News;
using LetsTalk.Agent.Modules.Phone;
using LetsTalk.Agent.Modules.SurveyModule;
using LetsTalk.Agent.Modules.Helpdesk;
using LetsTalk.Agent.Modules.ToolBar;
using LetsTalk.Client.Proxies;
using LetsTalk.Core.Common.UI;
using LetsTalk.Core.Common.UI.Commands;
using LetsTalk.Core.Common.UI.Events;
using Prism.Events;
using Prism.Mef;

namespace LetsTalk.Agent
{
    public partial class AgentBootstrapper : MefBootstrapper
    {
        protected override void ConfigureAggregateCatalog()
        {
            //Service Assembly
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(ServiceFactory).Assembly));
            
            //Agent assembly 
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(AgentBootstrapper).Assembly));
            //CoreUi Assembly
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(AutoPopulateExportedViewsBehavior).Assembly));
            //Modules
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(PhoneModule).Assembly));
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(DashboardModule).Assembly));
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(CustomerModule).Assembly));
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(SurveyModule).Assembly));
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(HelpdeskModule).Assembly));
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(ToolbarModule).Assembly));
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

        }

        
        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = (Shell) this.Shell;
            Application.Current.MainWindow.Show();
            //TODO: Initialize stuff here after all modules has loaded
            var e = this.Container.GetExportedValue<IEventAggregator>();
            e.GetEvent<FinishedInitializingEvent>().Publish(1);

        }

        protected override Prism.Regions.IRegionBehaviorFactory ConfigureDefaultRegionBehaviors()
        {
            var factory = base.ConfigureDefaultRegionBehaviors();

            factory.AddIfMissing("AutoPopulateExportedViewsBehavior", typeof(AutoPopulateExportedViewsBehavior));

            return factory;
        }

        protected override DependencyObject CreateShell()
        {
            return this.Container.GetExportedValue<Shell>();
            
        }
    }
}
