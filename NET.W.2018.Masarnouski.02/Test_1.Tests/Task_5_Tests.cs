using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Masarnouski._02;

namespace NET.W._2018.Masarnouski._02.Tests
{
    [TestClass]
    public class Task_5_Tests
    {
        [TestMethod]
        public void FindNthRoot_Number1_Degree5_Precision0_0001_1returned()
        {
           double result = Task_5.FindNthRoot(1, 5, 0.0001);
            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void FindNthRoot_Number0_001_Degree3_Precision0_0001_returned0_1()
        {
            double result = Task_5.FindNthRoot(0.001, 3, 0.0001);
            Assert.AreEqual(result, 0.1);
        }
        [TestMethod]
        public void FindNthRoot_NumberNegative0_008_Degree3_Precision0_1_ReturnedNegative0_2()
        {
            double result = Task_5.FindNthRoot(-0.008, 3, 0.1);
            Assert.AreEqual(result, -0.22);
        }
    }
}
