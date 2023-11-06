using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sample.Test
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void TestAddPositives()
        {
            var result = Sample.Utility.Math.Add(4, 3);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestAddZeros()
        {
            var result = Sample.Utility.Math.Add(0, 0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestAddPositiveNegative()
        {
            var result = Sample.Utility.Math.Add(5, -3);
            Assert.AreEqual(2, result);
        }
        
        [TestMethod]
        public void TestAddNegatives()
        {
            var result = Sample.Utility.Math.Add(-5, -3);
            Assert.AreEqual(-8, result);
        }

        [TestMethod]
        public void TestIntOverflow()
        {
            var result = Sample.Utility.Math.Add(int.MaxValue, int.MaxValue);
            Assert.AreEqual(4294967294, result);
        }
    }
}
