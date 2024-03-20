using System;

namespace delegates
{
    class demo1
    {
        public delegate string Printdel(string name, string last);

        public static void Main()
        {
            demo1 d1 = new demo1();
            //  Printdel pd = new Printdel(d1.Print);
            //  pd("dilip","nasu");
            var t = d1.delegateasfunctionparamete("dilip", "Kumar", (d, f) => { return d + f; });
            Console.Write(t);
            Console.Read();
        }

        public string delegateasfunctionparamete(string first, string last, Printdel printdel)
        {
            return printdel(first, last);
        }

        public string Print(string name, string last)
        {
            return name + last;
        }
    }
}
