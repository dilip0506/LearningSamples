using System;

namespace HeadFirst.Strategy
{
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehaviour = new Behaviour.FlyWithoutWings();
            QuackBehaviour = new Behaviour.MuteQuack();
        }
        public override void PrintName()
        {
            Console.WriteLine("This is Rubber Duck");
        }

    }
}
