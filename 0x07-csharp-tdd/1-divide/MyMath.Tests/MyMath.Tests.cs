using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void Divide_2by2Matrix()
        {
            int[,] testMatrix = new int[,] { { 12, 9 }, { 27, 18 } };
            int[,] output = Matrix.Divide(testMatrix, 3);

            Assert.AreEqual(new int[,] { { 4, 3 }, { 9, 6 } }, output);
        }

        [Test]
        public void Divide_A_PositiveNumber()
        {
            int[,] testMatrix = new int[,] { { 12, 9, 90 }, { 27, 18, 90 }, { 12, 27, 21 } };
            int[,] output = Matrix.Divide(testMatrix, 3);

            Assert.AreEqual(new int[,] { { 4, 3, 30 }, { 9, 6, 30 }, { 4, 9, 7 } }, output);
        }

        [Test]
        public void Divide_A_NullMatrix()
        {
            int[,] output = Matrix.Divide(null, 5);
            Assert.IsNull(output);
        }

        [Test]
        public void Divide_by_Zero()
        {
            int[,] testMatrix = new int[,] { { 12, 9, 90 }, { 27, 18, 90 }, { 12, 27, 21 } };
            int[,] output = Matrix.Divide(testMatrix, 0);
            Assert.IsNull(output);
        }
    }
}
