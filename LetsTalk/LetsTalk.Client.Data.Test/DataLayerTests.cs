using System;
using System.Collections.Generic;
using LetsTalk.Business.Bootstrapper;
using LetsTalk.Business.Entities.Authentication;
using LetsTalk.Client.Data.Tests.TestClasses;
using LetsTalk.ClientService.Contracts;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace LetsTalk.Client.Data.Tests
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
        public void test_repository_Mocking()
        {
            var userAccounts = new List<Business.Entities.Client.Client>
            {
                new Business.Entities.Client.Client
                {
                    ClientId = Guid.Parse("3A557B7B-073F-4CCA-B834-CDA95850213E"),
                    CorrelationGuid = Guid.Parse("3A557B7B-073F-4CCA-B834-CDA95850213E"),
                    Email = "user1@user.com"
                },
                new Business.Entities.Client.Client
                {
                    ClientId = Guid.Parse("07971F9F-14D8-4127-A5F8-D1B77DCBC218"),
                    CorrelationGuid = Guid.Parse("07971F9F-14D8-4127-A5F8-D1B77DCBC218"),
                    Email = "user2@user.com"
                }
            };

            var repositoryMock = new Mock<IClientRepository>();
            repositoryMock.Setup(obj => obj.Get()).Returns(userAccounts);

            var repositoryTestClass = new RepositoryTestClass(repositoryMock.Object);

            var result = repositoryTestClass.GetAccounts();

            Assert.IsTrue(Equals(userAccounts, result), "List from repository does not match the class passed into the mock");
        }

        
        [TestMethod]
        public void test_repositoryFactory_mockUsage()
        {
            var value = new List<Business.Entities.Client.Client>
            {
                new Business.Entities.Client.Client()
                {
                    ClientId = Guid.Parse("3A557B7B-073F-4CCA-B834-CDA95850213E"),
                    CorrelationGuid = Guid.Parse("3A557B7B-073F-4CCA-B834-CDA95850213E"),
                    Email = "user1@user.com"
                },
                new Business.Entities.Client.Client()
                {
                    ClientId = Guid.Parse("07971F9F-14D8-4127-A5F8-D1B77DCBC218"),
                    CorrelationGuid = Guid.Parse("07971F9F-14D8-4127-A5F8-D1B77DCBC218"),
                    Email = "user2@user.com"
                }
            };

            Mock<IDataRepositoryFactory> dataRepositoryMock = new Mock<IDataRepositoryFactory>();
            dataRepositoryMock.Setup(obj => obj.GetDataRepository<IClientRepository>().Get()).Returns(value);

            RepositoryFactoryTestClass repositoryFactoryTest = new RepositoryFactoryTestClass(dataRepositoryMock.Object);
            var enumerable = repositoryFactoryTest.GetClients();

            Assert.IsTrue(Equals(enumerable, value));

        }


    }
}