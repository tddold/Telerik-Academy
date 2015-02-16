using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class AppearanceCountTest
{
    [TestMethod]
    public void TestMethod1()
    {
        int[] array = { 1, 1, 1, 1, 1 };
        int actual = AppearanceCount.CountNumberInArray(array, number: 1);
        int expected = 5;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod2()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int actual = AppearanceCount.CountNumberInArray(array, number: 3);
        int expected = 2;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod3()
    {
        int[] array = { 1, 1, 1, 1, 1 };
        int actual = AppearanceCount.CountNumberInArray(array, number: 1);
        int expected = 4;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod4()
    {
        int[] array = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };
        int actual = AppearanceCount.CountNumberInArray(array, number: 4);
        int expected = 4;

        Assert.AreEqual(expected, actual);
    }
}