using HeadFirst.Factory.SimpleFactory.Pizza;

namespace HeadFirst.Factory.SimpleFactory
{
    public static class OrderPizza
    {
        public static void Run()
        {
            Order(PizzaTypes.Cheese);
            Order(PizzaTypes.Veggie);
        }

        public static void Order(PizzaTypes pizzaTypes)
        {
            var pizzaType = PizzaFactory.CreatePizza(pizzaTypes);
            pizzaType.Prepare();
            pizzaType.Baking();
            pizzaType.Cut();
            pizzaType.Ship();
        }
    }
}
