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
        private IDataRepositoryFactory _dataRepositoryFactory;

        private IStartableBus _serviceBus;

        private void Init()
        {
            InitializeNServiceBus();
            InitializeDependencyProperties();
            

        }

        private void InitializeNServiceBus()
        {
            var busconfig = BusConfigurator.CreateConfig(EndPoint.SurveyService);
            _serviceBus = Bus.Create(busconfig);
            _serviceBus.Start();
        }

        private void InitializeDependencyProperties()
        {
            ObjectBase.Container = Bootstrapper.Init();
            ObjectBase.Container.SatisfyImportsOnce(this);
        }


        public static void Main(string[] args)
        {
            
            var program = new SurveyEnpointMannager();
            
            program.Init();

            Console.ReadKey();

        }

        public void Dispose()
        {
            _serviceBus?.Dispose();
        }
    }
}
