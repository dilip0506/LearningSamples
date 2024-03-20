using System.Diagnostics;


namespace Udemy.Solid
{
    internal class SingleResponsibility
    {
        private class Journal// divide responsibilities among classes
        {
            private readonly IList<string> _entries = new List<string>();
            private static int _count;

            public int AddEntry(string entry)
            {
                _entries.Add($"{++_count} : {entry}");
                return _count; //memento
            }

            public void RemoveEntry(int index)
            {
                _entries.RemoveAt(index);
            }

            public override string ToString()
            {
                return string.Join(Environment.NewLine, _entries);
            }

        }

        private class Persistence // divide responsibilities among classes
        {
            public void SaveToFile(string text, string filename, bool overwrite = false)
            {
                if (overwrite || !File.Exists(filename))
                {
                    File.WriteAllText(filename, text);
                }
            }
        }


        private static void Main()
        {
            var j = new Journal();
            j.AddEntry("Hi How are you");
            j.AddEntry("This is code");
            j.RemoveEntry(1);
            j.AddEntry("This is VS");
            Console.Write(j);
            Persistence p = new Persistence();
            p.SaveToFile(j.ToString(), @"D:\file.txt", true);
            Process.Start(@"D:\file.txt");
            Console.Read();
        }
    }
}
