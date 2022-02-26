using System;
using System.Collections.Generic;

namespace ADS.SlidingWindow
{
    // Given an array of positive numbers and a positive number ‘k’,
    // find the maximum sum of any contiguous subarray of size ‘k’.
    public static class MaxSumOfSubArrayOfSizeK
    {
        public static int MaxSumOfSubArrayOfSizeKSolution(int k, int[] arr)
        {
            var lowerIndex = 0;
            var runningSum = 0;
            var maxSum = 0;

            for (var upperIndex = 0; upperIndex < arr.Length; upperIndex++)
            {
                runningSum += arr[upperIndex];

                if (upperIndex - lowerIndex + 1 == k)
                {
                    maxSum = Math.Max(maxSum, runningSum);
                    runningSum -= arr[lowerIndex];
                    lowerIndex++;
                }
            }

            return maxSum;
        }
    }
}