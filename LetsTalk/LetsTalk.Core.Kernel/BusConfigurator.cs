using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace LetsTalk.Core.Kernel
{
    public static class BusConfigurator
    {
        public static  BusConfiguration CreateConfig(EndPoint endpoint)
        {
            var bussconfig = new BusConfiguration();
            bussconfig.UseSerialization<JsonSerializer>();
            bussconfig.UseTransport<RabbitMQTransport>();
            bussconfig.UsePersistence<InMemoryPersistence>();
            bussconfig.EndpointName(endpoint.ToString());
            

            var conventionsBuilder = bussconfig.Conventions();

            conventionsBuilder.DefiningCommandsAs(
                t => t.Namespace != null &&
                     (t.Namespace == "LetsTalk.Core.Kernel.Messages"
                     ));
            bussconfig.EnableInstallers();
            return bussconfig;
        }
    }
}
