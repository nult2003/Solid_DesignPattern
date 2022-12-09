using NUnit.Framework;

namespace StudyTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string subStr = "nhat;;tri";
            var splits = subStr.Split(";");
            Assert.AreEqual(splits.Length, 3);
            Assert.AreEqual(splits.Length, 2);
        }

        [Test]
        public void UtilsTest()
        {

        }

    }
}