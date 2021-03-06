﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Authentication.Data.Tests.TestClasses;
using LetsTalk.Business.Bootstrapper;
using LetsTalk.Core.Common.Core;
using LetTalk.Test;
using LetTalk.Test.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LetsTalk.Authentication.Data.Tests
{
    [TestClass]
    public class DataLayerIntegrationTests
    {
        [TestInitialize]
        public void Initialize()
        {
            ObjectBase.Container = MEFLoader.Init();
        }

        

        [TestMethod]
        [TestOfType(TestType.Integration)]
        public void test_repository_Usage_Integration()
        {
            var repositoryTestClass = new RepositoryTestClass();
            var accounts = repositoryTestClass.GetAccounts();
            Assert.IsTrue(accounts != null, "accounts is null");
        }

        [TestMethod]
        [TestOfType(TestType.Integration)]
        public void test_repositoryFactory_usage_Integration()
        {
            RepositoryFactoryTestClass repositoryFactoryTest = new RepositoryFactoryTestClass();
            var accounts = repositoryFactoryTest.GetUserAccounts();

            Assert.IsTrue(accounts != null, "Returned Accounts is null");
        }


    }
}
