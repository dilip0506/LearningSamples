namespace WebBlog.ChainOfResponsibilities.Handlers
{
    internal class Level1SupportHandler : SupportHandlerBase<Ticket>
    {
        protected override bool CanHandleTicket(Ticket ticket)
        {
            return ticket.Severity == Severity.Low;
        }

        protected override void Handle(Ticket ticket)
        {
            Console.WriteLine("Level 1 Support handles the ticket.");
        }
    }
}
