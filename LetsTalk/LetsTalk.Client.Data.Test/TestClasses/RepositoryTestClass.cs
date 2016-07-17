using System.Collections.Generic;
using System.ComponentModel.Composition;
using LetsTalk.ClientService.Contracts;
using LetsTalk.Core.Common.Core;

namespace LetsTalk.Client.Data.Tests.TestClasses
{
    public class RepositoryTestClass
    {
        [Import]
        private IClientRepository _accountRepository;

        public RepositoryTestClass()
        {
            ObjectBase.Container.SatisfyImportsOnce(this);
        }

        public RepositoryTestClass(IClientRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public IEnumerable<Business.Entities.Client> GetAccounts()
        {
            var clients = _accountRepository.Get();
            return clients;
        }
    }
}