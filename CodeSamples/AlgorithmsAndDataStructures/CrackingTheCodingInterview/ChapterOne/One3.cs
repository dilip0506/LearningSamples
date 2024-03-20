namespace ChapterOne
{
    class One3
    {
        static string RepalceSpace(string input, int truelenth)
        {
            int Space = 0;
            char[] ch = input.ToCharArray();
            for (int i = 0; i < truelenth; i++)
            {
                if (ch[i] == ' ')
                {
                    Space++;
                }
            }
            int index = truelenth + Space * 2;
            if (truelenth < ch.Length) ch[--index] = '\0';
            for (int j = truelenth - 1; j >= 0; j--)
            {
                if (ch[j] == ' ')
                {
                    ch[index--] = '0';
                    ch[index--] = '2';
                    ch[index--] = '%';
                }
                else ch[index--] = ch[j];
            }
            return new string(ch);
        }
        public static void Run()
        {
            string s = "Mr John Smith    ";
            Console.WriteLine(RepalceSpace(s, 13));
            Console.Read();
        }
    }
}

