using System;
using System.Collections.Generic;
using System.Reflection;
using nsTest = NServiceBus.Testing.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LetsTalk.Core.Common.Bus.Test
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            nsTest.Initialize();
            
        }
    }


}
