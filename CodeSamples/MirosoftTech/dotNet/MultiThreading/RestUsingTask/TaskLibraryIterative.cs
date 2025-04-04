using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.RestUsingTask
{
    public class TaskLibraryIterative
    {

        public static async Task All()
        {
            var nums = Test.GetNumbers();
            Stopwatch sync = new Stopwatch();
            sync.Start();
            foreach (int i in nums)
            {
                await Test.AddNumbers(i);
            }
            sync.Stop();
            Console.WriteLine("All {0}", sync.ElapsedMilliseconds);

        }

        public static async Task WhenAll()
        {
            var nums = Test.GetNumbers();

            Stopwatch sync = new Stopwatch();
            sync.Start();
            var result = await Task.WhenAll(
                nums.Select(
                    i => Test.AddNumbers(i)));
            sync.Stop();
            Console.WriteLine("WhenAll {0}", sync.ElapsedMilliseconds);

            //foreach (var task in result)
            //{
            //    //Console.WriteLine(task);
            //}

        }




        public static async Task Run()
        {
            await All();
            await WhenAll();
        }

    }


    internal class Test
    {
        public static async Task<int> AddNumbers(int a)
        {
            await Task.Delay(1000);
            return await Task.FromResult(a + a);
        }


        public static IEnumerable<int> GetNumbers()
        {
            for (int i = 0; i <= 500; i++)
            {
                yield return i;
            }
        }
    }

}
