using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;
using LetsTalk.Business.Contracts;
using LetTalk.Test;
using LetTalk.Test.Attributes;

namespace LetsTalk.Host.Azure.AzureWebService.Tests
{
    [TestClass]
    public class ServiceAccessTest
    {
        [TestMethod]
        [TestOfType(TestType.Integration)]
        public void test_SurveyService_manager_as_service()
        {
            ChannelFactory<ISurveyService> channelFactory =
                new ChannelFactory<ISurveyService>("");

            ISurveyService proxy = channelFactory.CreateChannel();

            var communicationObject = proxy as ICommunicationObject;
            if (communicationObject == null)
                    Assert.Fail("proxy as ICommunicationObject is null");

            communicationObject.Open();
            
            channelFactory.Close();
        }

        [TestMethod]
        [TestOfType(TestType.Integration)]
        public void test_Authentication_manager_as_service()
        {
            ChannelFactory<IAuthenticationService> channelFactory =
                new ChannelFactory<IAuthenticationService>("");

            IAuthenticationService proxy = channelFactory.CreateChannel();

            var communicationObject = proxy as ICommunicationObject;
            if (communicationObject == null)
                Assert.Fail("proxy as ICommunicationObject is null");

            communicationObject.Open();
            channelFactory.Close();
        }
    }
}
