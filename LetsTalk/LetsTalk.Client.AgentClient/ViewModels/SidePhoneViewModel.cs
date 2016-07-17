using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Core.Common.Contracts.DataContracts;

namespace LetsTalk.Client.AgentClient.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class PhoneViewModel
    {
        public PhoneViewModel()
        {
            
        }

        public CallerInfo Caller { get; set; }

        public void LoadCaller(CallerInfo callerInfo)
        {
            Caller = callerInfo;
        }
    }
}
