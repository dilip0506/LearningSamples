using WebBlog.Specifications.Specification;
using WebBlog.Specifications.TransferObjects;

namespace WebBlog.Specifications.Factory
{
    internal interface IValidationFactory<T, TC> where T : class
    {
        ISpecification<T> CreateNameValidation();
        ISpecification<T> CreatePhoneValidation();
        ISpecification<Person> CreateValidNames(TC tc);
    }
}
