using System;

namespace ADS.Arrays
{
    public static class BinaryGapProblem
    {
        public static int BinaryGap(int n)
        {
            var nInBinary = Convert.ToString(n, 2);

            var longestGap = 0;
            var currentGapLength = 0;

            for (var i = 1; i < nInBinary.Length; i++)
            {
                if (nInBinary[i - 1] == '1' && nInBinary[i] == '0')
                {
                    currentGapLength = 1;
                }
                else if (nInBinary[i - 1] == '0' && nInBinary[i] == '0')
                {
                    currentGapLength++;
                }
                else if (nInBinary[i - 1] == '0' && nInBinary[i] == '1')
                {
                    longestGap = Math.Max(longestGap, currentGapLength);
                }
            }

            return longestGap;
        }
    }
}
