namespace ChapterOne
{
    class Squareroot
    {
        int Squrt(int n, int min, int max)
        {
            if (max < min)
            {
                return -1;
            }
            int guess = (min + max) / 2;
            if (guess * guess == n)
            {
                return guess;
            }
            else if (guess * guess < n)
            {
                return Squrt(n, guess + 1, max);
            }
            else
            {
                return Squrt(n, min, guess - 1);
            }
            //return 1;
        }
        public static void Run()
        {
            Squareroot sr = new Squareroot();
            Console.WriteLine("{0}", sr.Squrt(36, 1, 36));
            Console.Read();
        }
    }
}
