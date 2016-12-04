// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AgentBootstrapper.cs" company="GoDialog">
//   Copyright (C) 2016 Jonas Fjeld.
//   This file is part of LetsTalk Software pack.
//   License: Attribution-NonCommercial-ShareAlike 4.0 International.
//   See https://creativecommons.org/licenses/by-nc-sa/4.0/legalcode
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace LetsTalk.Agent
{
    using System.ComponentModel.Composition.Hosting;
    using System.Windows;

    using LetsTalk.Agent.Modules.Customers;
    using LetsTalk.Agent.Modules.Helpdesk;
    using LetsTalk.Agent.Modules.News;
    using LetsTalk.Agent.Modules.Phone;
    using LetsTalk.Agent.Modules.SurveyModule;
    using LetsTalk.Agent.Modules.Targets;
    using LetsTalk.Agent.Modules.ToolBar;
    using LetsTalk.Client.Proxies;
    using LetsTalk.Core.Common.UI;
    using LetsTalk.Core.Common.UI.Events;

    using Prism.Events;
    using Prism.Mef;
    using Prism.Regions;

    /// <summary>
    ///     The boot class.
    /// </summary>
    public partial class AgentBootstrapper : MefBootstrapper
    {
        /// <summary>
        ///     TODO The configure aggregate catalog.
        /// </summary>
        protected override void ConfigureAggregateCatalog()
        {
            // Service Assembly
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(ServiceFactory).Assembly));

            // Agent Assembly 
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(AgentBootstrapper).Assembly));

            // CoreUi Assembly
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(AutoPopulateExportedViewsBehavior).Assembly));

            // Modules
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(TargetModule).Assembly));
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(PhoneModule).Assembly));
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(DashboardModule).Assembly));
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(CustomerModule).Assembly));
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(SurveyModule).Assembly));
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(HelpdeskModule).Assembly));
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(ToolbarModule).Assembly));
        }

        /// <summary>
        ///     TODO The configure module catalog.
        /// </summary>
        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
        }

        /// <summary>
        ///     TODO The initialize shell.
        /// </summary>
        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = (Shell)this.Shell;
            Application.Current.MainWindow.Show();

            // TODO: Initialize stuff here after all modules has loaded
            var e = this.Container.GetExportedValue<IEventAggregator>();
            e.GetEvent<FinishedInitializingEvent>().Publish(1);
        }

        /// <summary>
        ///     The configure default region behaviors.
        /// </summary>
        /// <returns>
        ///     The <see cref="IRegionBehaviorFactory" />.
        /// </returns>
        protected override IRegionBehaviorFactory ConfigureDefaultRegionBehaviors()
        {
            var factory = base.ConfigureDefaultRegionBehaviors();

            factory.AddIfMissing("AutoPopulateExportedViewsBehavior", typeof(AutoPopulateExportedViewsBehavior));

            return factory;
        }

        /// <summary>
        ///     TODO The create shell.
        /// </summary>
        /// <returns>
        ///     The <see cref="DependencyObject" />.
        /// </returns>
        protected override DependencyObject CreateShell()
        {
            return this.Container.GetExportedValue<Shell>();
        }
    }
}