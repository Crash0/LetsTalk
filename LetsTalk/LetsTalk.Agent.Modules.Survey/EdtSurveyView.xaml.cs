#region Header

// <copyright file="EdtSurveyView.xaml.cs" company="GoDialog AS">
// File Created:  2016 07 24
// Last Modified: 2016 201607 24 
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>

#endregion

#region Usings

using System.ComponentModel.Composition;
using System.Windows.Controls;
using LetsTalk.Core.Common.UI;
using LetsTalk.Core.Common.UI.Core;

#endregion

namespace LetsTalk.Agent.Modules.SurveyModule
{
    /// <summary>
    ///     Interaction logic for EdtSurveyView.xaml
    /// </summary>
    [ViewExport("AddSurvey", RegionName = RegionNames.MainRegion)]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class EdtSurveyView : UserControl
    {
        public EdtSurveyView()
        {
            InitializeComponent();
        }

        [Import]
        private IEditSurveyViewModel SurveyViewModel
        {
            get { return DataContext as IEditSurveyViewModel; }
            set { DataContext = value; }
        }
    }
}