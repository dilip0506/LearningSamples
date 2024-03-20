using System;

namespace Introduction
{
    class BruteForce
    {
        string sub = "efg";
        string full = "abcdefgh";
        bool Search(string sub, string full)
        {
            int M = sub.Length;
            int N = full.Length;
            for (int i = 0; i < N - M; i++)
            {
                //Console.WriteLine("full:{0}",i);
                int j;
                for (j = 0; j < M; j++)
                {
                    //Console.WriteLine("full:{0} sub:{1}", full[i+j], sub[j]);
                    if (full[i + j] != sub[j])
                    {
                        break;
                    }
                    if (j == M - 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static void Run()
        {
            BruteForce b = new BruteForce();
            if (b.Search(b.sub, b.full))
            {
                Console.WriteLine("found");
            }
            else
            {
                Console.WriteLine("not found");
            }
            Console.Read();
        }
    }
}
