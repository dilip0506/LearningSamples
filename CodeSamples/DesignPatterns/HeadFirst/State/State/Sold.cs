namespace HeadFirst.State.State
{
    internal class Sold : IState
    {
        private readonly GumballMachine _gumballMachine;

        public Sold(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispence()
        {
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.SetState(_gumballMachine.NoQuater);
            }
            else
            {
                Console.WriteLine("out of gumball");
                _gumballMachine.SetState(_gumballMachine.SoldOut);
            }

        }

        public void EjectQuater()
        {
            Console.WriteLine("You already turned the crank");
        }

        public void InsertQuater()
        {
            Console.WriteLine("Please wait we are already giving you gumball");
        }

        public void Refill()
        {
            Console.WriteLine("Is not empty");
        }

        public void TrunkCrank()
        {
            Console.WriteLine("Turning twice doesn't get another gumball");
        }
    }
}
