using System.ComponentModel.Composition.Primitives;
using LetsTalk.Client.AgentClient.ViewModels;
using LetsTalk.Core.Common.Core;
using MahApps.Metro.Controls;
using System.ComponentModel.Composition;

namespace LetsTalk.Client.AgentClient.Windows
{
    /// <summary>
    /// Interaction logic for Shell.xaml
    /// </summary>
    [Export]
    public partial class Shell : MetroWindow
    {
        public Shell()
        {
            InitializeComponent();
            MainView.DataContext = ObjectBase.Container.GetExportedValue<MainViewModel>();
        }
    }
}