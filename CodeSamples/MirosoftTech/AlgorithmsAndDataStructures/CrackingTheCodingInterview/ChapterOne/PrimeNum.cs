namespace ChapterOne
{
    class PrimeNum
    {
        static void Main()
        {
            int i; bool t;
            for (i = 3; i <= 100; i++)
            {
                t = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        t = false;
                        break;
                    }
                }
                if (t)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}