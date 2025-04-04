namespace ChapterOne
{
    class seq
    {
        static void Run(string[] args)
        {
            StreamReader SR = new StreamReader(@"D:\ProjectsandPractice\exin.txt");
            int g = 0;
            string data = SR.ReadToEnd();
            string[] dataint = data.Split(' ');
            foreach (string i in dataint)
            {
                int j = int.Parse(i);
                g += j;
            }
            Console.WriteLine(g);
            Console.ReadKey();
        }
    }
}
