using System;
using System.Threading;

namespace MultiThreading
{
    class ThreadLocking
    {
        static void Test1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("thread 1 exiting");
        }
        static void Test2()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("stop");
                    Thread.Sleep(5000);//stopped until this starts the next method will not execute(using multi threading the execution will not stop here the next method will execute)
                    Console.WriteLine("start");
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("thread 2 exiting");
        }
        static void Test3(object max)
        {
            int num = Convert.ToInt32(max);
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("thread 3 exiting");
        }
        static void Run(string[] args)
        {
            Thread t = Thread.CurrentThread;//to access current thread or main thread
            ThreadStart obj1 = new ThreadStart(Test1);//below four line are types to create delegates
            ThreadStart obj2 = Test2;
            //ThreadStart obj3 = () => test3();//instead of method name logic should go after lambda expression ("=>")
            ParameterizedThreadStart obj3 = (max) => Test3(max);//if the method takes any parameters
            ThreadStart obj4 = delegate { Console.WriteLine("anonymous or unnamed delegate"); };//we can also Write name instead of logic
            Thread t1 = new Thread(obj1);//Thread method takes delegate as parameter
            Thread t2 = new Thread(Test2);//if we pass method name it automatically instantiates delegate and uses it
            Thread t3 = new Thread(Test3);
            t1.Start();
            t2.Start();
            t3.Start(10);// t3.test("string");//this is not type safe because parameterized. ThreadStart is taking object as parameter we can also pass string that raise exception
            //main threads exits before all thread exits to stop or make main thread to run till last we use "join()" method
            t1.Join();
            t2.Join(3000);//we can bound time to main method how long it should stand(run to observe the output)
            t3.Join();
            Console.WriteLine("thread main exiting");//exits early because it access work to other (child)threads
            /*
             t1 : 2 2 2 2 2 2 2 2 2
             t2 : 2 2 2 - - - 2 2 2(--- at that point process may stopped or not responding the resource is allocated to new method(other thread))
             t3 : 2 2 2 2 2 2 2 2 2
             */
            Console.Read();
        }
    }

    class ThreadLockingEx2
    {
        void Print()
        {
            lock (this)
            {
                Console.Write("start is to");
                Thread.Sleep(5000);
                Console.WriteLine(" run");
            }
        }

        static void Run(string[] args)
        {
            ThreadLockingEx2 p = new ThreadLockingEx2();
            Thread t1 = new Thread(p.Print);
            Thread t2 = new Thread(p.Print);
            Thread t3 = new Thread(p.Print);
            //three threads are access same method causes abnormal output we should lock the process to one thread
            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
