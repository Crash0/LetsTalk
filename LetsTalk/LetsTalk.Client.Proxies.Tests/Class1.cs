using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetTalk.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LetTalk.Test.Attributes;

namespace LetsTalk.Client.Proxies.Tests
{
    [TestClass]
    public class ServiceAccessTests
    {

        [TestMethod]
        [TestOfType(TestType.Integration)]
        public void test_authentication_client_connection()
        {
            AuthenticationClient proxy = new AuthenticationClient();
            proxy.Open();
        }

        [TestMethod]
        [TestOfType(TestType.Integration)]
        public void test_Client_client_connection()
        {
            ClientClient proxy = new ClientClient();
            proxy.Open();

            var s = proxy.GetClients();

            Assert.IsTrue(s.Any());

        }
    }
}
