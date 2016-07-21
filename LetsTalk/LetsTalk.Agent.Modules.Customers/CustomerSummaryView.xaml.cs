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
using LetsTalk.Core.Common.UI.Core;
using Prism.Regions;

namespace LetsTalk.Agent.Modules.Customers
{
    /// <summary>
    /// Interaction logic for CustomerSummaryView.xaml
    /// </summary>
    [ViewExport(RegionName = RegionNames.MainRegion)]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class CustomerSummaryView : UserControl
    {
        private IRegionManager _regionManager;
        
        [ImportingConstructor]
        public CustomerSummaryView(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            InitializeComponent();
        }
    }
}
