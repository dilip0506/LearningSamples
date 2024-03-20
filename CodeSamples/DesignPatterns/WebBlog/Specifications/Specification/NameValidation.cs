using WebBlog.Specifications.TransferObjects;

namespace WebBlog.Specifications.Specification
{
    internal class NameValidation : ISpecification<Person>
    {

        public bool IsSatisfied(Person person)
        {
            return !string.IsNullOrWhiteSpace(person.Name);
        }
    }
}
