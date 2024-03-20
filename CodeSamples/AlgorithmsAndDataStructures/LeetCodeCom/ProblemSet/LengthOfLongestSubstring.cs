using System;
using System.Collections.Generic;

namespace ProblemSet
{
    internal class LengthOfLongestSubstring
    {
        public static int SelfSolutionHashMap(string s)
        {
            int max = 0;
            int subStringCount = 0;
            var numberofWords = s.Length;
            int sliding = 0;
            var words = s.ToCharArray();
            Dictionary<char, int> chars = new Dictionary<char, int>();
            while (sliding < numberofWords)
            {
                if (chars.ContainsKey(words[sliding]))
                {
                    max = max > subStringCount ? max : subStringCount;
                    sliding = chars[words[sliding]];
                    chars = new Dictionary<char, int>();
                    subStringCount = 0;
                }
                else
                {
                    chars.Add(words[sliding], sliding);
                    subStringCount++;
                }
                sliding++;
            }
            max = max > subStringCount ? max : subStringCount;
            return max;
        }


        public static int BestSolution(string s)
        {
            Dictionary<char, int> chars = new Dictionary<char, int>();
            var result = 0;
            var len = s.Length;
            for (int i = 0; i < len; i++)
            {
                int j = 0;
                if (chars.ContainsKey(s[i]))
                {
                    j = chars[s[i]];
                    result = Math.Max(result, j - i);
                }
                chars[s[i]] = j;
            }
            return result;
        }

        public static void Run()
        {
            Console.WriteLine(SelfSolutionHashMap("pwwkew"));
        }
    }
}
