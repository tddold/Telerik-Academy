using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var expectedMatrix = new int[n,n];
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
                {1 }
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
                    if (expectedMatrix[i,j] != actualMatrix[i,j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
