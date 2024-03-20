namespace WebBlog.ChainOfResponsibilities
{
    public class Ticket
    {
        public Severity Severity { get; set; }
    }

    public enum Severity
    {
        Low,
        Medium,
        High
    }

}