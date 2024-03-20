using HeadFirst.Command.Command;
using HeadFirst.Command.Device;

namespace HeadFirst.Command
{
    internal class SimpleRemoteTest
    {
        public static void Use()
        {
            LightBulb LightBulb = new();
            LightOnCommand lightOnCommand = new(LightBulb);
            LightOffCommand lightOffCommand = new(LightBulb);
            SimpleRemote SimpleRemote = new();
            SimpleRemote.SetCommand(0, lightOnCommand, lightOffCommand);
            SimpleRemote.On(0);
            SimpleRemote.Off(0);
        }

        public static void UseDelegate()
        {
            LightBulb LightBulb = new();
            SimpleRemoteDelegate simpleRemoteDelegate = new();
            simpleRemoteDelegate.SetCommand(0, () => LightBulb.On("On"), () => LightBulb.Off("Off"));
            simpleRemoteDelegate.On(0);
            simpleRemoteDelegate.Off(0);
        }
    }
}
