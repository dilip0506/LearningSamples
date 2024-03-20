using System;
using System.Reflection;

namespace reflections
{
    class Program
    {
        static void Property() {
            Human cp = new Human();
            var type = cp.GetType();
            var property = type.GetProperty("Life");
            var value = property.GetValue(cp,null);
            Console.WriteLine(property);
        }
        static void Main(string[] args)
        {
            //.GetType() runtime //typeof() compile time
            //var hum = (Human)Activator.CreateInstance(typeof(Human));//if casted we can see all types
            object hum = Activator.CreateInstance(typeof(Human));
            //Type hum = Type.GetType("reflections.Human");//can also do this
            //var humgen = Activator.CreateInstance<Human>();
            PropertyInfo[] propertyinfo = typeof(Human).GetProperties();//or hum.GetType() for type
            foreach (PropertyInfo p in propertyinfo) {
                Console.WriteLine(p);
            }
            //Console.WriteLine(propertyinfo[2]);
            PropertyInfo propertyinfo2 = null;
            foreach (PropertyInfo p in propertyinfo) {
                if (p.Name.Equals("Life",StringComparison.InvariantCulture))
                {
                    propertyinfo2 = p;
                }
            }
            propertyinfo[0].SetValue(hum,0,null);
            // propertyinfo[0].GetValue(hum,null);
            // Console.WriteLine(propertyinfo[0].GetValue(hum, null));
            //ConstructorInfo[] cons = hum.GetType().GetConstructors();
            //var cons = hum.GetType().GetConstructor(new Type[0]);
            var cons = hum.GetType().GetConstructor(new[] { typeof(int)});//flower braces are for parameters to constructor
            //read refrence for more
            Console.WriteLine(cons);
            /*
            //for single property or method
            Human c1 = new Human();
            Type ct = typeof (Human);
            Console.WriteLine(ct);
            Type ct2 = c1.GetType();
            Console.WriteLine(ct2.Name);
            Console.WriteLine(ct2.Assembly);
            */
            // Property();
            Console.ReadLine();
        }
    }

    public class Human {
        public int Life { get; set; }
        public Job Job { get; set; }
        public Human() {
            Life = 10;
           // Console.WriteLine("default constructor");
        }
        public Human(int leg) {
            Life = leg;
            //Console.WriteLine("the number{0}", leg);
        }
        public void x() {
        }
    }
    public enum Job { none, eat, sleep };
}
