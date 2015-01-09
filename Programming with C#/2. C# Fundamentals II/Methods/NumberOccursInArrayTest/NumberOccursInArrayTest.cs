using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberOccursInArrayTest
{
    [TestClass]
    public class NumberOccursInArrayTest
    {
        [TestMethod]
        public void SuccessfulTest1()
        {
            int[] array = { 1, 1, 1, 1, 1, 1, 1, 1 };
            int actual = NumberOccursInArray.CountNumber(array, number: 1);
            int expected = 8;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SuccessfulTest2()
        {
            int[] array = { 1, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, };
            int actual = NumberOccursInArray.CountNumber(array, number: 4);
            int expected = 6;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FailTest1()
        {
            int[] array = { 2, 2, 2, 2, 2, 2, 2 };
            int actual = NumberOccursInArray.CountNumber(array, number: 2);
            int expected = 6;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FailTest2()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int actual = NumberOccursInArray.CountNumber(array, number: 4);
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
    }
}
