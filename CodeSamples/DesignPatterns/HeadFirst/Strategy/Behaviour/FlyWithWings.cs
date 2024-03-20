using HeadFirst.Strategy.Interface;
using System;

namespace HeadFirst.Strategy.Behaviour
{
    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Hi from Fly with Wings");
        }
    }
}
