using System.Collections.Generic;
using System.ComponentModel.Composition;
using LetsTalk.Authentication.Data.Contracts;
using LetsTalk.Business.Entities.Authentication;
using LetsTalk.Core.Common.Core;

namespace LetsTalk.Authentication.Data.Tests.TestClasses
{
    public class RepositoryTestClass
    {
        [Import]
        private IAccountRepository _accountRepository;

        public RepositoryTestClass()
        {
            ObjectBase.Container.SatisfyImportsOnce(this);
        }

        public RepositoryTestClass(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public IEnumerable<UserAccount> GetAccounts()
        {
            var accounts = _accountRepository.Get();
            return accounts;
        }
    }
}