using System;
using System.Collections.Generic;
using System.ServiceModel;
using LetsTalk.Business.Contracts;

namespace LetsTalk.Business.Managers
{
    [ServiceBehavior(
        
        InstanceContextMode = InstanceContextMode.Single,
        ConcurrencyMode = ConcurrencyMode.Multiple
        )]
    public class TelephonyManager: ManagerBase, ITelephonyService
    {
        public TelephonyManager()
        {
            CurrentChannels = new Dictionary<Guid, ITelephonyServiceCallbacks>();
        }
        public bool CloseCall(string callId)
        {
            return false;
        }

        public bool Connect(Guid agentId)
        {
            var s = OperationContext.Current.GetCallbackChannel<ITelephonyServiceCallbacks>();
            CurrentChannels.Add(agentId,s);
            
            return false;
        }

        bool ITelephonyService.SendCallTo(Guid agentId, CallerInfo callInfo)
        {
            return SendCallTo(agentId, callInfo);
        }

        private static Dictionary<Guid, ITelephonyServiceCallbacks> CurrentChannels; 

        static bool SendCallTo(Guid agentId, CallerInfo callInfo)
        {
            if (CurrentChannels.ContainsKey(agentId))
            {
                ITelephonyServiceCallbacks callbacks;
                var r =CurrentChannels.TryGetValue(agentId, out callbacks);
                if (r != true)
                    return false;
                callbacks.CallerConnect(callInfo);
                return true;
            }
            return false;
        }
    }
}
