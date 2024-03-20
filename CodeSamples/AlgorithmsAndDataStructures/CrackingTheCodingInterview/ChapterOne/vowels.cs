using System.Text;

namespace ChapterOne
{
    class Vowels
    {
        static void Run()
        {
            StreamReader reader = new StreamReader(@"D:\ProjectsandPractice\exin.txt");
            string data = reader.ReadToEnd();
            StringBuilder str = new StringBuilder();
            char[] cha = { 'A', 'E', 'I', 'O', 'U' };
            foreach (char i in data)
            {
                char h = char.ToUpper(i);
                if (!(cha.Contains(h)))
                {
                    str.Append(i);
                }
            }
            Console.WriteLine(str);
            Console.Read();
        }
    }
}
