namespace HeadFirst.Factory.AbstractFactory.Ingredient
{
    internal class TexasCalm : ICalm
    {
        public TexasCalm()
        {
            PrintName();
        }

        public void PrintName()
        {
            Console.WriteLine("Texas Calm");
        }
    }
}
