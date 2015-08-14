namespace RotatingWallkInMatrix.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using RotatingWalkInMatrix;

    [TestClass]
    public class RotatingWallkInMatrixTests
    {
        [TestMethod]
        [Timeout(100)]
        public void CreateMatrixByZeroSizeTest()
        {
            byte n = 0;
            var expectedMatrix = new int[n, n];
            var actualMatrix = Matrix.GenerrateMatrix(n);

            var areMatrixesEquale = this.AreMatrixEqual(expectedMatrix, actualMatrix);
            Assert.IsTrue(areMatrixesEquale);
        }

        [TestMethod]
        [Timeout(100)]
        public void CreateMatrixBySizeEqualOneTest()
        {
            byte n = 1;
            var expectedMatrix = new int[,]
            {
                { 1 }
            };

            var actualMatrix = Matrix.GenerrateMatrix(n);

            var areMatrixesEqual = this.AreMatrixEqual(expectedMatrix, actualMatrix);
            Assert.IsTrue(areMatrixesEqual);
        }

        [TestMethod]
        [Timeout(100)]
        public void CreateMatrixBySizeEqualTwoTest()
        {
            byte n = 2;
            var expectedMatrix = new int[,]
            {
                { 1, 4 },
                { 3, 2 }
            };

            var actualMatrix = Matrix.GenerrateMatrix(n);

            var areMatrixesEqual = this.AreMatrixEqual(expectedMatrix, actualMatrix);
            Assert.IsTrue(areMatrixesEqual);
        }

        [TestMethod]
        [Timeout(100)]
        public void CreateMatrixBySizeEqualThreeTest()
        {
            byte n = 3;
            var expectedMatrix = new int[,]
            {
                { 1, 7, 8 },
                { 6, 2, 9 },
                { 5, 4, 3 }
            };

            var actualMatrix = Matrix.GenerrateMatrix(n);

            var areMatrixesEqual = this.AreMatrixEqual(expectedMatrix, actualMatrix);
            Assert.IsTrue(areMatrixesEqual);
        }

        [TestMethod]
        [Timeout(100)]
        public void CreateMatrixBySizeEqualSixTest()
        {
            byte n = 6;
            var expectedMatrix = new int[,]
            {
                { 1, 16, 17, 18, 19, 20 },
                { 15, 2, 27, 28, 29, 21 },
                { 14, 31, 3, 26, 30, 22 },
                { 13, 36, 32, 4, 25, 23 },
                { 12, 35, 34, 33, 5, 24 },
                { 11, 10, 9, 8, 7, 6 }
            };

            var actualMatrix = Matrix.GenerrateMatrix(n);

            var areMatrixesEqual = this.AreMatrixEqual(expectedMatrix, actualMatrix);
            Assert.IsTrue(areMatrixesEqual);
        }

        private bool AreMatrixEqual(int[,] expectedMatrix, int[,] actualMatrix)
        {
            for (int i = 0; i < expectedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < expectedMatrix.GetLength(1); j++)
                {
                    if (expectedMatrix[i, j] != actualMatrix[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
