﻿using System;
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

namespace LetsTalk.Agent.Modules.SurveyModule.Display
{
    /// <summary>
    /// Interaction logic for DisplaySurveyView.xaml
    /// </summary>
    [ViewExport(ViewNames.DisplaySurveyView, RegionName = RegionNames.MainRegion)]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class DisplaySurveyView : UserControl
    {
        public DisplaySurveyView()
        {
            InitializeComponent();
        }

        [Import]
        IDisplaySurveyViewModel ViewModel
        {
            get { return DataContext as IDisplaySurveyViewModel;}
            set { DataContext = value; }
        }
    }
}
