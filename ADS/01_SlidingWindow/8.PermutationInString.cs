using System;
using System.Collections.Generic;

namespace ADS.SlidingWindow
{
    // Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.
    // In other words, return true if one of s1's permutations is the substring of s2.
    public static class PermutationInString
    {
        public static bool PermutationInStringSolution(string s1, string s2)
        {
            var lowerIndex = 0;

            // Following hash will save the frequency of each char of the pattern
            var patternLookup = new Dictionary<char, int>();
            var matched = 0;

            foreach (var patternChar in s1)
            {
                if (patternLookup.ContainsKey(patternChar))
                {
                    patternLookup[patternChar] += 1;
                }
                else
                {
                    patternLookup[patternChar] = 1;
                }
            }

            for (var upperIndex = 0; upperIndex < s2.Length; upperIndex++)
            {
                var rightChar = s2[upperIndex];

                if (patternLookup.ContainsKey(rightChar))
                {
                    patternLookup[rightChar] -= 1;

                    if (patternLookup[rightChar] == 0)
                    {
                        // increase when the frequency of this given char has been exhausted
                        matched++;
                    }
                }

                if (matched == patternLookup.Count)
                {
                    return true;
                }

                if (upperIndex >= s1.Length - 1)
                {
                    // shrink the window
                    // get the char at the lefter side of the window (and increase lowerIndex at once)
                    var leftChar = s2[lowerIndex++];
                    
                    if (patternLookup.ContainsKey(leftChar))
                    {
                        if (patternLookup[leftChar] == 0)
                        {
                            matched--;
                        }
                        
                        // always increase the frequency
                        patternLookup[leftChar] += 1;
                    }
                }
            }

            return false;
        }
    }
}