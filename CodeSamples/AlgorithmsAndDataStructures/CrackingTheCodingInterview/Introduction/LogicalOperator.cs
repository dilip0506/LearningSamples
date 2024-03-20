using System;

namespace Introduction
{
    class LogicalOperator
    {
        public static void Run()
        {
            Console.WriteLine(true | true);
            Console.WriteLine(true | false);
            Console.WriteLine(false | false);
            Console.WriteLine(false | true);
            Console.WriteLine("-----------------");
            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || false);
            Console.WriteLine(false || true);
            Console.Read();
        }
    }
}
