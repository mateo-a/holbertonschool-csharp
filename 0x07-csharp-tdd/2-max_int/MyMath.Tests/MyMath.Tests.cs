using System.Reflection;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void MaxValue_in_List()
        {
            List<int> input = new List<int> {17, 12, 25, 1, 0};
            int output = MyMath.Operations.Max(input);
            Assert.AreEqual(25, output);
        }

        [Test]
        public void MaxValue_With_SomeNegatives()
        {
            List<int> input = new List<int> {0, -8, 5, 17};
            int output = MyMath.Operations.Max(input);
            Assert.AreEqual(17, output);
        }

        [Test]
        public void MaxValue_of_ListNegatives()
        {
            List<int> input = new List<int> {-22, -8, -5, -17};
            int output = MyMath.Operations.Max(input);
            Assert.AreEqual(-5, output);
        }


    }
}
