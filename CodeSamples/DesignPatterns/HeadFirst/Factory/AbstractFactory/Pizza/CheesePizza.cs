using HeadFirst.Factory.AbstractFactory.IngredientFactory;

namespace HeadFirst.Factory.AbstractFactory.Pizza
{
    internal class CheesePizza : AbstractPizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;
        public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }
        public override void Cut()
        {
            Console.WriteLine("Cut in NewYork style");
        }

        public override void Prepare()
        {
            _pizzaIngredientFactory.CreateCalm();
            _pizzaIngredientFactory.CreateDough();
        }

    }
}
