using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using LetsTalk.Client.AgentClient.Event;
using LetsTalk.Core.Common.UI.Core;
using LetsTalk.Core.Common.UI.Events;
using Prism.Events;

namespace LetsTalk.Client.AgentClient.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
     public class MainViewModel : ViewModelBase
    {
        private readonly IEventAggregator _eventAggregator;

        [ImportingConstructor]
        public MainViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            eventAggregator.GetEvent<OpenCallerViewEvent>().Subscribe((guid => MessageBox.Show(guid.ToString())));

        }
        [Import]
        public DashboardViewModel DashboardViewModel { get; private set; }
        [Import]
        public ClientViewModel ClientViewModel { get; private set; }
        [Import]
        public SurveyViewModel SurveyViewModel { get; private set; }
        [Import] 
        public PhoneViewModel PhoneViewModel { get; set; }

    }
}
