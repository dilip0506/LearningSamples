namespace Udemy.Builder
{

    public class PersonFaceted
    {
        //address
        public string StreetAddress { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }

        //employment
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string AnnualIncome { get; set; }

        public override string ToString()
        {
            return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(Postcode)}: {Postcode}, {nameof(City)}: {City}, {nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {Position}, {nameof(AnnualIncome)}: {AnnualIncome}";
        }
    }
    public class PersonFacetedBuilder
    {
        protected PersonFaceted Person { get; set; }
        //reference Type
        public PersonFacetedBuilder()
        {
            Person = new PersonFaceted();
        }

        public PersonJobFacetedBuilder Works => new PersonJobFacetedBuilder(Person);
        public PersonAddressFacetedBuilder Lives => new PersonAddressFacetedBuilder(Person);

        //we write a api to return person object best way
        // public PersonFaceted Build() => Person;

        //we can also use a implicit operator to convert the object to person return type not a best way or right way
        //we cannot use var in this case
        public static implicit operator PersonFaceted(PersonFacetedBuilder pb)
        {
            return pb.Person;
        }
    }

    public class PersonJobFacetedBuilder : PersonFacetedBuilder
    {
        public PersonJobFacetedBuilder(PersonFaceted person)
        {
            Person = person;
        }

        public PersonJobFacetedBuilder WorksAt(string companyName)
        {
            Person.CompanyName = companyName;
            return this;
        }

        public PersonJobFacetedBuilder WorksAs(string position)
        {
            Person.Position = position;
            return this;
        }

        public PersonJobFacetedBuilder Salary(string annualIncome)
        {
            Person.AnnualIncome = annualIncome;
            return this;
        }
    }

    public class PersonAddressFacetedBuilder : PersonFacetedBuilder
    {
        public PersonAddressFacetedBuilder(PersonFaceted person)
        {
            Person = person;
        }

        public PersonAddressFacetedBuilder Street(string streetAddress)
        {
            Person.StreetAddress = streetAddress;
            return this;
        }

        public PersonAddressFacetedBuilder Postcode(string postcode)
        {
            Person.Postcode = postcode;
            return this;
        }

        public PersonAddressFacetedBuilder City(string city)
        {
            Person.City = city;
            return this;
        }
    }

    class FacetedBuilder
    {
        public static void Main()
        {
            PersonFacetedBuilder pb = new PersonFacetedBuilder();
            PersonFaceted person = pb.Works.WorksAs("dev")
                .Lives.Street("Dallas");
            //.Build();
            Console.WriteLine(person);
            Console.Read();
        }
    }
}
