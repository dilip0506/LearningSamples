using HeadFirst.Decorator.Beverages;
using HeadFirst.Decorator.CondimentDecorators;
using System;

namespace HeadFirst.Decorator
{
    public static class CoffeeShop
    {
        public static void Run()
        {
            Beverage darkRoast = new DarkRoast();
            darkRoast = new Milk(darkRoast);
            darkRoast = new Mocha(darkRoast);
            darkRoast = new Whip(darkRoast);
            Console.WriteLine(darkRoast.Cost());
        }
    }
}
