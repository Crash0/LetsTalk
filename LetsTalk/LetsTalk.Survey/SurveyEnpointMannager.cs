using System;
using System.ComponentModel.Composition;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.Core;
using LetsTalk.Core.Kernel;
using NServiceBus;

namespace LetsTalk.Services.SurveyService
{
    public class SurveyEnpointMannager : IDisposable
    {
        [Import]
        private IDataRepositoryFactory dataRepositoryFactory;

        private IStartableBus serviceBus;
        
        public static void Main(string[] args)
        {
            
            var program = new SurveyEnpointMannager();
            
            program.Init();

            Console.ReadKey();

        }

        public void Dispose()
        {
            this.serviceBus?.Dispose();
        }
        
        private void Init()
        {
            this.InitializeNServiceBus();
            this.InitializeDependencyProperties();

        }

        private void InitializeNServiceBus()
        {
            var busconfig = BusConfigurator.CreateConfig(EndPoint.SurveyService);
            this.serviceBus = Bus.Create(busconfig);
            this.serviceBus.Start();
        }

        private void InitializeDependencyProperties()
        {
            ObjectBase.Container = Bootstrapper.Init();
            ObjectBase.Container.SatisfyImportsOnce(this);
        }

    }
}
