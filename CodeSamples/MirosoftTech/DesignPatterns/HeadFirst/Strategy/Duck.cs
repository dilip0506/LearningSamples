using HeadFirst.Strategy.Behaviour;
using HeadFirst.Strategy.Interface;

namespace HeadFirst.Strategy
{
    public abstract class Duck
    {

        private IFlyBehaviour _flyBehaviourVar;

        private IQuackBehaviour _quackBehaviour;

        protected Duck()
        {
            _flyBehaviourVar = new FlyWithWings();
            _quackBehaviour = new Quack();

        }

        protected IQuackBehaviour QuackBehaviour
        {
            set => _quackBehaviour = value;
        }

        protected IFlyBehaviour FlyBehaviour
        {
            set => _flyBehaviourVar = value;
        }

        public void PerformQuack()
        {
            _quackBehaviour.Play();

        }

        public void PerformFly()
        {
            _flyBehaviourVar.Fly();
        }

        public abstract void PrintName();
    }
}
