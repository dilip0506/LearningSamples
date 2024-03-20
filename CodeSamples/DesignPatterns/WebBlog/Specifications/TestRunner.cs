using WebBlog.Specifications.TransferObjects;
using WebBlog.Specifications.ValidationAsExample;

namespace WebBlog.Specifications
{
    public static class TestRunner
    {
        public static void Run()
        {
            var persons = new List<Person>()
            {
                new Person {
                Name = "",
                Phone = 0
                },
                new Person {
                Name = "",
                Phone=44
                }
            };

            var bv = new BatchValidation(new PersonContexts());
            foreach (var person in persons)
            {
                var result = bv.Validate(person);
                if (!result.IsValid)
                {
                    foreach (var t in result.ValidationErrors)
                    {
                        Console.WriteLine(t.Message);
                    }
                }
            }
        }
    }
}
