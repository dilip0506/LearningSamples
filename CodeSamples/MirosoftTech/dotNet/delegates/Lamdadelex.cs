using System;
using System.Collections.Generic;

namespace delegates
{
    public delegate bool empex(Employee1 emp);
    class Lamdadelex
    {
        public static void Main()
        {
            List<Employee1> EmpList1 = new List<Employee1>
             {
                new Employee1(){ Id = 1, Name="dilip", Salary = 5000, Experience=6},
                new Employee1(){ Id = 2, Name="kumar", Salary = 4000, Experience=4},
                new Employee1(){ Id = 3, Name="Nasu", Salary = 3000, Experience=3},
                new Employee1(){ Id = 4, Name="june", Salary = 6000, Experience=7}
             };

            Employee1 e1 = new Employee1();
            //empex eee = new empex(empexpp);
            e1.IsPromote(EmpList1, d => d.Experience > 5);
        }
        //public static bool empexpp(Employee1 eeee)
        //{
        //    if (eeee.Experience > 5)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }

    public class Employee1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public void IsPromote(List<Employee1> emplist, empex ee)
        {
            foreach (Employee1 emp in emplist)
            {
                if (ee(emp))
                {
                    Console.WriteLine(emp.Name);
                }
            }
        }
    }
}
