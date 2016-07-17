using System.Collections.Generic;
using System.ComponentModel.Composition;
using LetsTalk.ClientService.Contracts;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.Core;

namespace LetsTalk.Client.Data.Tests.TestClasses
{
    public class RepositoryFactoryTestClass
    {
        public RepositoryFactoryTestClass()
        {
            ObjectBase.Container.SatisfyImportsOnce(this);
        }

        [Import]
        private IDataRepositoryFactory _dataRepositoryFactory;

        public RepositoryFactoryTestClass(IDataRepositoryFactory dataRepositoryFactory)
        {
            _dataRepositoryFactory = dataRepositoryFactory;
        }

        public IEnumerable<Business.Entities.Client> GetClients()
        {
            var repository
                = _dataRepositoryFactory.GetDataRepository<IClientRepository>();

            var clients = repository.Get();

            return clients;
        }
    }
}