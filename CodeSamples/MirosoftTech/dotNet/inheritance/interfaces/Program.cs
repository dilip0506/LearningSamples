using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    //this is general explanation
    //---------------------------------
    //interfaces support multipule inheritance
    //interface ICustomer {//interfaces can have methods,events or delegats, properties only declaration not implemetation
    //    //int i;//interfaces cannot have fields.
    //    void Print();//interface memebers cannot have access modifiers. they are public by default
    //    //{console.WriteLine}//it cannot have implemetation this cannot be done. implematations is in iheritated class or struct
 
    //}
    //interface ICustmoer2 {
    //}
    //class Program : ICustomer,ICustmoer2//if a class inherts an interface it must implemet all methods in that interface
    //{
    //    public void Print()//implementation from interface. signature should be same
    //    {
    //        throw new NotImplementedException();
    //    }
    //    public static void Main() {
    //    }
    //}
    //---------------------------------------------------------------------------------------------------------------------------------
    // this is example for implicit with diffrent method names inside interface
    //----------------------------------------------------------
    //interface IMan{
    //    void print1();
    //}
    //interface IProgrammer { 
    ////interface Iprogrammer: IMan {
    //    void print2();
    //}
    //class Program : IMan, IProgrammer//multipule
    ////class Program:IProgrammer//multilevel
    //{
    //    static void Main(string[] args)
    //    {

    //    }

    //    public void print2()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void print1()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    /*
     *this is exmaple forexplicit with same method name in both interfaces
     * -------------------------------------------------------------------------
     * a default is, one method can be called with out explicitly that will be default
     */
    interface IMan
    {
        void print();
    }
    interface IProgrammer
    {
        //interface Iprogrammer: IMan {
        void print();
    }
    class Program : IMan, IProgrammer//multipule
    //class Program:IProgrammer//multilevel
    {


        void IMan.print()
        {
            throw new NotImplementedException();
        }
        void IProgrammer.print() {

            throw new NotImplementedException();

        }

        //interface cannot directly have object however, an interface refrence variable can point to dervied class
        //to use the method type should be respective to interfeace(can use type casting or declare that type interfaces)
        static void Main(string[] args)
        {
            IMan m = new Program();//Iterface refrence variable pointing to class
            m.print();
            IProgrammer p = new Program();
            p.print();
            //(or)
            Program pc = new Program();
            ((IMan)pc).print();
            ((IProgrammer)pc).print();
        }
    }
}
