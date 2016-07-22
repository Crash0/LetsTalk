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
using LetsTalk.Core.Common.Core;
using LetsTalk.Core.Common.UI;
using LetsTalk.Core.Common.UI.Core;

namespace LetsTalk.Agent.Modules.Customers
{
    /// <summary>
    /// Interaction logic for CustomerSearchView.xaml
    /// </summary>
    [ViewExport("Search",RegionName = RegionNames.MainRegion)]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class CustomerSearchView : UserControl
    {
        public CustomerSearchView()
        {
            InitializeComponent();
        }

        [Import]
        public ICustomerSearchViewModel ViewModel
        {
            get { return DataContext as ICustomerSearchViewModel; }
            set { DataContext = value; }
        }
    }
}
