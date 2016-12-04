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

namespace LetsTalk.Agent.Modules.Targets.TargetViewer.Edit
{
    using System.ComponentModel.Composition;
    using System.Diagnostics.CodeAnalysis;

    using LetsTalk.Core.Common.UI;
    using LetsTalk.Core.Common.UI.Core;

    /// <summary>
    /// Interaction logic for TargetEditView.xaml
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
    [ViewExport(RegionName = RegionNames.MainRegion)]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class TargetEditView : UserControl
    {
        
        public TargetEditView()
        {
            InitializeComponent();
        }

        [Import]
        private ITargetEditViewModel TargetEditViewMode
        {
            get
            {
                return DataContext as ITargetEditViewModel;
            }

            set
            {
                DataContext = value;
            }
        }

    }
}
