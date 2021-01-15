using Challenges;
using NUnit.Framework;

namespace Tests
{
    public class BinaryGapTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(BinaryGapProblem.BinaryGap(9), 2);

            Assert.AreEqual(BinaryGapProblem.BinaryGap(529), 4);

            Assert.AreEqual(BinaryGapProblem.BinaryGap(20), 1);

            Assert.AreEqual(BinaryGapProblem.BinaryGap(15), 0);

            Assert.AreEqual(BinaryGapProblem.BinaryGap(32), 0);

            Assert.AreEqual(BinaryGapProblem.BinaryGap(1041), 5);
        }
    }
}