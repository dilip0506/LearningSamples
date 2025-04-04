using HeadFirst.Factory.AbstractFactory.Pizza;
using HeadFirst.Factory.AbstractFactory.PizzaStore;

namespace HeadFirst.Factory.AbstractFactory
{
    public static class OrderPizza
    {
        public static void Run()
        {
            var texasStylePizza = new TexasStylePizza();
            texasStylePizza.OrderPizza(PizzaTypes.Cheese);
            var newYorkStylePizza = new NewYorkStylePizza();
            newYorkStylePizza.OrderPizza(PizzaTypes.Cheese);
        }
    }
}
