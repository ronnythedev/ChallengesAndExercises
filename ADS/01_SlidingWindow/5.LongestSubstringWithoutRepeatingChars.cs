using System;
using System.Collections.Generic;

namespace ADS.SlidingWindow
{
    // Given a string s, find the length of the longest substring without repeating characters.
    public static class LongestSubstringWithoutRepeatingChars
    {
        public static int LongestSubstringWithoutRepeatingCharsSolution(string s)
        {
            var lookup = new Dictionary<char, int>();
            var lowerIndex = 0;
            var maxLen = 0;

            for (var upperIndex = 0; upperIndex < s.Length; upperIndex++)
            {
                var rightChar = s[upperIndex];

                if (lookup.ContainsKey(rightChar))
                {
                    // rightChar is already in the "window", then we can freely shrink the
                    // window up to the next index where this char is currently
                    lowerIndex = Math.Max(lowerIndex, lookup[rightChar] + 1);
                }

                lookup[rightChar] = upperIndex;
                maxLen = Math.Max(maxLen, upperIndex - lowerIndex + 1);
            }

            return maxLen;
        }
    }
}