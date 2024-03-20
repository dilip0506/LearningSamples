using System;

namespace delegates
{
    public delegate string Namedel(string name);//delegete defined
    class Lamba
    {
        public static void Main()
        {
            Namedel Nd = name => { return name; };//using lamda expression instead anonmymous to do this we should have delegate defined
            string ex = Nd("dilip");
            Console.WriteLine(ex);
            Console.Read();
        }
    }

}
