using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class FirstBiggerThanNeighboursTest
{
    [TestMethod]
    public void TestMethod1()
    {
        int[] array = { 1, 5, 1 };
        int actual = FirstBiggerThanNeighbours.FindFirstBiggerThanNeighours(array);
        int expected = 1;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod2()
    {
        int[] array = { 1, 1, 5 };
        int actual = FirstBiggerThanNeighbours.FindFirstBiggerThanNeighours(array);
        int expected = 2;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod3()
    {
        int[] array = { 5, 1, 1 };
        int actual = FirstBiggerThanNeighbours.FindFirstBiggerThanNeighours(array);
        int expected = 0;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod4()
    {
        int[] array = { 1, 1, 1 };
        int actual = FirstBiggerThanNeighbours.FindFirstBiggerThanNeighours(array);
        int expected = -1;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod5()
    {
        int[] array = { 1, 2, 3 };
        int actual = FirstBiggerThanNeighbours.FindFirstBiggerThanNeighours(array);
        int expected = 2;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod6()
    {
        int[] array = { 1, 2, 1, 3 };
        int actual = FirstBiggerThanNeighbours.FindFirstBiggerThanNeighours(array);
        int expected = 1;

        Assert.AreEqual(expected, actual);
    }
}