using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Masarnouski._02;

namespace NET.W._2018.Masarnouski._02.Tests
{
    [TestClass]
    public class Task_1_Tests
    {

        [TestMethod]
        public void InsertNumber_numberSourse8_numberIn15_start3_end8_120returned()
        {
            int result = Task_1.InsertNumber(8, 15, 3, 8);
            Assert.AreEqual(120, result);
        }
        [TestMethod]
        public void InsertNumber_numberSourse8_numberIn15_start0_end0_120returned()
        {
            int result = Task_1.InsertNumber(8, 15, 0, 0);
            Assert.AreEqual(9, result);
        }
        [TestMethod]
        public void InsertNumber_numberSourse8_numberIn15_start_negative3_end8_exception_returned()
        {
            Assert.ThrowsException<ArgumentException>(()=>Task_1.InsertNumber(8, 15, -3, 8));
        }

        [TestMethod]
        public void InsertNumber_numberSourse8_numberIn15_start3_end_negative8_exception_returned()
        {
            Assert.ThrowsException<ArgumentException>(()=>Task_1.InsertNumber(8, 15, 3, -8));
        }

        [TestMethod]
        public void InsertNumber_start10_is_bigger_then_end8_exception_returned()
        {
            Assert.ThrowsException<ArgumentException>(() => Task_1.InsertNumber(8, 15, 10, 8));
        }
    }
}

