using System;
using System.Collections.Generic;

namespace ProblemSet
{
    static class TwoSum
    {
        //Solution 1
        private static int[] SolutionBruteForce(int[] nums, int target)
        {
            var countOfNumbers = nums.Length;
            for (int i = 0; i < countOfNumbers; i++)
            {
                for (int j = i + 1; j < countOfNumbers; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { 0, 0 };
        }

        //Solution 2
        private static int[] SolutionHashMap(int[] nums, int target)
        {
            Dictionary<int, int> valueAndIndex = new Dictionary<int, int>();
            var countOfNumbers = nums.Length;

            for (int i = 0; i < countOfNumbers; i++)
            {

                if (!valueAndIndex.ContainsKey(nums[i]))
                    valueAndIndex[nums[i]] = i;
                var value = target - nums[i];

                if (valueAndIndex.ContainsKey(value))
                {
                    var itemIndex = valueAndIndex[value];
                    if (i != itemIndex)
                        return new int[] { itemIndex, i };
                }
            }

            return new int[] { 0, 0 };
        }


        public static void Run()
        {
            int[] nums = new int[] { 3, 3 };
            int target = 6;
            foreach (var item in SolutionHashMap(nums, target))
            {
                Console.Write($",{item}");
            }
        }
    }
}
