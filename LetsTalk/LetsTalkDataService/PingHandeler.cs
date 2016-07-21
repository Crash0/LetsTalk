using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Kernel.Messages;
using NServiceBus;
using LetsTalk.Business.Contracts;

namespace LetsTalkDataService
{
    public class PingHandeler : IHandleMessages<Ping>
    {
        private readonly IList<ServiceHost> _factories;
        private IBus _bus;
        public PingHandeler(IList<ServiceHost> factories, IBus bus)
        {
            this._factories = factories;
            _bus = bus;
        }

        public void Handle(Ping message)
        {
            Console.WriteLine("\n HandelingPing \n");
            var telephonyService = _factories[3].SingletonInstance as ITelephonyService;
            var agentId = Guid.Parse("C4862996-1A46-4EBD-B531-9710E5AE5A4F");
            var callInfo = new CallerInfo
            { 
                CallerId = Guid.NewGuid(),
                CallerName = "Jonas f",
                CallerNumber = 98608900
            };
            var result = telephonyService.SendCallTo(agentId, callInfo);
            if (!result)
            {
                _bus.HandleCurrentMessageLater();
            }
            return;
        }
    }
}