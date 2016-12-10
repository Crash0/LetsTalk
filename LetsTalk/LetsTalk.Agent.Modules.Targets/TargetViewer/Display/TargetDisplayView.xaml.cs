using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LetsTalk.Agent.Modules.Targets.TargetViewer.Display
{
    using System.ComponentModel.Composition;

    using LetsTalk.Core.Common.UI;
    using LetsTalk.Core.Common.UI.Core;

    /// <summary>
    /// Interaction logic for TargetDisplayView.xaml
    /// </summary>
    [ViewExport(RegionName = RegionNames.MainRegion)]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class TargetDisplayView : UserControl
    {
        public TargetDisplayView()
        {
            InitializeComponent();
        }


        [Import]
        public ITargetDisplayViewModel ViewModel
        {
            get
            {
                return DataContext as TargetDisplayViewModel;
            }
            set
            {
                DataContext = value;
            }

        }

    }
}
