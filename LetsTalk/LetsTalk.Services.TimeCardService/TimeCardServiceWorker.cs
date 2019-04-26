using System.Threading.Tasks;
using Akka.Actor;
using Akka.Bootstrap.Docker;
using Akka.Event;
using LetsTalk.Core.Common.Utils;

namespace LetsTalk.Services.TimeCardService
{
    internal class TimeCardServiceWorker
    {
        protected ActorSystem ClusterSystem;

        public Task WhenTerminated => ClusterSystem.WhenTerminated;


        public bool Start()
        {
            var config = HoconLoader.ParseConfig("timecardserviceconfig.hocon");
            ClusterSystem = ActorSystem.Create("LetsTalk-system", config.BootstrapFromDocker());
            CreateActors();
            return true;
        }

        private void CreateActors()
        {
            ClusterSystem.ActorOf(Props.Create(typeof(TimeTeller)));
        }

        public Task Stop()
        {
            return CoordinatedShutdown.Get(ClusterSystem).Run(CoordinatedShutdown.ClrExitReason.Instance);
        }
    }

    internal class TimeTeller: ReceiveActor
    {
        private readonly ILoggingAdapter log = Context.GetLogger();

        public TimeTeller()
        {
            Receive<string>(message => {
                log.Info("Received String message: {0}", message);
                Sender.Tell(message);
            });
            //Receive<TimeRequesMessage>(message => {...});
        }
    }
}