namespace LinearDataStruct.Test
{
    using System.Collections.Generic;
    using System.Linq;
    using _04.LongestEqualSubseq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LongestSubsequanceOfEqualsTests
    {
        [TestMethod]
        public void ShouldReturnLastLongestSubsequence()
        {
            var collection = new List<int> { 1, 1, 1, 3, 2, 2, 3, 3, 3 };
            var longestSubsequence = LongestSubsequanceOfEquals.FindLongestSubsequence(collection).ToList();
            var expectedLongestSubsequence = new List<int> { 3, 3, 3 };

            CollectionAssert.AreEqual(expectedLongestSubsequence, longestSubsequence);
        }

        [TestMethod]
        public void ShouldReturnLastLongestSubsequenceIsOneNumber()
        {
            var collection = new List<int> { 1, 2, 3, 4 };
            var longestSubsequence = LongestSubsequanceOfEquals.FindLongestSubsequence(collection).ToList();
            var expectedLongestSubsequence = new List<int>() { 4 };

            CollectionAssert.AreEqual(expectedLongestSubsequence, longestSubsequence);
        }

        [TestMethod]
        public void ShouldReturnLongestSubsequenceAtTheBeginning()
        {
            var collection = new List<int> { 1, 1, 1, 1, 1, 1, 2, 3, 3, 3 };
            var longestSubsequence = LongestSubsequanceOfEquals.FindLongestSubsequence(collection).ToList();
            var expectedLongestSubsequence = new List<int>() { 1, 1, 1, 1, 1, 1 };

            CollectionAssert.AreEqual(expectedLongestSubsequence, longestSubsequence);
        }

        [TestMethod]
        public void ShouldReturnOnlyOneSubsequenceAtTheEnd()
        {
            var collection = new List<int> { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };
            var longestSubsequence = LongestSubsequanceOfEquals.FindLongestSubsequence(collection).ToList();
            var expectedLongestSubsequence = new List<int>() { 4, 4, 4, 4 };

            CollectionAssert.AreEqual(expectedLongestSubsequence, longestSubsequence);
        }

        [TestMethod]
        public void ShouldReturnOnlyOneSubsequenceAtTheMiddle()
        {
            var collection = new List<int> { 1, 2, 2, 3, 3, 3, 3, 4, 4, 4 };
            var longestSubsequence = LongestSubsequanceOfEquals.FindLongestSubsequence(collection).ToList();
            var expectedLongestSubsequence = new List<int>() { 3, 3, 3, 3 };

            CollectionAssert.AreEqual(expectedLongestSubsequence, longestSubsequence);
        }
    }
}
