using HeadFirst.Factory.FactoryMethod.Pizza;

namespace HeadFirst.Factory.FactoryMethod.PizzaStore
{
    internal class TexasStylePizza : AbstractPizzaStore
    {
        protected override AbstractPizza CreatePizza(PizzaTypes pizzaTypes)
        {
            switch (pizzaTypes)
            {
                case PizzaTypes.Cheese:
                    return new Pizza.Texas.CheesePizza();
                case PizzaTypes.Veggie:
                    return new Pizza.Texas.VeggiePizza();
                default:
                    throw new ArgumentException("Pizza Type not found");
            }
        }
    }
}
