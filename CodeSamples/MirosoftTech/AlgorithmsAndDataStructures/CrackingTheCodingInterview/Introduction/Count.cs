using System;

namespace Introduction
{
    class Count
    {
        int[] i = { 5, 3, 1 };
        //recursive
        int Test(int c)
        {
            Count count = new Count();
            int a = 0, b = 0;
            return count.Test(b, a, c);
        }
        int Test(int x, int y, int z)
        {

            if (z < i[x])
            {
                x++;
                return Test(x, y, z);
            }
            else
            {
                if (z % i[x] == 0)
                {
                    y += z / i[x];
                    return y;
                }
                else
                {
                    y += z / i[x];
                    z %= i[x];
                    x++;
                    return Test(x, y, z);
                }
            }
        }
        //itterative
        int Testt(int input)
        {
            int c = 0;
            for (int j = 0; j < i.Length; j++)
            {
                c += input / i[j];
                input %= i[j];
            }
            return c;
        }
        static void Run()
        {
            Count c = new Count();
            int p = c.Testt(20);
            Console.WriteLine(p);
            Console.Read();
        }
    }
}
