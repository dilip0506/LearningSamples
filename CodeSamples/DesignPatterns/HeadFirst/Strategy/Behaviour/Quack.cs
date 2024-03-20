using HeadFirst.Strategy.Interface;
using System;

namespace HeadFirst.Strategy.Behaviour
{
    public class Quack : IQuackBehaviour
    {
        public void Play()
        {
            Console.WriteLine("Hi form Quack");
        }
    }
}
