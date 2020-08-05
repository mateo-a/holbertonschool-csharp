using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("ras", 1)]
        [TestCase("theMall", 2)]
        [TestCase("areYouOk", 3)]
        [TestCase("", 0)]
        [TestCase("bar*p_", 1)]
        [TestCase("eraBrea_.", 2)]
        [TestCase(null, 0)]
        public void CamelCase_NormalString_ReturnsNumberOfWords(string s, int expected)
        {
            int res = Text.Str.CamelCase(s);

            Assert.AreEqual(expected, res);
        }
    }
}
