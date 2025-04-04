using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //porblem without generic class
            bool i = NonGenericCLass.Equal(1, 1);//can send only int type
            bool j = NonGenericCLass.Equalob("a", "b"); //can pass any type parameter is of type object
            bool k = NonGenericCLass.Equalob(1, 2);////passing int(value type) but the parameter is refrence type which is object boxing(converting value type to refrence type) occured (bixing and unboxing is costly)
            bool h = NonGenericCLass.Equalob("1", 1);//here one is value type and other is refrence type
            //with genrics
            bool l = GenericClass<int>.Equal(10, 11);//first pass type in "<>" operator and then arguments
            //bool y = GenericClass.<int>Equal(10, 11);//generics at method level
            bool r = GenericClass<string>.Equal("s", "k");
            GenericClassns<int> hy = new GenericClassns<int>();//creating generic class object
                hy.Equal(10, 11);
            Console.ReadKey();
        }

    }
    class NonGenericCLass{
        public static bool Equal(int i, int j) {
            return i == j;
        }

        public static bool Equalob(object i, object j)
        {
            return i == j;
        }
    }
    class GenericClass<T> {
        //public static bool Equal<T>(T i, T j)//we can also have generic at method here we impleted using class
        public static bool Equal(T i, T j) {
            return i.Equals(j); // because type is not specified here "==" not works
        }
    }
        class GenericClassns<Y>{
            //public static bool Equal<T>(T i, T j)//we can also have generic at method here we impleted using class
            public bool Equal(Y i, Y j)
            {
                return i.Equals(j); // because type is not specified here "==" not works
            }
        }
}
