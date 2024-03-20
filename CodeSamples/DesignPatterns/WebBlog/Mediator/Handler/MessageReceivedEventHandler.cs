namespace WebBlog.Mediator.Handler
{
    public delegate void MessageReceivedEventHandler(string message, string sender);

    public class MediatorHandler
    {
        public event MessageReceivedEventHandler MessageReceived;

        public void Send(string message, string sender)
        {
            if (MessageReceived != null)
            {
                Console.WriteLine("Sending '{0}' from {1}", message, sender);
                MessageReceived(message, sender);
            }
        }
    }
}
