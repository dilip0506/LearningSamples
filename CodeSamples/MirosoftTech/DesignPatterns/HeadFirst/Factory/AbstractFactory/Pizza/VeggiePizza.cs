using HeadFirst.Factory.AbstractFactory.IngredientFactory;

namespace HeadFirst.Factory.AbstractFactory.Pizza
{
    internal class VeggiePizza : AbstractPizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;
        public VeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }
        public override void Prepare()
        {
            _pizzaIngredientFactory.CreateCalm();
            _pizzaIngredientFactory.CreateDough();
        }
    }
}
