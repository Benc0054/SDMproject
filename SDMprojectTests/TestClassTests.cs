using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDMproject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMproject.Tests
{
    [TestClass()]
    public class TestClassTests
    {
        private readonly TestClass _testClass = new TestClass();

        [TestMethod()]
        public void TestMethodTest()
        {
            int result = _testClass.TestMethod();
            int expected = 0;
            Assert.AreEqual(result, expected);
        }
    }
}