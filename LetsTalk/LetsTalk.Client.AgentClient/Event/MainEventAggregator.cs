using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using System.ComponentModel.Composition;
using LetsTalk.Core.Common.Core;

namespace LetsTalk.Client.AgentClient.Event
{
    [Export(typeof(IEventAggregator))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class MainEventAggregator : IEventAggregator
    {
        public TEventType GetEvent<TEventType>() where TEventType : EventBase, new()
        {
            return ObjectBase.Container.GetExportedValue<TEventType>();
        }
    }
}
