using System;

namespace Test
{
    class Program
    {
        static int CountUniqueCharacters(string charc)
        {
            int count = 0;
            int[] isthere = new int[128];
            for (int i = 0; i < charc.Length; i++)
            {
                if (isthere[(int)charc[i]] == 0)
                {
                    isthere[(int)charc[i]] = 1;
                }
                else
                {
                    isthere[(int)charc[i]] = 2;
                }
            }
            for (int a = 0; a < 128; a++)
            {
                if (isthere[a] == 1)
                {
                    count++;
                }
            }
            return count;
        }
        static int GenString(string input)
        {
            int result = 0;
            string s = null;
            int j = 0;
            while (j < input.Length)
            {
                for (int i = j; i < input.Length; i++)
                {
                    s += input[i];
                    int r = CountUniqueCharacters(s);
                    result += r;
                }
                s = null;
                j++;
            }
            return result;
        }
        static void Test(string[] args)
        {
            Console.Write(GenString("ACAX"));
            Console.Read();
        }
    }
}
