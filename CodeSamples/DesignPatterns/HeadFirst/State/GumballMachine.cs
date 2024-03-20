using HeadFirst.State.State;

namespace HeadFirst.State
{
    internal class GumballMachine
    {
        //Can move state objects to static varible if you a lot of instance of this/context class     
        public IState SoldOut { get; }
        public IState Sold { get; }
        public IState HasQuater { get; }
        public IState NoQuater { get; }
        public IState Winner { get; }

        private IState _state;
        public int Count { get; private set; } = 0;

        public GumballMachine(int numberOfGumballs)
        {

            SoldOut = new SoldOut(this);
            Sold = new Sold(this);
            HasQuater = new HasQuater(this);
            NoQuater = new NoQuater(this);
            Winner = new Winner(this);

            Count = numberOfGumballs;

            if (numberOfGumballs > 0)
            {
                _state = NoQuater;
            }
            else
            {
                _state = SoldOut;
            }
        }

        public void EjectQuater()
        {
            _state.EjectQuater();
        }

        public void InsertQuater()
        {
            _state.InsertQuater();
        }

        public void Trunk()
        {
            _state.TrunkCrank();
            _state.Dispence();
        }

        public void Refill(int count)
        {
            Count += count;
            Console.WriteLine("Refilled");
            _state.Refill();
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("Released");
            if (Count > 0)
            {
                Count--;
            }
        }
    }
}
