using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Core.Kernel;
using LetsTalk.Core.Kernel.Messages;
using NServiceBus;

namespace LetsTalk.Backend
{
    public class PingPongHandeler : IHandleMessages<Ping>
    {
        IBus _bus;
        
        public PingPongHandeler(IBus bus)
        {
            _bus = bus;
        }

        public void Handle(Ping message)
        {
            Console.WriteLine(message.PingPong);
            
        }
    }
}
