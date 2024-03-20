using System;

namespace delegates
{
    class FuncActionpredicate
    {
        public static double Add(int a, double b, int c)
        {
            return (a + b + c);
        }
        public static void Mul(int a, double b, int c)
        {
            Console.WriteLine(a + b + c);
        }
        public static bool Check(string s)
        {
            return (s.Length > 5) ? true : false;
        }
        static void Main()
        {
            Func<int, double, int, double> obj1 = Add;//instead of creating a delegate we can directly use func keywork for value return
            double f = obj1(1, 3, 4);
            Console.WriteLine(f);
            Action<int, double, int> obj2 = Mul;//for non value return
            Predicate<string> g = Check;//for bool type return, can aslo use func with two parameters
            bool g1 = g("stringaa");
            Func<int, int, int> d = (x, y) => x / y;//can write simply with lambda expression
            Console.WriteLine(d(4, 2));
            Console.Read();
        }
    }
}
