using System;

namespace delegates
{
    class Anonymous
    {
        public delegate void Anonde(string name);
        public static void Main()
        {
            Anonde d = delegate (string name)
            {
                Console.WriteLine(name);
            };
            d("dilip anon");
            Console.Read();
        }
    }
}
