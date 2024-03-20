using HeadFirst.Factory.AbstractFactory.Ingredient;

namespace HeadFirst.Factory.AbstractFactory.IngredientFactory
{
    internal class TexasPizzaIngredien : IPizzaIngredientFactory
    {
        public ICalm CreateCalm()
        {
            return new NewYorkClam();
        }

        public ICheese CreateCheese()
        {
            return new TexasCheese();
        }

        public IDough CreateDough()
        {
            return new ThinkCrustDough();
        }
    }
}
