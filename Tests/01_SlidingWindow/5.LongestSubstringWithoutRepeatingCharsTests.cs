using ADS.SlidingWindow;
using NUnit.Framework;

namespace Tests.SlidingWindow
{
    public static class LongestSubstringWithoutRepeatingCharsSetTests
    {
        [TestFixture]
        public class LongestSubstringWithoutRepeatingCharsTests
        {
            [Test]
            [TestCase("abcabcbb", 3)]
            [TestCase("bbbbb", 1)]
            [TestCase("pwwkew", 3)]
            [TestCase("aabccbb", 3)]
            [TestCase("abbbb", 2)]
            [TestCase("abccde", 3)]
            [TestCase(" ", 1)]
            [TestCase("au", 2)]
            public void LongestSubstring_WhenCalled_ReturnMaxSubstringWithoutRepeatingChars(string s, int expectedResult)
            {
                var result = LongestSubstringWithoutRepeatingChars.LongestSubstringWithoutRepeatingCharsSolution(s);

                Assert.That(result, Is.EqualTo(expectedResult));
            }
        }
    }
}