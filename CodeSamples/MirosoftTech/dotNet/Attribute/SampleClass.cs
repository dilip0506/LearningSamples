using System;

namespace AttributeEx
{
    [AttributeUsage(AttributeTargets.Class)]//we can restrict the type on which attribute can be used
    public class SampleAttribute : Attribute
    {
        public String Name { get; set; }
    }
    public class Sample1Attribute : Attribute//can be used on any type
    {
        public String Name1 { get; set; }
    }

    [Sample1]
    [Sample(Name = "dilip")]//info to attribute, known by reflection
    public class SampleClass
    {
        [Sample1]
        void SampleMethod()
        {
        }
    }
}
