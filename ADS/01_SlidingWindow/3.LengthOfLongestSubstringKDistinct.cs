using System;
using System.Collections.Generic;

namespace ADS.SlidingWindow
{
    // Given a string s and an integer k, return the length of the longest substring of s
    // that contains at most k distinct characters.
    public static class LengthOfLongestSubstringKDistinct
    {
        public static int LengthOfLongestSubstringKDistinctSolution(string s, int k)
        {
            var lookup = new Dictionary<char, int>();
            var lowerIndex = 0;
            var maxLen = 0;

            for (var upperIndex = 0; upperIndex < s.Length; upperIndex++)
            {
                var rightChar = s[upperIndex];
                
                if (lookup.ContainsKey(rightChar))
                {
                    lookup[rightChar] += 1;
                }
                else
                {
                    lookup[rightChar] = 1;
                }

                while (lookup.Count > k)
                {
                    var leftChar = s[lowerIndex];

                    lookup[leftChar] -= 1;

                    if (lookup[leftChar] == 0)
                    {
                        lookup.Remove(leftChar);
                    }

                    lowerIndex++;
                }

                maxLen = Math.Max(maxLen, upperIndex - lowerIndex + 1);
            }

            return maxLen;
        }
    }
}