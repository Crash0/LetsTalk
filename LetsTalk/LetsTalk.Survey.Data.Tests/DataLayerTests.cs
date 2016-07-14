using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using LetsTalk.Business.Bootstrapper;
using LetsTalk.Business.Entities.Surveys;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.Core;
using LetsTalk.Surveys.Data.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace LetsTalk.Surveys.Data.Tests
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
        public void test_repository_usage_integration()
        {
            var repositoryTestClass = new RepositoryTestClass();
            var surveys = repositoryTestClass.GetSurveys();

            Assert.IsTrue(surveys != null, "Account is null");
        }

        [TestMethod]
        public void test_Repository_mocUsage()
        {
            var surveys = new List<Survey>
            {
                new Survey
                {
                    Id = Guid.Parse("DCDB4463-7918-49CD-9C78-4421A6731FB4"),
                    Title = "Suver 1",
                    Description = "The first survey"
                },
                new Survey
                {
                    Id = Guid.Parse("3BA55396-C3C0-40CE-BD91-E069A928A21A"),
                    Title = "Suver 2",
                    Description = "The second survey"
                }
            };
            var surveyRepositoryMock = new Mock<ISurveyRepository>();
            surveyRepositoryMock.Setup(obj => obj.Get()).Returns(surveys);
            var repositoryTestClass = new RepositoryTestClass(surveyRepositoryMock.Object);
            var result = repositoryTestClass.GetSurveys();
            Assert.IsTrue(Equals(surveys,result),"List from repository does not match the class passed into the mock ");

        }

        [TestMethod]
        public void test_repositoryFactory_IntegrationUsage()
        {
            var rtc = new RepositoryFactoryTestClass();
            var surveys = rtc.GetSurveys();

            Assert.IsTrue(surveys != null, "Returned Surveys is null");
        }

        [TestMethod]
        public void test_repositoryFactory_MockUsage()
        {
            var surveys = new List<Survey>
            {
                new Survey
                {
                    Id = Guid.Parse("DCDB4463-7918-49CD-9C78-4421A6731FB4"),
                    Title = "Suver 1",
                    Description = "The first survey"
                },
                new Survey
                {
                    Id = Guid.Parse("3BA55396-C3C0-40CE-BD91-E069A928A21A"),
                    Title = "Suver 2",
                    Description = "The second survey"
                }
            };

            var dataRepositoryMock = new Mock<IDataRepositoryFactory>();
            dataRepositoryMock.Setup(obj => obj.GetDataRepository<ISurveyRepository>().Get()).Returns(surveys);

            var rftc = new RepositoryFactoryTestClass(dataRepositoryMock.Object);
            var result = rftc.GetSurveys();

            Assert.IsTrue(Equals(result, surveys), "List from repository does not match the class passed into the mock ");

        }
    }

    public class RepositoryTestClass
    {
        [Import] private ISurveyRepository _surveyRepository;


        public RepositoryTestClass()
        {
            ObjectBase.Container.SatisfyImportsOnce(this);
        }

        public RepositoryTestClass(ISurveyRepository surveyRepository)
        {
            _surveyRepository = surveyRepository;
        }

        public IEnumerable<Survey> GetSurveys()
        {
            var surveys = _surveyRepository.Get();
            return surveys;
        }
    }

    public class RepositoryFactoryTestClass
    {
        [Import] private IDataRepositoryFactory _dataRepositoryFactory;

        public RepositoryFactoryTestClass()
        {
            ObjectBase.Container.SatisfyImportsOnce(this);
        }

        public RepositoryFactoryTestClass(IDataRepositoryFactory dataRepositoryFactory)
        {
            _dataRepositoryFactory = dataRepositoryFactory;
        }

        public IEnumerable<Survey> GetSurveys()
        {
            var surveyRepository = _dataRepositoryFactory.GetDataRepository<ISurveyRepository>();
            var surveys = surveyRepository.Get();

            return surveys;
        }
    }
}