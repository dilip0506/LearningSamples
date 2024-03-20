namespace HeadFirst.Factory.AbstractFactory.Ingredient
{
    internal class ThinkCrustDough : IDough
    {
        public ThinkCrustDough()
        {
            PrintName();
        }
        public void PrintName()
        {
            Console.WriteLine("Think Crust Dough");
        }
    }
}
