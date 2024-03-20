namespace HeadFirst.State.State
{
    internal class HasQuater : IState
    {
        private readonly GumballMachine _gumballMachine;
        Random random = new(DateTime.Now.Second);

        public HasQuater(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispence()
        {
            Console.WriteLine("No gumball dispensed");

        }

        public void EjectQuater()
        {
            Console.WriteLine("Quater returned");
            _gumballMachine.SetState(_gumballMachine.NoQuater);
        }

        public void InsertQuater()
        {
            Console.WriteLine("You can't inserted a quater");
        }

        public void Refill()
        {
            Console.WriteLine("Is not empty");
        }

        public void TrunkCrank()
        {
            Console.WriteLine("You turned");
            int winner = random.Next(10);
            if (winner == 0 && _gumballMachine.Count > 0)
            {
                _gumballMachine.SetState(_gumballMachine.Winner);
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.Sold);
            }
        }
    }
}
