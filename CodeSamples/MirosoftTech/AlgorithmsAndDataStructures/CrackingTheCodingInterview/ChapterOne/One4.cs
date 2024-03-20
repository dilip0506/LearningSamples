namespace ChapterOne
{
    class One4//
    {
        static bool PermuatationPlindroma(string input)
        {
            Dictionary<char, int> count = new Dictionary<char, int>();
            foreach (char i in input)
            {
                if (count.ContainsKey(i))
                {
                    count[i]++;
                }
                else
                {
                    count.Add(i, 1);
                }
            }
            int countfre = 0;
            foreach (KeyValuePair<char, int> c in count)
            {
                if ((c.Value % 2) == 1)
                {
                    countfre++;
                }
            }
            if (countfre > 1)
            {
                return false;
            }
            return true;
        }
        public static void Run()
        {
            string test = "ababa";
            if (PermuatationPlindroma(test))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.Read();
        }
    }
}
