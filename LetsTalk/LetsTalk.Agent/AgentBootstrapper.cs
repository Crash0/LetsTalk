using System;
using System.Collections.Generic;
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
using LetsTalk.Core.Common.UI;
using Prism.Mef;

namespace LetsTalk.Agent
{
    public partial class AgentBootstrapper : MefBootstrapper
    {
        protected override void ConfigureAggregateCatalog()
        {
            
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(AgentBootstrapper).Assembly));
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(AutoPopulateExportedViewsBehavior).Assembly));
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(PhoneModule).Assembly));
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(DashboardModule).Assembly));
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(CustomerModule).Assembly));
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Shell) this.Shell;
            Application.Current.MainWindow.Show();
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
