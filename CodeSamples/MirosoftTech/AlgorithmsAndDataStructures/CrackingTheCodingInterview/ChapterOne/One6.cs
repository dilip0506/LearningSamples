using System.Text;

namespace ChapterOne
{
    class One6//loop throught the string first gives count of chnages if no contious letter solved and aslo we can known how much stirngbuider we can use(2 times looping and more code)
    {
        static string Compression(string input)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                count++;
                if (i + 1 >= input.Length || input[i] != input[i + 1])
                {
                    sb.Append(input[i]);
                    sb.Append(count);
                    count = 0;
                }
            }
            if (input.Length == sb.Length)
            {
                return input;
            }
            return sb.ToString();
        }
        static void Main()
        {
            string s = "aabcccccaaa";
            Console.WriteLine(Compression(s));
            Console.ReadKey();
        }
    }
}
