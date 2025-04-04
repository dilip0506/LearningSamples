using System;
using System.Collections.Generic;

namespace delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * example how to declare a delegate
           public delegate void HelloDel(string Message);//declare delegate with same method signature
           static void Main(string[] args)
           {
               Program p = new Program();
               HelloDel HD = new HelloDel(p.Hello);//create ne instance of delegate and passmethod name
               HD("hello");//the pass method parameter to delegate
               //HD.Invoke("hello");//can also call using method invoke
               HelloDel HD1 = new HelloDel(p.Hello2);
               HD1("hello1");
               Console.ReadKey();
           }
           public void Hello(string message) {
               Console.WriteLine(message);
           }
           public void Hello2(string message){
           Console.WriteLine(message);
           }
           end of exmaple below exmaple show an implementation of delegate
           */
            //--------------------------------------------------------------------------------------------------------------------------

            List<Employee> EmpList = new List<Employee>
             {
                new Employee(){ Id = 1, Name="dilip", Salary = 5000, Experience=6},
                new Employee(){ Id = 2, Name="kumar", Salary = 4000, Experience=4},
                new Employee(){ Id = 3, Name="Nasu", Salary = 3000, Experience=3},
                new Employee(){ Id = 4, Name="june", Salary = 6000, Experience=7}
             };
            //Program po = new Program();
            Employee emp = new Employee();
            // DelIsPromote ispromote = new DelIsPromote(po.Promote);
            //emp.IsPromote(EmpList,ispromote);
            emp.IsPromote(EmpList, ispromote => ispromote.Experience >= 5);//instead of manually creating a function and creating new delegate "=>" exprrission will create a delegate and takes a condition "//"ed code is alternate of  "=>"
            emp.IsPromote(EmpList, ispromote => ispromote.Name == "dilip");

            Program po1 = new Program();
            //sampeldel del1,del2,del3,del4;
            //del1 = new sampeldel(po1.Sample1);
            //del2 = new sampeldel(po1.Sample2);
            //del3 = new sampeldel(po1.Sample3);
            //del4 = del1 + del2 + del3 - del2;//appending three funtion delegates of same signature to one delegate we can also remove delegate using "-" operator
            //del4();//call one delegate invokes all other delegates
            //above 5 septs can also be performed as below
            sampeldel del = new sampeldel(po1.Sample1);//instead creating new instance of delegate we can append and reomove
            del += po1.Sample2;
            del += po1.Sample3;
            del -= po1.Sample2;
            del();
            sampleidel deli = new sampleidel(po1.Sample1i);
            deli += po1.Sample2i;
            deli += po1.Sample3i;
            int delir = deli();//return last delegate(function value)
            Console.WriteLine(delir);
            Console.ReadKey();
        }
        //public bool Promote(Employee emp) {
        //    return (emp.Experience >= 5) ? true : false;
        //}
        //methods with return type
        public int Sample1i()
        {
            return 1;
        }
        public int Sample2i()
        {
            return 2;
        }
        public int Sample3i()
        {
            return 3;
        }
        //multicast delegate start 
        public void Sample1()
        {
            Console.WriteLine("1");
        }
        public void Sample2()
        {
            Console.WriteLine("2");
        }
        public void Sample3()
        {
            Console.WriteLine("3");
        }
        //muticast delegate end



    }
    public delegate void sampeldel();
    public delegate int sampleidel();
    public delegate bool DelIsPromote(Employee emp);
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public void IsPromote(List<Employee> emplist, DelIsPromote ispromote)
        {
            foreach (Employee emp in emplist)
            {
                if (ispromote(emp))
                {
                    Console.WriteLine(emp.Name);
                }
            }
        }
    }
}
