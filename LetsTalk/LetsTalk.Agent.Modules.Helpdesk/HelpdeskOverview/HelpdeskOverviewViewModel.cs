using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Core.Common.UI.Core;

namespace LetsTalk.Agent.Modules.Helpdesk.HelpdeskOverview
{
    [Export(typeof(IHelpdeskOverviewViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    class HelpdeskOverviewViewModel : ViewModelBase, IHelpdeskOverviewViewModel
    {
        public HelpdeskOverviewViewModel()
        {
        }
    }
    
    
    internal interface IHelpdeskOverviewViewModel
    {
    }
}
