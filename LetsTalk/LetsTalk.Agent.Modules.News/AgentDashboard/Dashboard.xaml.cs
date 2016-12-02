using LetsTalk.Core.Common.UI.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
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
using LetsTalk.Core.Common.UI;

namespace LetsTalk.Agent.Modules.News
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    [ViewExport(RegionName = RegionNames.MainRegion)]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }
    }
}
