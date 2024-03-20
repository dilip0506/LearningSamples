using WebBlog.Specifications.Rule;
using WebBlog.Specifications.TransferObjects;

namespace WebBlog.Specifications.ValidationAsExample
{
    internal interface IValidation<T> where T : class
    {
        IValidation<T> RegisterValidation(IValidationRule<T> validationRule);
        ValidationResult Validate(T TEntity);
    }
}
