using ADS.SlidingWindow;
using NUnit.Framework;

namespace Tests.SlidingWindow
{
    public static class PermutationInStringSetTests
    {
        [TestFixture]
        public class PermutationInStringTests
        {
            [Test]
            [TestCase("adc", "dcda", true)]
            [TestCase("ab", "eidbaooo", true)]
            [TestCase("ab", "eidboaoo", false)]
            public void PermutationInString_WhenCalled_ReturnTrueIfPermutationIsPresent(string s1, string s2, bool expectedResult)
            {
                var result = PermutationInString.PermutationInStringSolution(s1, s2);

                Assert.That(result, Is.EqualTo(expectedResult));
            }
        }
    }
}