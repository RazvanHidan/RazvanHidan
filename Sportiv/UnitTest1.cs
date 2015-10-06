using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sportiv
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(repetari(3), 9);
            Assert.AreEqual(repetari(10), 100);
            Assert.AreEqual(repetari(4), 16);
        }
        int repetari(int n)
        {
            return n * n;
        }
    }
}
