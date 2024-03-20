namespace HeadFirst.State.State
{
    internal class SoldOut : IState
    {
        private readonly GumballMachine _gumballMachine;

        public SoldOut(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispence()
        {
            Console.WriteLine("Sold Out");
        }

        public void EjectQuater()
        {
            Console.WriteLine("Sold Out");
        }

        public void InsertQuater()
        {
            Console.WriteLine("Sold Out");
        }

        public void Refill()
        {
            _gumballMachine.SetState(_gumballMachine.NoQuater);
        }

        public void TrunkCrank()
        {
            Console.WriteLine("Sold Out");
        }
    }
}
