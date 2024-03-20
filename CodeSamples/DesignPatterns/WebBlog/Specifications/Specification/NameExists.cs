using WebBlog.Specifications.TransferObjects;

namespace WebBlog.Specifications.Specification
{
    internal class NameExists : ISpecification<Person>
    {
        public PersonContexts PersonContexts { get; set; }

        public NameExists(PersonContexts personContexts)
        {
            PersonContexts = personContexts;
        }
        public bool IsSatisfied(Person person)
        {
            return PersonContexts.Names.Contains(person.Name);
        }
    }
}
