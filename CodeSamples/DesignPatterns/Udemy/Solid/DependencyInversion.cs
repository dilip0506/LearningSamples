using static System.Console;

namespace Udemy.Solid
{
    public enum Relationship
    {
        Parent,
        Child,
        Sibling
    }

    public class Person
    {
        public string Name { get; set; }
    }

    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }

    //low level implementation
    public class Relation : IRelationshipBrowser
    {
        private List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }
        //  public List<(Person, Relationship, Person)> Relations => relations;
        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return relations
                .Where(x => x.Item1.Name == name
                            && x.Item2 == Relationship.Parent).Select(r => r.Item3);
        }


    }
    class DependencyInversion
    {
        //    public DependencyInversion(Relation relation)
        //    {
        // high-level: find all of john's children
        //var relations = relationships.Relations;
        //foreach (var r in relations
        //  .Where(x => x.Item1.Name == "John"
        //              && x.Item2 == Relationship.Parent))
        //{
        //  WriteLine($"John has a child called {r.Item3.Name}");
        //}

        //    }
        public DependencyInversion(IRelationshipBrowser browser)
        {
            foreach (var p in browser.FindAllChildrenOf("Ragu"))
            {
                WriteLine($"John has a child called {p.Name}");
            }
        }
        static void Main()
        {
            Person p1 = new Person { Name = "Ragu" };
            Person p2 = new Person { Name = "Rahul" };
            Person p3 = new Person { Name = "Ram" };
            Relation rr = new Relation();
            rr.AddParentAndChild(p1, p2);
            rr.AddParentAndChild(p2, p3);
            new DependencyInversion(rr);
            Read();
        }
    }
}
