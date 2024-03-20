using WebBlog.GaurdClaues;
using WebBlog.Specifications.Factory;
using WebBlog.Specifications.Rule;
using WebBlog.Specifications.TransferObjects;

namespace WebBlog.Specifications.ValidationAsExample
{
    internal class BatchValidation : ValidationChain<Person>
    {
        private readonly IValidationFactory<Person,
            PersonContexts> _validationFactory;

        public BatchValidation(PersonContexts personContexts)
        {
            Gaurd<PersonContexts>.IsNull(personContexts, "Person Context");

            _validationFactory = new ValidationFactory();
            RegisterValidation(
                new ValidationRule(_validationFactory.CreateNameValidation(),
                "Enter a Valid Message"))
           .RegisterValidation(
                new ValidationRule(_validationFactory.CreatePhoneValidation(),
                "Enter a Valid Phone"))
           .RegisterValidation(
                new ValidationRule(_validationFactory.CreateValidNames(personContexts),
                "Name not found"));
        }
    }
}
