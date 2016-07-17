using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Core.Common.UI.Core;

namespace LetsTalk.Client.AgentClient.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
     public class MainViewModel : ViewModelBase
    {
        [Import]
        public DashboardViewModel DashboardViewModel { get; private set; }
        [Import]
        public ClientViewModel ClientViewModel { get; private set; }
        [Import]
        public SurveyViewModel SurveyViewModel { get; private set; }

    }
}
