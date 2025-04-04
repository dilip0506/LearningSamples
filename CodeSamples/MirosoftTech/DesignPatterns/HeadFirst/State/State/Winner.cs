namespace HeadFirst.State.State
{
    internal class Winner : IState
    {
        private readonly GumballMachine _gumballMachine;

        public Winner(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispence()
        {
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.Count == 0)
            {
                _gumballMachine.SetState(_gumballMachine.SoldOut);
            }
            else
            {
                _gumballMachine.ReleaseBall();
                Console.WriteLine("Winner");
                if (_gumballMachine.Count > 0)
                {
                    _gumballMachine.SetState(_gumballMachine.NoQuater);
                }
                else
                {
                    _gumballMachine.SetState(_gumballMachine.SoldOut);
                }

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
