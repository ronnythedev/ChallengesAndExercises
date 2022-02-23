namespace ADS.Arrays
{
    public static class MaxSubarrayProblem
    {
        public static int MaxSubarray(int[] nums)
        {
            var sum = 0;
            var maxSum = nums[0];

            foreach (var t in nums)
            {
                sum += t;
                if (t > sum)
                {
                    sum = t;
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }

            return maxSum;
        }
    }
}