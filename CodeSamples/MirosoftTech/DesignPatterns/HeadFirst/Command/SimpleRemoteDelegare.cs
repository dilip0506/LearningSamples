namespace HeadFirst.Command
{
    internal class SimpleRemoteDelegate
    {
        private readonly Action[] _onCommand = new Action[7];
        private readonly Action[] _offCommand = new Action[7];

        public void SetCommand(int index, Action onCommand, Action OffCommand)
        {
            _onCommand[index] = onCommand;
            _offCommand[index] = OffCommand;
        }

        public void On(int index)
        {
            _onCommand[index]();
        }

        public void Off(int index)
        {
            _offCommand[index]();
        }
    }
}
