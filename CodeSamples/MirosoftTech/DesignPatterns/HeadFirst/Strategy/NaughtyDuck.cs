using System;

namespace HeadFirst.Strategy
{
    public class NaughtyDuck : Duck
    {
        public NaughtyDuck()
        {
            FlyBehaviour = new Behaviour.FlyWithWings();
            QuackBehaviour = new Behaviour.Quack();
        }
        public override void PrintName()
        {
            Console.WriteLine("This is Naught Duck");
        }

    }
}
