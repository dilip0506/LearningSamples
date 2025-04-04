using HeadFirst.Factory.SimpleFactory.Pizza;

namespace HeadFirst.Factory.SimpleFactory
{
    public class PizzaFactory
    {
        public static AbstractPizza CreatePizza(PizzaTypes pizzaTypes)
        {

            return pizzaTypes switch
            {
                PizzaTypes.Cheese => new CheesePizza(),
                PizzaTypes.Veggie => new VeggiePizza(),
                _ => throw new ArgumentException("Pizza type not found"),
            };
        }
    }
}
