using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using LetsTalk.Authentication.Data.Contracts;
using LetsTalk.Business.Bootstrapper;
using LetsTalk.Business.Entities.Authentication;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace LetsTalk.Authentication.Data.Tests
{
    [TestClass]
    public class DataLayerTests
    {
        [TestInitialize]
        public void Initialize()
        {
            ObjectBase.Container = MEFLoader.Init();
        }

        [TestMethod]
        public void test_repository_Usage_Integration()
        {
            var repositoryTestClass = new RepositoryTestClass();
            var accounts = repositoryTestClass.GetAccounts();
            Assert.IsTrue(accounts != null, "accounts is null");
        }

        [TestMethod]
        public void test_repository_Mocking()
        {
            var userAccounts = new List<UserAccount>
            {
                new UserAccount
                {
                    AccountId = Guid.Parse("3A557B7B-073F-4CCA-B834-CDA95850213E"),
                    CorrelationGuid = Guid.Parse("3A557B7B-073F-4CCA-B834-CDA95850213E"),
                    LoginEmail = "user1@user.com"
                },
                new UserAccount
                {
                    AccountId = Guid.Parse("07971F9F-14D8-4127-A5F8-D1B77DCBC218"),
                    CorrelationGuid = Guid.Parse("07971F9F-14D8-4127-A5F8-D1B77DCBC218"),
                    LoginEmail = "user2@user.com"
                }
            };

            var userAccountRepositoryMock = new Mock<IAccountRepository>();
            userAccountRepositoryMock.Setup(obj => obj.Get()).Returns(userAccounts);

            var repositoryTestClass = new RepositoryTestClass(userAccountRepositoryMock.Object);

            var result = repositoryTestClass.GetAccounts();

            Assert.IsTrue(Equals(userAccounts, result), "List from repository does not match the class passed into the mock");
        }

        [TestMethod]
        public void test_repositoryFactory_usage()
        {
           RepositoryFactoryTestClass repositoryFactoryTest = new RepositoryFactoryTestClass();
            var accounts = repositoryFactoryTest.GetUserAccounts();

            Assert.IsTrue(accounts != null,"Returned Accounts is null");
        }

        [TestMethod]
        public void test_repositoryFactory_mockUsage()
        {
            var userAccounts = new List<UserAccount>
            {
                new UserAccount
                {
                    AccountId = Guid.Parse("3A557B7B-073F-4CCA-B834-CDA95850213E"),
                    CorrelationGuid = Guid.Parse("3A557B7B-073F-4CCA-B834-CDA95850213E"),
                    LoginEmail = "user1@user.com"
                },
                new UserAccount
                {
                    AccountId = Guid.Parse("07971F9F-14D8-4127-A5F8-D1B77DCBC218"),
                    CorrelationGuid = Guid.Parse("07971F9F-14D8-4127-A5F8-D1B77DCBC218"),
                    LoginEmail = "user2@user.com"
                }
            };

            Mock<IDataRepositoryFactory> dataRepositoryMock = new Mock<IDataRepositoryFactory>();
            dataRepositoryMock.Setup(obj => obj.GetDataRepository<IAccountRepository>().Get()).Returns(userAccounts);

            RepositoryFactoryTestClass repositoryFactoryTest = new RepositoryFactoryTestClass(dataRepositoryMock.Object);
            var accounts = repositoryFactoryTest.GetUserAccounts();

            Assert.IsTrue(Equals(accounts, userAccounts));

        }


    }


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