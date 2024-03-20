using WebBlog.Specifications.TransferObjects;

namespace WebBlog.Specifications.Specification
{
    internal class PhoneValidation : ISpecification<Person>
    {
        public bool IsSatisfied(Person person)
        {
            return person.Phone != 0;
        }
    }
}
