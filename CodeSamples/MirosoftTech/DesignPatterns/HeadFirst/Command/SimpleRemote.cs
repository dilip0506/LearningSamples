namespace HeadFirst.Command
{
    internal class SimpleRemote
    {
        private readonly ICommand[] _onCommand = new ICommand[7];
        private readonly ICommand[] _offCommand = new ICommand[7];

        public void SetCommand(int index, ICommand onCommand, ICommand OffCommand)
        {
            _onCommand[index] = onCommand;
            _offCommand[index] = OffCommand;
        }

        public void On(int index)
        {
            _onCommand[index].Execute();
        }

        public void Off(int index)
        {
            _offCommand[index].Execute();
        }
    }
}
