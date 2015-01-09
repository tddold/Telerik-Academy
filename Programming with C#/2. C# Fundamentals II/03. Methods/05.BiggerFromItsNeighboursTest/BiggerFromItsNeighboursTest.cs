using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class BiggerFromItsNeighboursTest
{
    [TestMethod]
    public void TestMethod1()
    {
        int[] array = { 1, 5, 1 };
        bool actual = BiggerFromItsNeighbours.BiggerThanItsNeghbours(array, position: 1);
        bool expected = true;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod2()
    {
        int[] array = { 1, 1, 5 };
        bool actual = BiggerFromItsNeighbours.BiggerThanItsNeghbours(array, position: 2);
        bool expected = true;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod3()
    {
        int[] array = { 5, 1, 1 };
        bool actual = BiggerFromItsNeighbours.BiggerThanItsNeghbours(array, position: 0);
        bool expected = true;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod4()
    {
        int[] array = { 5, 1, 5 };
        bool actual = BiggerFromItsNeighbours.BiggerThanItsNeghbours(array, position: 1);
        bool expected = false;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod5()
    {
        int[] array = { 1, 2, 3 };
        bool actual = BiggerFromItsNeighbours.BiggerThanItsNeghbours(array, position: 1);
        bool expected = false;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod6()
    {
        int[] array = { 1, 2, 3 };
        bool actual = BiggerFromItsNeighbours.BiggerThanItsNeghbours(array, position: 0);
        bool expected = false;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod7()
    {
        int[] array = { 1, 2, 3 };
        bool actual = BiggerFromItsNeighbours.BiggerThanItsNeghbours(array, position: 2);
        bool expected = true;

        Assert.AreEqual(expected, actual);
    }
}