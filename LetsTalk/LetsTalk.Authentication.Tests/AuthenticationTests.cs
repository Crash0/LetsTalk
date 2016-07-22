using System;
using testNS = NServiceBus.Testing.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LetsTalk.Authentication;

namespace LetsTalk.Authentication.Tests
{
    [TestClass]
    public class AuthenticationTests
    {
        [TestInitialize]
        public void Initialize()
        {
            
        }

        [TestMethod]
        public void TestMethod1()
        {
            testNS.Initialize();
            //testNS.Handler<LogInRequestHandeler>(bus => bus );

        }
    }
}
