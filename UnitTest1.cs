using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathCalculator1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMethod()
        {
           MathOperation bm = new MathOperation();
            double res = bm.Add(10, 10);
            Assert.AreEqual(res, 20);
        }
        [TestMethod]
        public void Test_SubtractMethod()
        {
            MathOperation bm = new MathOperation();
            double res = bm.Subtract(10, 10);
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void Test_MultiplyMethod()
        {
            MathOperation bm = new MathOperation();
            double res = bm.Multiply(10, 10);
            Assert.AreEqual(res, 100);
        }
        [TestMethod]
        public void Test_DivideMethod()
        {
            MathOperation bm = new MathOperation();
            double res = bm.Divide(10, 10);
            Assert.AreEqual(res, 1);
        }
    }
}
