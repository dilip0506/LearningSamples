using WebBlog.ChainOfResponsibilities.Handlers;

namespace WebBlog.ChainOfResponsibilities
{
    public static class TestRunner
    {
        public static void Run()
        {
            var level3SupportHandler = new Level3SupportHandler();
            var level2SupportHandler = new Level2SupportHandler();
            var level1SupportHandler = new Level1SupportHandler();

            level1SupportHandler.SetNextHandler(level2SupportHandler);
            level2SupportHandler.SetNextHandler(level3SupportHandler);

            var ticket1 = new Ticket { Severity = Severity.Low };
            var ticket2 = new Ticket { Severity = Severity.Medium };
            var ticket3 = new Ticket { Severity = Severity.High };

            level1SupportHandler.HandleType(ticket1);
           // level1SupportHandler.HandleType(ticket2);
            // level1SupportHandler.HandleType(ticket3);
        }
    }
}
