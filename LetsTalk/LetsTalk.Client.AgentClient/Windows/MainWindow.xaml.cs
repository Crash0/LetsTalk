using LetsTalk.Client.AgentClient.ViewModels;
using LetsTalk.Core.Common.Core;
using MahApps.Metro.Controls;

namespace LetsTalk.Client.AgentClient.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            MainView.DataContext = ObjectBase.Container.GetExportedValue<MainViewModel>();
        }
    }
}