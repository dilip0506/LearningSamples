using HeadFirst.Strategy.Interface;
using System;

namespace HeadFirst.Strategy.Behaviour
{
    class MuteQuack : IQuackBehaviour
    {
        void IQuackBehaviour.Play()
        {
            Console.WriteLine("Hi form Squeak");
        }
    }
}
