using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Client.Contracts;
using LetsTalk.Client.Proxies;
using LetsTalk.Core.Common.UI;
using Prism.Commands;
using Prism.Regions;

namespace LetsTalk.Agent.Modules.Controllers
{
    [Export(typeof(IPhoneController))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class PhoneController : IPhoneController
    {
        private IRegionManager _regionManager;
        private readonly AgentCommandProxy _commandProxy;
        private ITelephonyService _telephonyClient;

        [ImportingConstructor]
        public PhoneController(IRegionManager regionManager, AgentCommandProxy commandProxy)
        {
            if(commandProxy == null)
                throw new ArgumentNullException(nameof(commandProxy));
            _regionManager = regionManager;
            _commandProxy = commandProxy;
        }

        public DelegateCommand<Guid> CallCommand { get; }
    }
}
