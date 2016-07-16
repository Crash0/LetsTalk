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
    public class BackendProgram
    {
        static void Main(string[] args)
        {
            var busconfig = BusConfigurator.CreateConfig(EndPoint.Backend);

            using (var bus = Bus.Create(busconfig).Start())
            {
                Console.WriteLine("Pressany button to start ping pong");
                Console.ReadKey();
                bus.Send(new Ping {PingPong = "Ping"});
                Console.ReadKey();
            }
        }
    }
}
