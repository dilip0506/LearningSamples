using System;
using System.Threading;

namespace MultiThreading
{
    class ThreadPriorities
    {
        static long count1, count2;
        static void Increment1()
        {
            while (true)
            {
                count1++;
            }
        }
        static void Increment2()
        {
            while (true)
            {
                count2++;
            }
        }
        static void Main()
        {
            Console.WriteLine("Main thread start");
            Thread t1 = new Thread(Increment1);
            Thread t2 = new Thread(Increment2);
            t1.Start();
            t2.Start();

            t1.Priority = ThreadPriority.Lowest;//low priority low time spent
            t2.Priority = ThreadPriority.Highest;//sets highest priority to method2 more rime is spent
            Console.WriteLine("Main thread sleep");
            Thread.Sleep(10000);

            t1.Abort();
            t2.Abort();
            t1.Join();
            t1.Join();
            Console.WriteLine("count1 {0} \ncount2 {1}", count1, count2);
            Console.WriteLine("main thread close");
            Console.ReadKey();
        }
    }
}
