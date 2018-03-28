using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello;
namespace HelloTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int i = 5;
            Assert.AreEqual("Hello Mahesh", Program.createMessage());
        }
    }
}
