using ADS.SlidingWindow;
using NUnit.Framework;

namespace Tests.SlidingWindow
{
    public static class MaxNumberOfOnesWithReplacementSetTests
    {
        [TestFixture]
        public class MaxNumberOfOnesWithReplacementTests
        {
            [Test]
            [TestCase(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 }, 2, 6)]
            [TestCase(new[] { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 }, 3, 10)]
            public void MaxNumberOfOnesWithReplacement_WhenCalled_ReturnTheMaxNumberOfOnes(int[] nums, int k,
                int expectedResult)
            {
                var result = MaxNumberOfOnesWithReplacement.MaxNumberOfOnesWithReplacementSolution(nums, k);

                Assert.That(result, Is.EqualTo(expectedResult));
            }
        }
    }
}