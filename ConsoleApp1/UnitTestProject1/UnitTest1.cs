using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsTrue()
        {
            Test1 test1 = new Test1();
            Assert.IsTrue(test1.isTrue);
        }

        [TestMethod]
        public void TestIsFalse()
        {
            Test1 test1 = new Test1();
            Assert.IsFalse(test1.isTrue);
        }
    }
}
