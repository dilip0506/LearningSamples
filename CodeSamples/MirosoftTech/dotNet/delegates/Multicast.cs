using System;

namespace delegates
{
    class Multicast
    {
        //add methods should have same signature
        //return will override with last called function in multicate delegate(use datastructure to save)
        public delegate void AMdel(int x, int y);
        public static void Main()
        {
            Multicast mc = new Multicast();
            AMdel AMd = new AMdel(mc.Add);
            AMd += mc.Mutlti;
            AMd(2, 3);
            Console.Read();
        }
        public void Add(int i, int j)
        {
            Console.WriteLine(i + j);
        }
        public void Mutlti(int i, int j)
        {
            Console.WriteLine(i * j);
        }
    }
}
