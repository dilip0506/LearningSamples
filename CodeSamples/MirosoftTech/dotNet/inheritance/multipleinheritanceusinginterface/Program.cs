using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipleinheritanceusinginterface
{
    interface IA {
        void AM();
    }
    interface IB {
        void BM();
    }
    class A : IA
    {
        public void AM()
        {
            Console.WriteLine("AM");
        }
    }
    class B : IB{
        
        public void BM() {
            Console.WriteLine("BM");
        }
    }

    class AB : IA, IB {
        A a = new A();
        B b = new B();
        public void AM()
        {
            a.AM();
        }
        public void BM()
        {
            b.BM();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            AB ab = new AB();
            ab.AM();
            ab.BM();
            Console.ReadKey();
        }
    }
}
