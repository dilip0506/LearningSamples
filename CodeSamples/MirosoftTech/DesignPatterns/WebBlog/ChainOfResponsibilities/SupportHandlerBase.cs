namespace WebBlog.ChainOfResponsibilities
{
    internal abstract class SupportHandlerBase<T> : ISupportHandler<T>
    {
        private ISupportHandler<T> _nextHandler;

        public void SetNextHandler(ISupportHandler<T> handler)
        {
            _nextHandler = handler;
        }

        public virtual void HandleType(T type)
        {
            if (CanHandleTicket(type))
            {
                Handle(type);
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleType(type);
            }
            else
            {
                Console.WriteLine("Ticket cannot be handled.");
            }
        }

        protected abstract bool CanHandleTicket(T type);
        protected abstract void Handle(T type);
    }
}
