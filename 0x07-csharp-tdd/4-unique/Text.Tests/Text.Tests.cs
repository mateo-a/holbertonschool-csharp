using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("affggrree", 0)]
        [TestCase("sssvbbbb", 3)]
        [TestCase("masomas", 3)]
        public void TestUniqueChar_WithAssert(string s, int expected)
        {
            int res = Text.Str.UniqueChar(s);

            Assert.AreEqual(expected, res);
        }

        [TestCase("")]
        [TestCase(null)]
        [TestCase("cccrrrr")]
        public void TestUniquChar_WithoutAssert(string s)
        {
            int res = Text.Str.UniqueChar(s);

            Assert.AreEqual(-1, res);
        }
    }
}
