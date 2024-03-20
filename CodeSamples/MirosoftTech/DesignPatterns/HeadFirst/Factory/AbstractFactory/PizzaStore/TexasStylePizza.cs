using HeadFirst.Factory.AbstractFactory.IngredientFactory;
using HeadFirst.Factory.AbstractFactory.Pizza;

namespace HeadFirst.Factory.AbstractFactory.PizzaStore
{
    internal class TexasStylePizza : AbstractPizzaStore
    {
        protected override AbstractPizza CreatePizza(PizzaTypes pizzaTypes)
        {
            var pizzaIngredient = new TexasPizzaIngredien();

            return pizzaTypes switch
            {
                PizzaTypes.Cheese => new CheesePizza(pizzaIngredient),
                PizzaTypes.Veggie => new VeggiePizza(pizzaIngredient),
                _ => throw new ArgumentException("Pizza Type not found"),
            };
        }
    }
}
