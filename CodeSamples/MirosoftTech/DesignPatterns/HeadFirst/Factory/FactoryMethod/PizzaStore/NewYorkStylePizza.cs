using HeadFirst.Factory.FactoryMethod.Pizza;

namespace HeadFirst.Factory.FactoryMethod.PizzaStore
{
    internal class NewYorkStylePizza : AbstractPizzaStore
    {
        protected override AbstractPizza CreatePizza(PizzaTypes pizzaTypes)
        {
            switch (pizzaTypes)
            {
                case PizzaTypes.Cheese:
                    return new Pizza.NewYork.CheesePizza();
                case PizzaTypes.Veggie:
                    return new Pizza.NewYork.VeggiePizza();
                default:
                    throw new ArgumentException("Pizza type not found");
            }
        }
    }
}
