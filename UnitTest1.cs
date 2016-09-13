using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanToIntConversionTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRomanToInt1()
        {
            RomanToInt rToInt = new RomanToInt();
            int result = rToInt.Convert("MMXVI");
            Assert.AreEqual(2016, result);
        }
    }
}
