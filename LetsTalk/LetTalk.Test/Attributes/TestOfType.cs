using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LetTalk.Test.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class TestOfType : TestCategoryBaseAttribute
    {
        public override IList<string> TestCategories { get; }

        public TestOfType(TestType testOfCategory)
        {
            TestCategories = new List<string>(1)
            {
                testOfCategory.ToString()
            }.AsReadOnly();
        }
    }
}