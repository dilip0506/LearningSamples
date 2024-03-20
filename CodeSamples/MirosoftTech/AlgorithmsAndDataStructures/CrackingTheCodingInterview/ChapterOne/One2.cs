namespace ChapterOne
{
    class One2
    {
        static Dictionary<char, int> FrequencyCount(string s)
        {
            Dictionary<char, int> count = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (count.ContainsKey(s[i]))
                {
                    count[s[i]]++;
                }
                else
                {
                    count.Add(s[i], 1);
                }
            }
            return count;
        }
        static bool Result(string input1, string input2)
        {
            Dictionary<char, int> fc1 = FrequencyCount(input1);
            Dictionary<char, int> fc2 = FrequencyCount(input2);
            foreach (KeyValuePair<char, int> fc in fc1)
            {
                if (!(fc2.ContainsKey(fc.Key)))
                {
                    return false;
                }
                else if (fc1[fc.Key] != fc2[fc.Key])
                {
                    return false;
                }
            }
            return true;
        }

        static bool ResultAscii(string input1, string input2)
        {
            int[] count = new int[128];
            for (int i = 0; i < input1.Length; i++)
            {
                count[input1[i]]++;
            }
            for (int j = 0; j < input2.Length; j++)
            {
                count[input2[j]]--;
                if (count[input2[j]] < 0)
                {
                    return false;
                }
            }
            return true;
        }


        public static void Run()
        {
            string input1 = "aabbccc";
            string input2 = "babccac";
            if (ResultAscii(input1, input2))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.Read();
        }
    }
}
