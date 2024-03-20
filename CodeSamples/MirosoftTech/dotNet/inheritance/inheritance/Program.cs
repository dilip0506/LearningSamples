using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class ParentClass
    {
        public ParentClass() {
            Console.WriteLine("This parent paramterless");
        }
        public ParentClass(string msg) {
            Console.WriteLine("This Parent with {0} parameter", msg);
        }
        public void newclass() {
            Console.WriteLine("this parent class");
        }
    }
    class ChildClass : ParentClass
    {
        public ChildClass() : base("hi")//can aslo control with constructor to call
        {
            //Console.WriteLine("This is child class");
            //ParentClass p = new ParentClass("hi");//can be done instead use base keyword
        }
        public new void newclass() {
            base.newclass();//caling parent class hidden method(which is hidden because you reimplemented that method here)
            Console.WriteLine("This is childclass");
        }
        public void Newchildmethod() {
            Console.WriteLine("This is child method");
        }
    }
    class UserClass {

        public static void Main()
        {
            ChildClass cc = new ChildClass();
            ParentClass pc = new ChildClass();
            cc.newclass();
            Console.Read();
            /*
             * refer example (clsandstracess) for various calling types and deffrent implementation
             */
        }

    }
}
