namespace WebBlog.ChainOfResponsibilities
{
    internal interface ISupportHandler<T>
    {
        void SetNextHandler(ISupportHandler<T> handler);
        void HandleType(T type);
    }
}
