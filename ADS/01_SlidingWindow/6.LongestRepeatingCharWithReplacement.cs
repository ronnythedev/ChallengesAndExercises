using System;
using System.Collections.Generic;

namespace ADS.SlidingWindow
{
    // You are given a string s and an integer k.
    // You can choose any character of the string and change it to any other uppercase English character.
    // You can perform this operation at most k times.

    // Return the length of the longest substring containing the same letter you can get after
    // performing the above operations.
    public static class LongestRepeatingCharWithReplacement
    {
        public static int LongestRepeatingCharWithReplacementSolution(string s, int k)
        {
            var lowerIndex = 0;
            var maxLen = 0;
            var maxRepeatedCharCounter = 0;
            var lookup = new Dictionary<char, int>();

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

                maxRepeatedCharCounter = Math.Max(maxRepeatedCharCounter, lookup[rightChar]);

                var currentLen = (upperIndex - lowerIndex + 1);

                // The current length of the window, minus the max number of repeated chars in that window
                // will provide the number of "left" chars that can be replaced.
                // If the result of that computing is greater than k, we can shrink the window.
                if (currentLen - maxRepeatedCharCounter > k)
                {
                    var leftChar = s[lowerIndex];
                    lookup[leftChar] -= 1;
                    lowerIndex++;
                }

                // Finally, select the max length between the current value of maxLen
                // and the current length of the window (after shrinking)
                maxLen = Math.Max(maxLen, (upperIndex - lowerIndex + 1));
            }

            return maxLen;
        }
    }
}