using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.UI.Core;

namespace LetsTalk.Client.AgentClient.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class DashboardViewModel : ViewModelBase
    {
        private IServiceFactory _serviceFactory;

        [ImportingConstructor]
        public DashboardViewModel(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;
        }

        protected override string ViewTitle => "Dashboard";
    }
}
