using ADS.SlidingWindow;
using NUnit.Framework;

namespace Tests.SlidingWindow
{
    public static class MinSubArrayLenSetTests
    {
        [TestFixture]
        public class MinSubArrayLenTests
        {
            [Test]
            [TestCase(7, new[] { 2, 3, 1, 2, 4, 3 }, 2)]
            [TestCase(4, new[] { 1, 4, 4 }, 1)]
            [TestCase(11, new[] { 1, 1, 1, 1, 1, 1, 1, 1 }, 0)]
            public void MinSubArrayLen_WhenCalled_ReturnTheMinSubArrayWhichSumIsGreaterOrEqualTarget(int target,
                int[] nums, int expectedResult)
            {
                var result = MinSubArrayLen.MinSubArrayLenSolution(target, nums);

                Assert.That(result, Is.EqualTo(expectedResult));
            }
        }
    }
}