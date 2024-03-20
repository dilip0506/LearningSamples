using HeadFirst.Command.Device;

namespace HeadFirst.Command.Command
{
    internal class LightOffCommand : ICommand
    {
        private readonly LightBulb _lightBulb;

        public LightOffCommand(LightBulb lightBulb)
        {
            _lightBulb = lightBulb;
        }

        public void Execute()
        {
            _lightBulb.Off("no delegate");
        }
    }
}
