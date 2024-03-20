using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             car car1 = new car();
             car1.make = "audi";
             car1.year = 2000;
             car car2 = new car();
             car2.make = "BMW";
             car2.year = 2000;
             book book1 = new book();
             book1.title = "half girlfriend";
             book1.year = 2000;
             ArrayList al = new ArrayList();
             al.Add(car1);
             al.Add(car2);
             //al.Add(book1);
             foreach (car car in al) {
                 Console.WriteLine(car.make);
             }
             //list           
             List<car> cara = new List<car>();
             cara.Add(car1);
             cara.Add(car1);
             //dictonary
             Dictionary<string, car> dc = new Dictionary<string, car>();
             dc.Add(car1.make,car1);
             dc.Add(car2.make,car2);
             Console.WriteLine(dc["audi"].year);
             Console.ReadLine();
             */
            var list = new int[5];
            int[] list0 = new int[] { 1, 2, 2, 4 };
            int[] list1 = new int[5];
            list1[0] = 1;
            // object initializer
            car[] c = new car[3];
            c[0] = new car() {
                make = "sun",
                year = 2005
            };
            c[1] = new car
            {
                make = "hot",
                year = 2007
            };

            car car1 = new car() { make = "audi", year=2000};
            car car2 = new car() { make = "audi", year = 2000 };
            List<car> cara = new List<car>() {
                 new car() { make = "audi", year = 2000 },
                 new car() { make = "audi", year = 2000 }
                 };
        }
    }
    class car
    {
        public string make { get; set; }
        public int year { get; set; }
    }
    class book
    {
        public string title { get; set; }
        public int year { get; set; }

    }
}
