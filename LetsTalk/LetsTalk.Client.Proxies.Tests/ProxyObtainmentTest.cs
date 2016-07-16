using System;
using LetsTalk.Client.Bootstrapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LetsTalk.Core.Common.Core;

using LetsTalk.Core.Common.Contracts;
using LetsTalk.Client.Contracts;

namespace LetsTalk.Client.Proxies.Tests
{
    [TestClass]
    public class ProxyObtainmentTest
    {
        [TestInitialize]
        public void Initialize()
        {
            ObjectBase.Container = MEFLoader.Init();
        }
        [TestMethod]
        public void Obtain_proxy_from_container_using_service_contract()
        {
            IAuthenticationService proxy =
                ObjectBase.Container.GetExportedValue<IAuthenticationService>();

           
        }

        [TestMethod]
        public void obtain_proxy_from_service_factory()
        {
            IServiceFactory factory = new ServiceFactory();
            IAuthenticationService proxy = factory.CreateClient<IAuthenticationService>();

            Assert.IsTrue(proxy is AuthenticationClient);
        }

        [TestMethod]
        public void obtain_service_factory_and_procy_from_container()
        {
            IServiceFactory factory = ObjectBase.Container.GetExportedValue<IServiceFactory>();
            IAuthenticationService proxy = factory.CreateClient<IAuthenticationService>();

            Assert.IsTrue(proxy is AuthenticationClient);

        }

    }
}
