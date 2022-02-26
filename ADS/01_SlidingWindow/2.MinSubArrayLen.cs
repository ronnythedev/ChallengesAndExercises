using System;
using System.Collections.Generic;

namespace ADS.SlidingWindow
{
    // Given an array of positive integers nums and a positive integer target,
    // return the minimal length of a contiguous subarray [numsl, numsl+1, ..., numsr-1, numsr]
    // of which the sum is greater than or equal to target.
    //
    // If there is no such subarray, return 0 instead.
    public static class MinSubArrayLen
    {
        public static int MinSubArrayLenSolution(int target, int[] nums)
        {
            var minLen = nums.Length;
            var runningSum = 0;
            var totalSum = 0;
            var lowerIndex = 0;

            for (var upperIndex = 0; upperIndex < nums.Length; upperIndex++)
            {
                runningSum += nums[upperIndex];
                totalSum += nums[upperIndex];

                while (runningSum >= target)
                {
                    minLen = Math.Min(minLen, upperIndex - lowerIndex + 1);
                    
                    runningSum -= nums[lowerIndex];

                    lowerIndex++;
                }
            }

            return target > totalSum ? 0 : minLen;
        }
    }
}