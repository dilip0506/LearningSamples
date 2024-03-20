using WebBlog.Specifications.Rule;
using WebBlog.Specifications.TransferObjects;

namespace WebBlog.Specifications.ValidationAsExample
{
    class ValidationChain<T> : IValidation<T> where T : class
    {

        readonly List<IValidationRule<T>> validationRules = new();

        public IValidation<T> RegisterValidation(IValidationRule<T> specifcation)
        {
            validationRules.Add(specifcation);
            return this;
        }

        public ValidationResult Validate(T TEntity)
        {
            ValidationResult errors = new();
            foreach (var rule in validationRules)
            {
                if (!rule.Validate(TEntity))
                {
                    errors.Add(new ValidationError(rule.Message));
                }
            }
            return errors;
        }
    }
}
