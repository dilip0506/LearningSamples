namespace WebBlog.Specifications.Specification
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T TEntity);
    }
}
