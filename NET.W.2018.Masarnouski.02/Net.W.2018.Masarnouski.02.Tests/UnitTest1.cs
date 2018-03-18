using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Masarnouski._02;
namespace Net.W._2018.Masarnouski._02.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void numberSourse8_numberIn15_start3_end8_120returned()
        {
           int result = Task_1.InsertNumber(8, 15, 3, 8);
            Assert.AreEqual(120, result);
        }

        [TestMethod]
        public void numberSourse8_numberIn15_start_negative3_end8_exception_returned()
        {
            Exception exception = null;
            try
            {
                int result = Task_1.InsertNumber(8, 15, -3, 8);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
        [TestMethod]
        public void numberSourse8_numberIn15_start3_end_negative8_exception_returned()
        {
            Exception exception = null;
            try
            {
                int result = Task_1.InsertNumber(8, 15, 3, -8);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
        [TestMethod]
        public void start10_is_bigger_then_end8_exception_returned()
        {
            Exception exception = null;
            try
            {
                int result = Task_1.InsertNumber(8, 15, 10, 8);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
    }
}
