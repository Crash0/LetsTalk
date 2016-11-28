namespace LetsTalk.Business.Managers
{
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;

    using LetsTalk.Business.Contracts;

    using NServiceBus.Logging.Loggers;

    [ServiceBehavior(
        InstanceContextMode = InstanceContextMode.Single, 
        ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class TelephonyManager : ManagerBase, ITelephonyService
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
            s.ConnectionSucceeded();
            return true;
        }

        public bool Ping()
        {
            //TODo:  remove manualy plased guid
            CurrentChannels[Guid.Parse("D56F4395-3972-4CA9-9BDE-A4173B1EB051")].CallerConnect(new CallerInfo { CallerName = "Jonas deb grå", CallerNumber = 98608900, CallerId = Guid.NewGuid() });
            Console.WriteLine($"Got ping from {OperationContext.Current.Channel.RemoteAddress} at {DateTime.Now}");
            return true;
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
