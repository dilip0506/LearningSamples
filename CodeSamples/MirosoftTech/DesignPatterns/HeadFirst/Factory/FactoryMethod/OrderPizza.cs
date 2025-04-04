using HeadFirst.Factory.FactoryMethod.Pizza;
using HeadFirst.Factory.FactoryMethod.PizzaStore;

namespace HeadFirst.Factory.FactoryMethod
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
