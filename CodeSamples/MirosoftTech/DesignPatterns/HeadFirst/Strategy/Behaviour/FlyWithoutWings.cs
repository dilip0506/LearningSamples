using HeadFirst.Strategy.Interface;
using System;

namespace HeadFirst.Strategy.Behaviour
{
    class FlyWithoutWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Hi from Fly without wings");
        }
    }
}
