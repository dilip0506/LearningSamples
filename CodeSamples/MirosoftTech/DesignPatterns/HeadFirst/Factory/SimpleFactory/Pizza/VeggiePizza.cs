namespace HeadFirst.Factory.SimpleFactory.Pizza
{
    internal class VeggiePizza : AbstractPizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Veggie Pizza Pizza");
        }
    }
}
