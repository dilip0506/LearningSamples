using System;
using System.Threading.Tasks;

namespace MultiThreading.TaskDemo
{
    public static class TaskDemoUsing
    {

        public async static Task Run()
        {
            await MakeTeaAsync();
        }


        public static async Task<string> MakeTeaAsync()
        {
            var boilingWater = BoilWaterAsync();

            Console.WriteLine("take the cups out");

            var a = 0;
            for (int i = 0; i < 100000000; i++)
            {
                a += i;
            }

            Console.WriteLine("put tea in cups");

            var water = await boilingWater;

            var tea = $"pour {water} in cups";

            return tea;
        }

        public static async Task<string> BoilWaterAsync()
        {
            Console.WriteLine("Start the kettle");

            Console.WriteLine("waiting for the kettle");
            await Task.Delay(300);

            Console.WriteLine("kettle finished boiling");

            return "water";
        }

        public static string MakeTea()
        {
            var water = BoilWater();

            Console.WriteLine("take the cups out");

            Console.WriteLine("put tea in cups");

            var tea = $"pour {water} in cups";

            return tea;
        }

        public static string BoilWater()
        {
            Console.WriteLine("Start the kettle");

            Console.WriteLine("waiting for the kettle");

            Task.Delay(2000).GetAwaiter().GetResult();

            Console.WriteLine("kettle finished boiling");

            return "water";
        }
    }
}
