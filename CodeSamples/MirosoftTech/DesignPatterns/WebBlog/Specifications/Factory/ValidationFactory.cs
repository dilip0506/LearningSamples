using WebBlog.Specifications.Specification;
using WebBlog.Specifications.TransferObjects;

namespace WebBlog.Specifications.Factory
{
    internal class ValidationFactory : IValidationFactory<Person, PersonContexts>
    {
        public ISpecification<Person> CreateNameValidation()
        {

            return new NameValidation();
        }

        public ISpecification<Person> CreatePhoneValidation()
        {
            return new PhoneValidation();
        }

        public ISpecification<Person> CreateValidNames(PersonContexts personContexts)
        {
            return new NameExists(personContexts);
        }
    }
}
