namespace WebBlog.ChainOfResponsibilities.Handlers
{
    internal class Level2SupportHandler : SupportHandlerBase<Ticket>
    {
        protected override bool CanHandleTicket(Ticket ticket)
        {
            return ticket.Severity == Severity.Medium;
        }

        protected override void Handle(Ticket ticket)
        {
            Console.WriteLine("Level 2 Support handles the ticket.");
        }
    }
}
