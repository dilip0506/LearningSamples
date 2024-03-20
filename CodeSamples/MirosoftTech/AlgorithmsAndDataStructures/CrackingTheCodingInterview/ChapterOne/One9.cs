namespace ChapterOne
{
    public class One9
    {
        //my way
        static bool CheckRotation(string s1, string s2)
        {
            int match = 0;
            if (s1.Length != s2.Length) return false;
            for (int i = s2.Length - 1; i >= 0; i--)
            {
                if (s1[0] == s2[i])
                {
                    match = i;
                    break;
                }
            }
            for (int j = 0; j < s1.Length - match; j++)
            {
                if (s1[j] != s2[match + j])
                {
                    return false;
                }
            }
            string rem = s1.Substring(s1.Length);
            if (!s2.Contains(rem))
            {
                return false;
            }
            return true;
        }

        //book way
        static bool CheckRotation1(string s1, string s2)
        {
            string s1s1 = s1 + s1;
            if (s1s1.Contains(s2))
            {
                return true;
            }
            return false;
        }

        public static void Run()
        {
            string s1 = "waterbottle";
            string s2 = "erbottlewat";
            if (CheckRotation1(s1, s2))
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
