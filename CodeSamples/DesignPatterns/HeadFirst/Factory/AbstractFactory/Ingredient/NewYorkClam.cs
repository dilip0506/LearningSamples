namespace HeadFirst.Factory.AbstractFactory.Ingredient
{
    internal class NewYorkClam : ICalm
    {
        public NewYorkClam()
        {
            PrintName();
        }
        public void PrintName()
        {
            Console.WriteLine("NewYork Calm");
        }
    }
}
