
namespace LetsTalk.Client.Proxies
{
    using System;
    using System.ComponentModel.Composition;
    using System.ComponentModel.Composition.Primitives;
    using System.ServiceModel;

    using LetsTalk.Client.Contracts;
    using LetsTalk.Core.Common.ServiceModel;

    [Export(typeof(ITargetingService))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class TargetClient : ClientBase<ITargetingService>, ITargetingService
    {
        public ActionOnCustomerCommand[] GetAvailableCommands(Guid targetId)
        {
            return Channel.GetAvailableCommands(targetId);
        }

        public bool MarkTargetActionAsComplete(Guid targetId, ActionOnCustomerCommand action)
        {
            return Channel.MarkTargetActionAsComplete(targetId, action);
        }
    }
}