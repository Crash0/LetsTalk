using System.Collections.Generic;
using System.ComponentModel.Composition;
using LetsTalk.Authentication.Data.Contracts;
using LetsTalk.Business.Entities.Authentication;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.Core;

namespace LetsTalk.Authentication.Data.Tests.TestClasses
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

        public IEnumerable<UserAccount> GetUserAccounts()
        {
            var accountRepository
                = _dataRepositoryFactory.GetDataRepository<IAccountRepository>();

            var userAccounts = accountRepository.Get();

            return userAccounts;
        }
    }
}