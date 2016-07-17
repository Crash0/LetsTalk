using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Reflection;
using System.Windows;
using LetsTalk.Client.Bootstrapper;
using LetsTalk.Core.Common.Core;

namespace LetsTalk.Client.AgentClient
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ObjectBase.Container = MEFLoader.Init(new List<ComposablePartCatalog>
            {
                new AssemblyCatalog(Assembly.GetExecutingAssembly())
            });
        }
    }
}