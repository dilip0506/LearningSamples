namespace WebBlog.Specifications.TransferObjects
{
    internal class ValidationResult
    {
        public List<ValidationError> ValidationErrors { get; } = new List<ValidationError>();

        public bool IsValid => !ValidationErrors.Any();

        public void Add(ValidationError error)
        {
            ValidationErrors.Add(error);
        }

        public void Remove(ValidationError error)
        {
            if (ValidationErrors.Contains(error))
            {
                ValidationErrors.Remove(error);
            }
        }
    }
}
