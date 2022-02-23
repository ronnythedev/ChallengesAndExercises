using ADS.Arrays;
using NUnit.Framework;

namespace Tests.Arrays
{
    [TestFixture]
    public class MaxSubarrayTests
    {
        [Test]
        [TestCase(new [] {-2, 1, -3, 4, -1, 2, 1, -5, 4}, 6)]
        public void MaxSubarray_WhenCalled_ReturnTheSumOfTheMaxSubarray(int[] nums, int expectedResult)
        {
            var result = MaxSubarrayProblem.MaxSubarray(nums);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}