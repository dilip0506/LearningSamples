using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBlog.Mediator.Food;

namespace WebBlog.Mediator
{
    public static class TestRunner
    {
        public static void Run() 
        {
            var mediator = new ConcreateMediator();

            var left = new HotDog(mediator);
            var right = new FrenchFries(mediator);

            mediator.HotDogStand = left;
            mediator.FriesStand = right;

            left.Send("Hot Dog");
            right.Send("French");
        }
    }
}
