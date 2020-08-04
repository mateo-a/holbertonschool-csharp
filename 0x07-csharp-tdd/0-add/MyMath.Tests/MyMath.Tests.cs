using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {       
        [TestCase(2, 5)]
        [TestCase(1, 9)]
        [TestCase(45, 2)]
        public void Add_Two_Numbers_GreathersThanZero_ReturnSum_a_b(int a, int b)
        {
            int res = Operations.Add(a, b);
            Assert.AreEqual(res, a + b);
        }
        
        [TestCase(-3, 5)]
        [TestCase(-1, -9)]
        [TestCase(45, -2)]
        public void Add_Two_Numbers_LessThanZero_ReturnSum_a_b(int a, int b)
        {
            int res = Operations.Add(a, b);
            Assert.AreEqual(res, a + b);
        }
    }
}
