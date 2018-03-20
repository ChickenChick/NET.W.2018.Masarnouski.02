using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Masarnouski._02;

namespace NET.W._2018.Masarnouski._02.Tests
{
    [TestClass]
    public class Task_2_Tests
    {
        [TestMethod]
        public void FindNextBiggerNumber_input12_21returned()
        {
           int result = Task_2_3.FindNextBiggerNumber(12);
            Assert.AreEqual(result, 21);
        }
        [TestMethod]
        public void FindNextBiggerNumber_input513_531returned()
        {
            int result = Task_2_3.FindNextBiggerNumber(513);
            Assert.AreEqual(result, 531);
        }
        [TestMethod]
        public void FindNextBiggerNumber_input2017_2071returned()
        {
            int result = Task_2_3.FindNextBiggerNumber(2017);
            Assert.AreEqual(result, 2071);
        }
        [TestMethod]
        public void FindNextBiggerNumber_input10_negative_1returned()
        {
            int result = Task_2_3.FindNextBiggerNumber(10);
            Assert.AreEqual(result, -1);
        }
        [TestMethod]
        public void FindNextBiggerNumber_input8_negative_1returned()
        {
            int result = Task_2_3.FindNextBiggerNumber(8);
            Assert.AreEqual(result, -1);
        }
        [TestMethod]
        public void FindNextBiggerNumber_input1234321_1241233returned()
        {
            int result = Task_2_3.FindNextBiggerNumber(1234321);
            Assert.AreEqual(result, 1241233);
        }
        [TestMethod]
        public void FindNextBiggerNumber_input3456432_3462345returned()
        {
            int result = Task_2_3.FindNextBiggerNumber(3456432);
            Assert.AreEqual(result, 3462345);
        }
    }
}
