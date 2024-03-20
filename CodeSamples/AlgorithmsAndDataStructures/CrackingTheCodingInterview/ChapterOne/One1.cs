namespace ChapterOne
{
    class One1
    {
        //brute force
        public static bool Brute(string sub)
        {
            int len = sub.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (sub[i] == sub[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        //bitwise
        public static bool BitWise(string sub)
        {
            int checker = 0;
            for (int i = 0; i < sub.Length; i++)
            {
                int val = (int)sub[i] - (int)'a';
                if ((checker & (1 << val)) > 0)
                {
                    return false;
                }
                checker |= (1 << val);
            }
            return true;
        }
        //sorted Linear search
        //public static bool SortedLinear(string sub) {

        //}


        //ASCII
        public static bool Ascii(string sub)
        {
            bool[] cha = new bool[128];
            if (sub.Length >= 128)
            {
                return false;
            }
            for (int i = 0; i < sub.Length; i++)
            {
                int j = (int)sub[i];
                if (cha[j])
                {
                    return false;
                }
                cha[j] = true;
            }
            return true;
        }
        public static void Run()
        {
            string sub = "aba";
            if (BitWise(sub))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadKey();
        }
    }
}
