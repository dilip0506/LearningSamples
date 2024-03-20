using System;
using System.Diagnostics;
using System.Threading;

namespace MultiThreading
{
    internal class MultiThreadingDemo
    {
        public static void LongRunningMethodOne()
        {
            long count = 0;
            for (long i = 0; i <= 1000000000; i++)
            {
                count++;
            }
            Console.WriteLine("LongRunningMethodOne {0}", count);
        }
        public static void LongRunningMethodTwo()
        {
            long count = 0;
            for (long i = 0; i <= 1000000000; i++)
            {
                count++;
            }
            Console.WriteLine("LongRunningMethodTwo {0}", count);
        }


        public static void MeasuringPerformanceSynchronously()
        {
            Stopwatch sync = new Stopwatch();
            sync.Start();
            LongRunningMethodOne();
            LongRunningMethodTwo();
            sync.Stop();
            Console.WriteLine("Synchronous {0}", sync.ElapsedMilliseconds);
        }


        public static void MeasuringPerformanceWithThreads()
        {
            Stopwatch sync = new Stopwatch();
            Thread threadOne = new Thread(LongRunningMethodOne);
            Thread threadTwo = new Thread(LongRunningMethodTwo);

            sync.Start();

            threadOne.Start();
            threadTwo.Start();

            threadOne.Join();//join() method will wait until thread completes run stopwatch stop and after two threads complete and print the result
            threadTwo.Join();// otherwise main thread will run and completes(stopwatch and print are in main thread)

            sync.Stop();
            Console.WriteLine("With Threads {0}", sync.ElapsedMilliseconds);
        }


        public static void Run()
        {
            MeasuringPerformanceSynchronously();
            MeasuringPerformanceWithThreads();
        }
    }
}
