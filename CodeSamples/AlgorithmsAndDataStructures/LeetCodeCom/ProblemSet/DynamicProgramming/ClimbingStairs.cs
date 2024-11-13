
using System;

namespace ProblemSet.DynamicProgramming
{
    public class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            if (n < 0)
                return 0;
            if (n == 0)
                return 1;

            return ClimbStairs(n - 2) + ClimbStairs(n - 1);
        }

    }

    public static class Test
    {
        public static void Run()
        {
            var test = new ClimbingStairs();
            Console.WriteLine(test.ClimbStairs(44));
        }
    }
}