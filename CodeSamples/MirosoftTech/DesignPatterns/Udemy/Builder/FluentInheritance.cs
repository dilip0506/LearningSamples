namespace Udemy.Builder
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }

        public Person()
        {
        }

        public class Builder : PersonPositionBuilder<Builder>
        {
        }

        public static Builder NewBuilder => new Builder();

        public Person(string name, string address, string position)
        {
            Name = name;
            Address = address;
            Position = position;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Address)}:{Address}, {nameof(Position)}:{Position}";
        }
    }


    //fluent builder will not support a normal inheritance
    //because if we call Called method it return the reference of parent class which does not know about WorksAt which is in child class
    //uses Recursive Generics
    //public class PersonInfoBuilder
    //{
    //    protected Person person = new Person();
    //    public PersonInfoBuilder Called(string name)
    //    {
    //        person.Name = name;
    //        return this;
    //    }

    //}

    //public class PersonJobBuilder : PersonInfoBuilder
    //{
    //    public PersonJobBuilder WorksAt(string Address)
    //    {
    //        person.Address = Address;
    //        return this;
    //    }
    //}

    public abstract class PersonBuilder
    {
        protected Person Person = new Person();

        public Person Build()
        {
            return Person;
        }
    }


    public class PersonInfoBuilder<TSelf> :
        PersonBuilder where TSelf : PersonInfoBuilder<TSelf>
    {
        public TSelf Called(string name)
        {
            Person.Name = name;
            return (TSelf)this;
        }

    }

    public class PersonJobBuilder<TSelf> :
        PersonInfoBuilder<PersonJobBuilder<TSelf>> where TSelf : PersonJobBuilder<TSelf>
    {
        public TSelf WorksAt(string address)
        {
            Person.Address = address;
            return (TSelf)this;
        }
    }

    public class PersonPositionBuilder<TSelf> : PersonJobBuilder<PersonPositionBuilder<TSelf>>
        where TSelf : PersonPositionBuilder<TSelf>
    {
        public TSelf WorksAs(string position)
        {
            Person.Position = position;
            return (TSelf)this;
        }
    }


    internal class FluentInheritance
    {
        public static void Main()
        {
            //if you see commented class and methods fluent builder will not work with inheritance
            //because if we call Called method it return the reference of parent class which does not know about WorksAt which is in child class
            //to make it work we use recursive generics
            //var personInfo = new PersonJobBuilder();
            //personInfo.Called("dilip").Called("Dilip").WorksAt("hyd");
            var me = Person.NewBuilder.Called("Full").WorksAt("HYD").WorksAs("Developer").Build();
            Console.WriteLine(me);
            Console.Read();

        }
    }
}
