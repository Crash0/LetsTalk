using System;
using System.Collections.Generic;
using System.Linq;
using SM = System.ServiceModel;
using System.ServiceModel.Web;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Diagnostics;
using Microsoft.WindowsAzure.ServiceRuntime;
using LetsTalk.Business.Managers;
using LetsTalk.Core.Kernel;

namespace LetsTalkDataService
{
    public class WebRole : RoleEntryPoint
    {
        //private IStartableBus _bus;
        private List<SM.ServiceHost> _hosts;
        public override bool OnStart()
        {

            try
            {
                
                Console.WriteLine("Starting Services");
                StartService(typeof(AuthenticationManager));
                StartService(typeof(SurveyManager));
                StartSingletonService(new TelephonyManager());
                StartService(typeof(TargetingManager));
                Console.WriteLine("Services OK");

                Console.WriteLine("__________________________________________");

                //Console.WriteLine("Starting NServiceBus");
                //var busconfig = BusConfigurator.CreateConfig(EndPoint.WebService);
                //busconfig.RegisterComponents((components =>
                //{
                //    components.RegisterSingleton(typeof(IList<SM.ServiceHost>), _hosts);
                //}));
                //var bus = Bus.Create(busconfig);
                //bus.Start();
                Console.WriteLine("Bus Start OK");


                return true;

            }
            catch (Exception exception)
            {
                // Have you remembered : netsh http add urlacl url=http://+:80/MyUri user=DOMAIN\user
                // netsh http add urlacl url=http://+:8029/TargetingService.svc user=DESKTOP-0926VF9\JonasFjeld
                throw;
                return false;
            }
        }

        private void StartService(Type serviceMannager)
        {
            Console.WriteLine($"Started service of type {serviceMannager}");
            if (_hosts == null)
                _hosts = new List<SM.ServiceHost>();


            var host = new WebServiceHost(serviceMannager);
           
            host.Open();
            _hosts.Add(host);
        }

        private void StartSingletonService(ManagerBase serviceMannager)
        {
            Console.WriteLine($"Started singleton service of type {serviceMannager}");
            if (_hosts == null)
                _hosts = new List<SM.ServiceHost>();


            var host = new WebServiceHost(serviceMannager);


            host.Open();
            _hosts.Add(host);
        }

        public override void OnStop()
        {

            foreach (var serviceHost in _hosts)
            {
                serviceHost.Close();
            }
            
        }
    }
}
