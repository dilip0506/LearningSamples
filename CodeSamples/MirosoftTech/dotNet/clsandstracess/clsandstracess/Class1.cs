using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsandstracess
{

    public partial class Class1
    {
        //public string name { get; set; }//short

        private string _name;// long 
        public string Name//implementation of property
        {
            get { return _name; }
            private set { //access specifer
                //look the variable(logic)
                _name = value;
            }
        }

        public void PublicEx()
        {
        }
        private void PrivateEx()
        {
        }
        protected void ProtectedEx()
        {
        }
        internal void InternalEx()
        {
        }
        internal protected void InternalProtectedEx()
        {
        }
        public void Test()
        {
            Console.WriteLine("hi1");
        }
        public virtual void Testover() {//uisng virtual and override is also Polymorphism becasue base class method behaves diffrently we differnt value(passing derived class)
            Console.WriteLine("hi01");
        }
        public void Speak(int time, string what = "bark", Boolean sit = true)// defaults should go last
        {

            /*
             * if you want to call the above method with only two parameter
             * use name of the variable
             * speaker(1,sit:true)
             */
        }
        /*
        public static void Main()
        {
            Class1 c1 = new Class1();
        }
        */
    }
    class Class2: Class1
    {
        public new void Test(){
            Console.WriteLine("hi2");
        }
        public override void Testover(){
            Console.WriteLine("hi02");
        }

        public void NewMethod()
        {
            Console.WriteLine("new");
        }

        public string _2name { get; set; }
        public void Bar2() { 
            Class1 c1 = new Class1();
            Class1 c2 = new Class2();
            Class2 c3 = new Class2();
            //Class2 cf = new Class1();//not possible because dog can be animal, but animal cannot be dog.base class already has all fields of parent class so no need to do that. but you can change animal to dog i.e, type casting
            //c2.NewMethod();//not possible
            Class1 cd = (Class1)c3;
            c1.Test();//of the type class parent(class1) so call its method
            c3.Test();//of the type class child(class2) so it call its method that is hidden from parent using new keyword
            cd.Test();//of type type class parent(class1) but with value of child class still call parent class method using new keyword
            c1.Testover();//of type parent directly get it method used virtual and override keyword
            cd.Testover();//of type parent still can access child method because of virtual and override keyword(by type casting child to parent type)
            c2.Testover();//of type parent still can access child method because of virtual and override keyword(by directly accessing child pointer of passing child value
        }
        public static void Main()
        {
            Class2 c5 = new Class2();
            c5.Bar2();
            Console.ReadLine();
        }

    }
    class Class3
    {//munupulating types
        void rr() {
            Class1 rt = new Class1();
            Class2 rt2 = new Class2();
            x(rt2);
            }
        void x(Class1 r) {
            //Class2 rt3 = (Class2)r
            Class2 rt3 = r as Class2;
        }
        void Bar3()
        {
            Class1 c = new Class2();
            Class1 cf = new Class1();
            cf.Testover();
        }
    }
}
