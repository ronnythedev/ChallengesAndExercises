using System;
using System.Collections.Generic;

namespace ADS.SlidingWindow
{
    // Given an array containing 0s and 1s, if you are allowed to replace no more than ‘k’ 0s with 1s,
    // find the length of the longest contiguous subarray having all 1s.
    public static class MaxNumberOfOnesWithReplacement
    {
        public static int MaxNumberOfOnesWithReplacementSolution(int[] nums, int k)
        {
            var maxNumberOfOnes = 0;
            var lowerIndex = 0;
            var maxLen = 0;

            for (var upperIndex = 0; upperIndex < nums.Length; upperIndex++)
            {
                if (nums[upperIndex] == 1)
                {
                    maxNumberOfOnes++;
                }

                if (upperIndex - lowerIndex + 1 - maxNumberOfOnes > k)
                {
                    if (nums[lowerIndex] == 1)
                    {
                        maxNumberOfOnes--;
                    }

                    lowerIndex++;
                }

                maxLen = Math.Max(maxLen, upperIndex - lowerIndex + 1);
            }

            return maxLen;
        }
    }
}