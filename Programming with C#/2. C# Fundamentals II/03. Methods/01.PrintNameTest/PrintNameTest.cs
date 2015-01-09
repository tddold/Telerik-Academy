using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class PrintNameTest
{
    [TestMethod]
    public void SuccessfulTest1()
    {
        string actual = PrintName.RegardstName("Ivan");
        string expected = "Hello. Ivan!";

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SuccessfulTest2()
    {
        string actual = PrintName.RegardstName("Peter");
        string expected = "Hello. Peter!";

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FailTest1()
    {
        string actual = PrintName.RegardstName("Ivan");
        string expected = "Peter is not Ivan!";

        Assert.AreEqual(expected, actual);
    }
}