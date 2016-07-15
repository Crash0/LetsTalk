using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LetTalk.Test
{
    [TestClass]
    public class TestAssemblyTests
    {
        [TestMethod]
        public void UsingTestTypeEnum_Description_ShouldReturnEnumName()
        {
            Assert.IsTrue(TestType.Integration.ToString() == "Integration");

        }
    }
}
