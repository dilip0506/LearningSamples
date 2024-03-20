namespace HeadFirst.Factory.AbstractFactory.Ingredient
{
    internal class ThinCrustDough : IDough
    {
        public ThinCrustDough()
        {
            PrintName();
        }
        public void PrintName()
        {
            Console.WriteLine("Thin Crust Dough");
        }
    }
}
