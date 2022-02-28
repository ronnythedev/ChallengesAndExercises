using ADS.SlidingWindow;
using NUnit.Framework;

namespace Tests.SlidingWindow
{
    public static class LongestRepeatingCharWithReplacementSetTests
    {
        [TestFixture]
        public class LongestRepeatingCharWithReplacementTests
        {
            [Test]
            [TestCase("ABAB", 2,4)]
            [TestCase("AABABBA", 1,4)]
            public void LongestRepeatingCharWithReplacement_WhenCalled_ReturnLongestRepeatingChar(string s, int k, int expectedResult)
            {
                var result = LongestRepeatingCharWithReplacement.LongestRepeatingCharWithReplacementSolution(s, k);

                Assert.That(result, Is.EqualTo(expectedResult));
            }
        }
    }
}