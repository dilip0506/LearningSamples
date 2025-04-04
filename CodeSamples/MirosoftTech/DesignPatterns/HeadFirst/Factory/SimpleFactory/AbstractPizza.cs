namespace HeadFirst.Factory.SimpleFactory
{
    public abstract class AbstractPizza
    {
        public virtual void Prepare()
        {
            Console.WriteLine("Abstract Pizza Pizza");
        }

        public virtual void Baking()
        {
            Console.WriteLine("baking Pizza");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cut Pizza");
        }

        public virtual void Ship()
        {
            Console.WriteLine("Ship Pizza");
        }

    }
}
