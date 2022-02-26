using ADS.SlidingWindow;
using NUnit.Framework;

namespace Tests.SlidingWindow
{
    public static class LengthOfLongestSubstringKDistinctSetTests
    {
        [TestFixture]
        public class LengthOfLongestSubstringKDistinctTests
        {
            [Test]
            [TestCase("eceba",2,3)]
            [TestCase("aa",1,2)]
            public void LengthOfLongestSubstringKDistinct_WhenCalled_ReturnTheLongestSubstring(string s, int k, int expectedResult)
            {
                var result = LengthOfLongestSubstringKDistinct.LengthOfLongestSubstringKDistinctSolution(s, k);

                Assert.That(result, Is.EqualTo(expectedResult));
            }
        }
    }
}