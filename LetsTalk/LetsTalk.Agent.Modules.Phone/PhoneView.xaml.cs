using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using LetsTalk.Core.Common.UI;
using LetsTalk.Core.Common.UI.Core;
namespace LetsTalk.Agent.Modules.Phone
{
    /// <summary>
    /// Interaction logic for PhoneView.xaml
    /// </summary>
    [ViewExport(RegionName = RegionNames.PhoneRegion)]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class PhoneView : UserControl
    {
        
        public PhoneView()
        {
            InitializeComponent();
        }
    }
}
