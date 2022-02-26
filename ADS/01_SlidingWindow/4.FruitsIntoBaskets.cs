using System;
using System.Collections.Generic;

namespace ADS.SlidingWindow
{
    // TL;DR: Get the longest subarray with only two different numbers
    //
    // You are visiting a farm that has a single row of fruit trees arranged from left to right.
    // The trees are represented by an integer array fruits where fruits[i] is the type of fruit the ith tree produces.
    //
    // You want to collect as much fruit as possible.
    // However, the owner has some strict rules that you must follow:
    //
    // * You only have two baskets, and each basket can only hold a single type of fruit.
    //   There is no limit on the amount of fruit each basket can hold.
    // * Starting from any tree of your choice, you must pick exactly one fruit from every tree
    //   (including the start tree) while moving to the right. The picked fruits must fit in one of your baskets.
    // * Once you reach a tree with fruit that cannot fit in your baskets, you must stop.
    //
    // Given the integer array fruits, return the maximum number of fruits you can pick.
    public static class FruitsIntoBaskets
    {
        public static int FruitsIntoBasketsSolution(int[] fruits)
        {
            var lookup = new Dictionary<int, int>();
            var lowerIndex = 0;
            var maxNumberOfFruits = 0;

            for (var upperIndex = 0; upperIndex < fruits.Length; upperIndex++)
            {
                var rightFruit = fruits[upperIndex];

                if (lookup.ContainsKey(rightFruit))
                {
                    lookup[rightFruit] += 1;
                }
                else
                {
                    lookup[rightFruit] = 1;
                }

                while (lookup.Count > 2)
                {
                    var leftFruit = fruits[lowerIndex];
                    lookup[leftFruit] -= 1;

                    if (lookup[leftFruit] == 0)
                    {
                        lookup.Remove(leftFruit);
                    }

                    lowerIndex++;
                }

                maxNumberOfFruits = Math.Max(maxNumberOfFruits, upperIndex - lowerIndex + 1);
            }

            return maxNumberOfFruits;
        }
    }
}