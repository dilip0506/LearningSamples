using HeadFirst.Factory.AbstractFactory.Ingredient;

namespace HeadFirst.Factory.AbstractFactory.IngredientFactory
{
    internal class NewYorkPizzaIngredient : IPizzaIngredientFactory
    {
        public ICalm CreateCalm()
        {
            return new TexasCalm();
        }

        public ICheese CreateCheese()
        {
            return new NewYorkCheese();
        }

        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }
    }
}
