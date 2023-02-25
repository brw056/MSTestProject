using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UnitTest1TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void UnitTest1TestMethod2()
        {
            Assert.AreEqual(2, 2);
        }

        [TestMethod]
        public void UnitTest1TestMethod3()
        {
            Assert.AreEqual(3, 3);
        }
    }
}
