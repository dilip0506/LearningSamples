namespace WebBlog.Specifications.Rule
{
    internal interface IValidationRule<T>
    {
        public string Message { get; set; }

        public bool Validate(T TEntity);
    }
}
