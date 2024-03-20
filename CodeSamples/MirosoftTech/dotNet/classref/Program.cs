using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    namespace dilip {//namespace inside namespace
#region class
        class Dog {
            public string Name { get; set; }
        }
        class Cat {
            public string Name { get; set; }
            Program p1 = new Program();
            void Xy() {
                //Inner be = new ConsoleApp1.dilip.Program.Inner(); because it is private you cannot access it on line 24
                p1.x = 10;
            }
#endregion

        }
        class Program
        {
            private class Inner//class inside class can have access modifiers for accesability
            {
                public void g() {
                    Console.WriteLine("gu");
                }

            }
            public int x;
            void Xyz() {
                x = 10;
            }
            static void Main(string[] args)
            {
                Inner be = new ConsoleApp1.dilip.Program.Inner();
                be.g();
                Program p = new Program();
                object r = new string("hi".ToCharArray());
                object s = new string("hi".ToCharArray());
                Dog dog = new Dog();
                dog.Name = "cat";
                Dog dog1 = new Dog();
                dog1.Name = "cat";
                //Cat cat = new Cat();
                //cat.Name = "cat";
                //string s = "this"; 
                //object r = "this";
                Console.WriteLine((s == r) ? "hi" : "bye");
                Console.WriteLine((s.Equals(r)) ? "hi" : "bye");
                Console.Read();
            }
        }
    }
}
