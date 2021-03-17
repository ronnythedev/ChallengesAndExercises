using System;

namespace Challenges
{
    public class BinaryGapProblem
    {
        public static int BinaryGap(int n)
        {
            string nInBinary = Convert.ToString(n, 2);

            int longestGap = 0;
            int currentGapLength = 0;

            for (int i = 1; i < nInBinary.Length; i++)
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
