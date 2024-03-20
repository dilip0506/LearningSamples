namespace ChapterOne
{
    class One5
    {
        //my way
        static bool ResultAscii(string input1, string input2)
        {
            if (input1.Length > input2.Length)
            {
                string temp = input1;
                input1 = input2;
                input2 = temp;
            }
            int cou = 2;
            int[] count = new int[128];
            for (int i = 0; i < input1.Length; i++)
            {
                count[(int)input1[i]]++;
            }
            for (int j = 0; j < input2.Length; j++)
            {
                count[(int)input2[j]]--;
                if (count[(int)input2[j]] < 0)
                {
                    cou--;
                    if (cou == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        //book way1
        static bool bookway1(string input1, string input2)
        {
            if (input1.Length == input2.Length)
            {
                return RePlace(input1, input2);
            }
            else if (input1.Length + 1 == input2.Length)
            {
                return Edit(input2, input1);
            }
            else if (input1.Length - 1 == input2.Length)
            {
                return Edit(input1, input2);
            }
            return false;
        }
        static bool RePlace(string s1, string s2)
        {
            bool found = false;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    if (found)
                    {
                        return false;
                    }
                    found = true;
                }
            }
            return true;
        }
        static bool Edit(string s1, string s2)
        {
            int index1 = 0;
            int index2 = 0;
            while (index1 < s1.Length && index2 < s2.Length)
            {
                if (s1[index1] != s2[index2])
                {
                    if (index1 != index2)
                    {
                        return false;
                    }
                    index2++;
                }
                else
                {
                    index1++;
                    index2++;
                }

            }
            return true;
        }
        //end
        //book way2
        static bool bookway2(string first, string second)
        {
            bool found = false;
            int index1 = 0;
            int index2 = 0;
            String s1 = first.Length < second.Length ? first : second;
            String s2 = first.Length < second.Length ? second : first;
            while (index1 < s1.Length && index2 < s2.Length)
            {
                if (s1[index1] != s2[index2])
                {
                    if (found) return false;
                    found = true;
                    if (s1.Length == s2.Length)
                    {
                        index1++;
                    }
                }
                else
                {
                    index1++;
                }
                index2++;
            }
            return true;
        }

        public static void Run()
        {
            string input1 = "pale";
            string input2 = "ple";
            if (bookway2(input1, input2))
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
