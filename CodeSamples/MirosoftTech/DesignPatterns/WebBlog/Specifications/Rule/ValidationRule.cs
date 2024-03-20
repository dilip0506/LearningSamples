using WebBlog.Specifications.Specification;
using WebBlog.Specifications.TransferObjects;

namespace WebBlog.Specifications.Rule
{
    internal class ValidationRule : IValidationRule<Person>
    {
        readonly ISpecification<Person> _specifcation;
        public ValidationRule(ISpecification<Person> specifcation, string message)
        {
            Message = message;
            _specifcation = specifcation;
        }

        public string Message { get; set; }

        public bool Validate(Person person)
        {
            return _specifcation.IsSatisfied(person);
        }
    }
}
