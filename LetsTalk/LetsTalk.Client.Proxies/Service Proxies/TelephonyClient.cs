using System;
using System.ComponentModel.Composition;
using System.ServiceModel;
using System.Threading.Tasks;
using LetsTalk.Client.Contracts;
using LetsTalk.Core.Common.ServiceModel;

namespace LetsTalk.Client.Proxies
{
    [Export(typeof(ITelephonyService))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class TelephonyClient : DuplexClientBase<ITelephonyService>, ITelephonyService
    {
        public static readonly ITelephonyServiceCallbacks CallbackInstance = new TelephoneServiceCallbackHandeler();
        public static readonly InstanceContext InstanceContext = new InstanceContext(CallbackInstance);

        [ImportingConstructor]
        protected TelephonyClient() : base(InstanceContext)
        {
            
        }

        public bool Connect(Guid agentId)
        {
            return Channel.Connect(agentId);
        }

        public bool CloseCall(Guid callId)
        {
            return Channel.CloseCall(callId);
        }

        public Task<bool> CloseCallAsync(Guid callId)
        {
            return Channel.CloseCallAsync(callId);
        }

        public ITelephonyServiceCallbacks GetCallbacks() => CallbackInstance;
        public bool Ping()
        {
            return Channel.Ping();
        }
    }
}
