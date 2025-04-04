namespace HeadFirst.Factory.AbstractFactory
{
    internal abstract class AbstractPizza
    {
        public abstract void Prepare();

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
