using HeadFirst.Command.Device;

namespace HeadFirst.Command.Command
{
    internal class LightOnCommand : ICommand
    {
        private readonly LightBulb _lightBulb;

        public LightOnCommand(LightBulb lightBulb)
        {
            _lightBulb = lightBulb;
        }

        public void Execute()
        {
            _lightBulb.On("no delegate");
        }
    }
}
