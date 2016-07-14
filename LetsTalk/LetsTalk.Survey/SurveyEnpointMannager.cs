using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.Config.ConfigurationSource;

namespace LetsTalk.Surveys
{
    public class SurveyEnpointMannager : IDisposable
    {
        [Import]
        private IDataRepositoryFactory _dataRepositoryFactory;

        private IBus _serviceBus;

        private void Init()
        {
            InitializeNServiceBus();
            InitializeDependencyProperties();
            

        }

        private void InitializeNServiceBus()
        {
            var busconfig = new BusConfiguration();
            busconfig.EnableInstallers();
            busconfig.UsePersistence<InMemoryPersistence>();

            _serviceBus = Bus.Create(busconfig);
        }

        private void InitializeDependencyProperties()
        {
            ObjectBase.Container.SatisfyImportsOnce(this);
        }


        public static void Main(string[] args)
        {
            
            var program = new SurveyEnpointMannager();
            
            program.Init();

        }

        public void Dispose()
        {
            _serviceBus?.Dispose();
        }
    }
}
