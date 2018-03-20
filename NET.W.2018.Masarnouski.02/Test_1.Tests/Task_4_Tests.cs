using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Masarnouski._02;

namespace NET.W._2018.Masarnouski._02.Tests
{
    [TestClass]
    public class Task_4_Tests
    {
        [TestMethod]
        public void FilterDigit_WhenInputListOfPositiveInt_And7_ShouldReturnNumbersWith_7()
        {
            List<int> temp = new List<int>() { 3, 66, 87, 54, 23, 76, 87, 45, 75, 23, 7 };
           var result = Task_4.FilterDigit(temp,7);
            Assert.AreEqual(87, result[0]);
            Assert.AreEqual(76, result[1]);
            Assert.AreEqual(87, result[2]);
            Assert.AreEqual(75, result[3]);
            Assert.AreEqual(7, result[4]);
        }
        [TestMethod]
        public void FilterDigit_WhenInputListOfNegativeAndPositiveInt_And7_ShouldReturnNumbersWith_7()
        {
            List<int> temp = new List<int>() { 3, 66, -87, 54, 23, 76, -87, 45, 75, -23, 7 };
            var result = Task_4.FilterDigit(temp, 7);
            Assert.AreEqual(-87, result[0]);
            Assert.AreEqual(76, result[1]);
            Assert.AreEqual(-87, result[2]);
            Assert.AreEqual(75, result[3]);
            Assert.AreEqual(7, result[4]);
        }
        [TestMethod]
        public void FilterDigit_WhenInputListOfIntWithZero_And7_ShouldReturnNumbersWith_7()
        {
            List<int> temp = new List<int>() { 3, 66, 0, 54, 23, 76, 87, 0, 75, 23, 7 };
            var result = Task_4.FilterDigit(temp, 7);
            Assert.AreEqual(76, result[0]);
            Assert.AreEqual(87, result[1]);
            Assert.AreEqual(75, result[2]);
            Assert.AreEqual(7, result[3]);
        }
        [TestMethod]
        public void FilterDigit_WhenInputListOfLongAndShortInt_And7_ShouldReturnNumbersWith_7()
        {
            List<int> temp = new List<int>() { 387, 66692, 0, 541234, 233315, 767775, 877798, 0, 745455, 2324, 7896545 };
            var result = Task_4.FilterDigit(temp, 7);
            Assert.AreEqual(387, result[0]);
            Assert.AreEqual(767775, result[1]);
            Assert.AreEqual(877798, result[2]);
            Assert.AreEqual(745455, result[3]);
            Assert.AreEqual(7896545, result[4]);
        }
        [TestMethod]
        public void FilterDigit_WhenInputListOfLongAndShortAndZeroAndNegativeAndPositiveInt_And7_ShouldReturnNumbersWith_7()
        {
            List<int> temp = new List<int>() { 387, -66692, 0, 541234, 233315, -767775, 877798, 0, 745455, -2324, 7896545 };
            var result = Task_4.FilterDigit(temp, 7);
            Assert.AreEqual(387, result[0]);
            Assert.AreEqual(-767775, result[1]);
            Assert.AreEqual(877798, result[2]);
            Assert.AreEqual(745455, result[3]);
            Assert.AreEqual(7896545, result[4]);
        }
    }
}
