namespace Udemy.Builder
{

    public class PersonFunctional
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}:{Position}";
        }
    }

    public class PersonBuilderFunctional
    {
        public readonly List<Action<PersonFunctional>> Actions = new List<Action<PersonFunctional>>();
        public PersonBuilderFunctional Called(string name)
        {
            Actions.Add(x => x.Name = name);
            return this;
        }

        public PersonFunctional Build()
        {
            var person = new PersonFunctional();
            Actions.ForEach(p => p(person));
            return person;
        }
    }

    public static class PersonBuilderFunctionalExtensions
    {
        public static PersonBuilderFunctional WorksAs(this PersonBuilderFunctional builder, string position)
        {
            builder.Actions.Add(x => x.Position = position);
            return builder;
        }
    }


    class FunctionalBuilder
    {

        static void Main()
        {
            var p = new PersonBuilderFunctional();
            Console.WriteLine(p.Called("Dilip").WorksAs("Paycom").Build());
            Console.Read();
        }
    }
}
