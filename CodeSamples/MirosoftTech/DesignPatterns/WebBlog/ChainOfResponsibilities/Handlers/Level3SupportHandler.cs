namespace WebBlog.ChainOfResponsibilities.Handlers
{
    internal class Level3SupportHandler : SupportHandlerBase<Ticket>
    {
        protected override bool CanHandleTicket(Ticket ticket)
        {
            return ticket.Severity == Severity.High;
        }

        protected override void Handle(Ticket ticket)
        {
            Console.WriteLine("Level 3 Support handles the ticket.");
        }
    }
}
